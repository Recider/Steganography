using System;
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
        
        // RGBOverrdieMethod - which channel will be overrided
        // -1 - Unset
        // 0 - R
        // 1 - G
        // 2 - B
        // 3 - Alpha
        public static int RGBOverrideMethod = -1;

        public static String ImageInputLoc;
        public static String ImageOutputLoc;
        public static String TextFileLoc;
        public static String CustomText;

        public static Bitmap InputBitmap;
        public static Bitmap OutputBitmap;

        public SteganoEngine() { }

        public static void SetTextSource(int set)
        {
            TextSource = set;
            System.Console.WriteLine("Set TextSource: "+TextSource);
        }

        public static void SetRGBOverrideMethod(int set)
        {
            RGBOverrideMethod = set;
            System.Console.WriteLine("Set RGBOverrideMethod: " + RGBOverrideMethod);
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

        private static void ResetVariables()
        {
            ImageInputLoc = null;
            ImageOutputLoc = null;
            TextFileLoc = null;
            CustomText = null;
            RGBOverrideMethod = -1;
            TextSource = -1;
            InputBitmap = null;
            OutputBitmap = null;
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

        public static void OverrideColorChannel(Steganography.Forms.ProcessForm Interface){
            

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
            new Thread(delegate()
            {
                Boolean Failure = false;
                Boolean EndOfText = false;
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
                                int OverrideCharASCII = (int)CustomText[(w * (InputBitmap.Height - 1)) + h];
                                Console.WriteLine(String.Format("Overriding letter {0}, ASCII: {1}", CustomText[(w * (InputBitmap.Height - 1)) + h], (int)CustomText[(w * (InputBitmap.Height - 1)) + h]));
                                switch (RGBOverrideMethod)
                                {
                                    case 0:
                                        CurrentPixel = Color.FromArgb(OverrideCharASCII, CurrentPixel.G, CurrentPixel.B);
                                        break;
                                    case 1:
                                        CurrentPixel = Color.FromArgb(CurrentPixel.R, OverrideCharASCII, CurrentPixel.B);
                                        break;
                                    case 2:
                                        CurrentPixel = Color.FromArgb(CurrentPixel.R, CurrentPixel.G, OverrideCharASCII);
                                        break;
                                    case 3:
                                        CurrentPixel = Color.FromArgb(OverrideCharASCII, CurrentPixel.R, CurrentPixel.G, CurrentPixel.B);

                                        break;
                                }

                                OutputBitmap.SetPixel(w, h, CurrentPixel);
                                Interface.UpdateProgress((w * (InputBitmap.Height - 1)) + h + 1, "Creating new bitmap...", (Image)OutputBitmap.Clone());
                                Thread.Sleep(1);
                            }
                            else
                            {
                                EndOfText = true;
                                break;
                            }
                        }
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine("Error occured during iterating bitmap!");
                    Console.WriteLine(x.StackTrace);
                    Interface.CallErrorMessage(String.Format("Error occured during iterating bitmap: {0}", x.Message));
                    Interface.UpdateProgress("Error!", OutputBitmap);
                    Failure = true;
                }
                

                if (!Failure)
                {
                    Interface.UpdateProgress("Ready to save", (Image)InputBitmap.Clone());
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
                        OutputBitmap.Save(ImageOutputLoc, BitmapExt);
                        //InputBitmap.Save(ImageOutputLoc, BitmapExt);
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
            }).Start();

        }

    }
}
