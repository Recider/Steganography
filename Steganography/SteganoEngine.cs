﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    class SteganoEngine
    {
        // TextSource - from what we get text to put into image
        // -1 - Unset
        // 0 - Selected TXT file
        // 1 - Custom text typed in another form
        public static int TextSource = -1;
        
        // RGBOverrdieMethod - which channel will be Overwrited
        // -1 - Unset
        // 0 - R
        // 1 - G
        // 2 - B
        // 3 - Alpha
        // 4 - RGB  (All RGB Channels)
        // 5 - ARGB (All ARGB Channels)
        public static int RGBOverwriteMethod = -1;

        public static String ImageInputLoc;
        public static String ImageOutputLoc;
        public static String TextFileLoc;
        public static String CustomText;
        public static String EOTString;

        public static Bitmap InputBitmap;
        public static Bitmap OutputBitmap;

        public static Boolean UseEOTString = false;

        public static Thread OverwriteChannelThread;
        public static Thread ReadingImageThread;

        public SteganoEngine() { }

        public static void SetUsingEOTString(Boolean value)
        {
            UseEOTString = value;
            Console.WriteLine("Changed property of Using EOT String: " + UseEOTString);
        }

        public static void SetEOTString(String value)
        {
            EOTString = value;
            Console.WriteLine("EOT String property set to: "+EOTString);
        }

        public static void SetTextSource(int set)
        {
            TextSource = set;
            System.Console.WriteLine("Set TextSource: "+TextSource);
        }

        public static void SetRGBOverwriteMethod(int set)
        {
            RGBOverwriteMethod = set;
            System.Console.WriteLine("Set RGBOverwriteMethod: " + RGBOverwriteMethod);
        }

        public static void SetImageInputLoc(String loc)
        {
            ImageInputLoc = loc;
            System.Console.WriteLine("Input image: " + ImageInputLoc);
        }

        public static void SetImageOutputLoc(String loc)
        {
            ImageOutputLoc = loc;
            System.Console.WriteLine("Output image: " + ImageOutputLoc);
        }

        public static void SetTextFileLoc(String loc)
        {
            TextFileLoc = loc;
            System.Console.WriteLine("Text file location: " + TextFileLoc);
        }

        public static void SetCustomText(String text)
        {
            CustomText = text;
            System.Console.WriteLine("Set custom text, length: " + CustomText.Length);
        }

        public static void ResetVariables()
        {
            ImageInputLoc = null;
            ImageOutputLoc = null;
            TextFileLoc = null;
            CustomText = null;
            RGBOverwriteMethod = -1;
            TextSource = -1;
            InputBitmap = null;
            OutputBitmap = null;
            EOTString = null;
            UseEOTString = false;
            System.Console.WriteLine("Static variables just got nulled.");
        }

        public static Boolean LoadBitmap()
        {
            try
            {
                InputBitmap = new Bitmap(ImageInputLoc);
                return true;
            }
            catch (Exception x)
            {
                System.Console.WriteLine(x.StackTrace);
                return false;
            }
        }

        public static void OverwriteColorChannel(Steganography.Forms.ImageOverwriterForm Interface){
            

            // load text from text file if file method was selected
            if (TextSource == 0)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(TextFileLoc))
                    {
                        CustomText = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Text file could not be read!");
                    Console.WriteLine(e.StackTrace);
                    Interface.CallErrorMessage(String.Format("Text file {0} could not be read!", TextFileLoc));
                    return;
                }
            }

            // create new bitmap and fill it
            OutputBitmap = (Bitmap)InputBitmap.Clone();
            // setup ProcessForm Status Controllers
            Interface.SetupProgressBar(CustomText.Length);
            OverwriteChannelThread = new Thread(delegate()
            {
                Boolean Failure = false;
                Boolean EndOfText = false;
                int i = 0;

                try
                {
                    for (int w = 0; w < InputBitmap.Width; w++)
                    {
                        if (EndOfText) break;
                        for (int h = 0; h < InputBitmap.Height; h++)
                        {
                            Color CurrentPixel = InputBitmap.GetPixel(w, h);
                            if ((w * (InputBitmap.Height - 1)) + h < CustomText.Length)
                            {
                                int OverwriteCharASCII = (int)CustomText[(w * (InputBitmap.Height - 1)) + h];
                                if (OverwriteCharASCII > 255)
                                {
                                    Console.WriteLine("WARNING: Char ASCII " + (int)CustomText[(w * (InputBitmap.Height - 1)) + h] + " is incorrect number for ARGB, omitting...");
                                }
                                else
                                {
                                    Console.WriteLine(String.Format("Overriding letter {0}, ASCII: {1}", CustomText[(w * (InputBitmap.Height - 1)) + h], (int)CustomText[(w * (InputBitmap.Height - 1)) + h]));
                                    switch (RGBOverwriteMethod)
                                    {
                                        case 0:
                                            CurrentPixel = Color.FromArgb(OverwriteCharASCII, CurrentPixel.G, CurrentPixel.B);
                                            break;
                                        case 1:
                                            CurrentPixel = Color.FromArgb(CurrentPixel.R, OverwriteCharASCII, CurrentPixel.B);
                                            break;
                                        case 2:
                                            CurrentPixel = Color.FromArgb(CurrentPixel.R, CurrentPixel.G, OverwriteCharASCII);
                                            break;
                                        case 3:
                                            CurrentPixel = Color.FromArgb(OverwriteCharASCII, CurrentPixel.R, CurrentPixel.G, CurrentPixel.B);
                                            break;
                                        case 4:
                                            CurrentPixel = Color.FromArgb(OverwriteCharASCII, OverwriteCharASCII, OverwriteCharASCII);
                                            break;
                                        case 5:
                                            CurrentPixel = Color.FromArgb(OverwriteCharASCII, OverwriteCharASCII, OverwriteCharASCII, OverwriteCharASCII);
                                            break;
                                    }
                                }
                                Console.WriteLine(String.Format("CurrentPixel [{0}, {1}, {2}, {3}]", CurrentPixel.A, CurrentPixel.R, CurrentPixel.G, CurrentPixel.B));
                                OutputBitmap.SetPixel(w, h, CurrentPixel);
                                Interface.UpdateProgress((w * (InputBitmap.Height - 1)) + h + 1, "Creating new bitmap...", (Image)OutputBitmap.Clone());
                                Thread.Sleep(1);
                            }
                            // End of string, optional stamping for EOT
                            else
                            {
                                
                                if (UseEOTString && i < EOTString.Length )
                                {
                                    CurrentPixel = InputBitmap.GetPixel(w, h);
                                    int OverwriteCharASCII = (int)EOTString[i];
                                    if (OverwriteCharASCII > 255)
                                        Console.WriteLine("WARNING: Char ASCII " + (int)EOTString[i] + " is incorrect number for ARGB, omitting...");
                                    else
                                    {
                                        Console.WriteLine(String.Format("Ovewriting EOT letter {0}, ASCII: {1}", EOTString[i], (int)CustomText[i]));
                                        switch (RGBOverwriteMethod)
                                        {
                                            case 0:
                                                CurrentPixel = Color.FromArgb(OverwriteCharASCII, CurrentPixel.G, CurrentPixel.B);
                                                break;
                                            case 1:
                                                CurrentPixel = Color.FromArgb(CurrentPixel.R, OverwriteCharASCII, CurrentPixel.B);
                                                break;
                                            case 2:
                                                CurrentPixel = Color.FromArgb(CurrentPixel.R, CurrentPixel.G, OverwriteCharASCII);
                                                break;
                                            case 3:
                                                CurrentPixel = Color.FromArgb(OverwriteCharASCII, CurrentPixel.R, CurrentPixel.G, CurrentPixel.B);
                                                break;
                                            case 4:
                                                CurrentPixel = Color.FromArgb(OverwriteCharASCII, OverwriteCharASCII, OverwriteCharASCII);
                                                break;
                                            case 5:
                                                CurrentPixel = Color.FromArgb(OverwriteCharASCII, OverwriteCharASCII, OverwriteCharASCII, OverwriteCharASCII);
                                                break;
                                        }
                                    }
                                    Console.WriteLine(String.Format("CurrentPixel [{0}, {1}, {2}, {3}]", CurrentPixel.A, CurrentPixel.R, CurrentPixel.G, CurrentPixel.B));
                                    OutputBitmap.SetPixel(w, h, CurrentPixel);
                                    Interface.UpdateProgress("Overwriting EOT chars");
                                    Thread.Sleep(1);
                                    i++;
                                }
                                else
                                {
                                    EndOfText = true;
                                    break;
                                }
                                
                            }
                        }
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine("Error occured during iterating bitmap!");
                    Console.WriteLine(x.StackTrace);
                    Interface.CallErrorMessage(String.Format("Error occured during iterating bitmap: {0}", x.Message));
                    Interface.UpdateProgress("Error!", (Image)OutputBitmap.Clone());
                    Failure = true;
                }
                

                if (!Failure)
                {
                    Interface.UpdateProgress("Ready to save", (Image)OutputBitmap.Clone());
                    ImageFormat BitmapExt = ImageFormat.Bmp;
                    switch(Path.GetExtension(ImageOutputLoc)){
                        case ".jpg":
                            BitmapExt = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            BitmapExt = ImageFormat.Png;
                            break;
                        case ".bmp":
                            BitmapExt = ImageFormat.Bmp;
                            break;
                    }
                    try
                    {
                        if (System.IO.File.Exists(ImageOutputLoc)) {
                            System.IO.File.Delete(ImageOutputLoc);
                            Console.WriteLine("File "+ImageOutputLoc+" has been deleted due to Overwrite needs.");
                        }
                        OutputBitmap.Save(ImageOutputLoc, BitmapExt);
                        Interface.CallErrorMessage(MessageBoxIcon.Asterisk, "Successfully created new bitmap!");
                        Interface.EndingProcedure(OutputBitmap);
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine("Error occured during saving bitmap!");
                        Console.WriteLine(x.Message);
                        Interface.CallErrorMessage(String.Format("Error occured during saving bitmap: {0}", x.Message));
                    }

                }
            });
            OverwriteChannelThread.IsBackground = true;
            OverwriteChannelThread.Start();

        }

        private static int EOTMatch = 0;

        private static Boolean CheckEOT(Char ElementChar)
        {
            if (ElementChar == EOTString[EOTMatch]) EOTMatch++;
            else
            {
                EOTMatch = 0;
                return false;
            }
            if (EOTMatch == EOTString.Length)
            {
                EOTMatch = 0;
                return true;
            }
            else return false;
        }

        public static void ReadTextFromImage(Steganography.Forms.ImageReaderForm Interface)
        {
            
            Interface.SetupProgressBar(InputBitmap.Width * InputBitmap.Height);
            String OutputString = "";
            Char AttachChar = ' ';
            Boolean FoundEOT = false;
            ReadingImageThread = new Thread(delegate()
            {
                
                try
                {
                    for (int w = 0; w < InputBitmap.Width; w++)
                    {
                        if (FoundEOT) break;
                        for (int h = 0; h < InputBitmap.Height; h++)
                        {
                            Color CurrentPixel = InputBitmap.GetPixel(w, h);
                            switch (RGBOverwriteMethod)
                            {
                                // Console.Writeline here is very 
                                case 0:
                                    AttachChar = (char)CurrentPixel.R;
                                    //Console.WriteLine("Read char: " + (char)CurrentPixel.R + ", ASCII: " + CurrentPixel.R);
                                    break;
                                case 1:
                                    AttachChar = (char)CurrentPixel.G;
                                    //Console.WriteLine("Read char: " + (char)CurrentPixel.G + ", ASCII: " + CurrentPixel.G);
                                    break;
                                case 2:
                                    AttachChar = (char)CurrentPixel.B;
                                    //Console.WriteLine("Read char: " + (char)CurrentPixel.B + ", ASCII: " + CurrentPixel.B);
                                    break;
                                // case 3 is obsolete
                                case 3:
                                    AttachChar = (char)CurrentPixel.A;
                                    //Console.WriteLine("Read char: " + (char)CurrentPixel.A + ", ASCII: " + CurrentPixel.A);
                                    break;
                                case 4:
                                    AttachChar = (char)CurrentPixel.R; // it doesnt matter from which channel we read ASCII char in this method (RGB)
                                    //Console.WriteLine("Read char: " + (char)CurrentPixel.A + ", ASCII: " + CurrentPixel.A);
                                    break;
                                case 5:
                                    AttachChar = (char)CurrentPixel.A; // it doesnt matter from which channel we read ASCII char in this method (ARGB)
                                    //Console.WriteLine("Read char: " + (char)CurrentPixel.A + ", ASCII: " + CurrentPixel.A);
                                    break;
                            }

                            OutputString += AttachChar;
                            Interface.UpdateProgress((w * InputBitmap.Height) + h + 1, String.Format("Reading image | {0} px/{1} px", (w * InputBitmap.Height) + h + 1, InputBitmap.Width * InputBitmap.Height));
                            if (UseEOTString)
                                if (CheckEOT(AttachChar))
                                {
                                    Interface.UpdateProgress(InputBitmap.Width * InputBitmap.Height, "Reading image | Found EOT");
                                    FoundEOT = true;
                                    break;
                                }

                            Thread.Sleep(1);
                        }
                    }
                    Interface.EndingProcedure(OutputString);
                }
                catch (Exception x)
                {
                    Interface.CallErrorMessage("Error occured during processing image: " + x.Message);
                    Console.WriteLine(x.StackTrace);
                }
            });
            ReadingImageThread.IsBackground = true;
            ReadingImageThread.Start();
            
        }
    }
}
