using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            buttonSelectTextFile.Enabled = true;
            buttonTypeCustomText.Enabled = false;
            SteganoEngine.SetTextSource(0);
        }

        private void buttonSetInputLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog InputLocDialog = new OpenFileDialog();
            InputLocDialog.Filter = "Image Files (*.png, *.jpg, *.bmp) |*.png;*.jpg;*.bmp|All files (*.*)|*.*";
            InputLocDialog.Title = "Choose existing Image input file";
            InputLocDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (InputLocDialog.ShowDialog() == DialogResult.OK)
            {
                SteganoEngine.SetImageInputLoc(InputLocDialog.FileName.ToString());
                this.textboxImageInput.Text = InputLocDialog.FileName.ToString();
            }

        }

        private void buttonSetOutputLoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog OutputLocDialog = new SaveFileDialog();
            OutputLocDialog.Filter = "PNG Image (*.png) |*.png|Bitmap (*.bmp) |*.bmp|All files (*.*) |*.*";
            OutputLocDialog.Title = "Set processed image location";
            OutputLocDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (OutputLocDialog.ShowDialog() == DialogResult.OK)
            {
                SteganoEngine.SetImageOutputLoc(OutputLocDialog.FileName.ToString());
                this.textboxImageOutput.Text = OutputLocDialog.FileName.ToString();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            buttonTypeCustomText.Enabled = true;
            buttonSelectTextFile.Enabled = false;
            SteganoEngine.SetTextSource(1);
        }

        private void buttonSelectTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog TextFileLocDialog = new OpenFileDialog();
            TextFileLocDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*) |*.*";
            TextFileLocDialog.Title = "Choose existing text file";
            TextFileLocDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (TextFileLocDialog.ShowDialog() == DialogResult.OK)
                SteganoEngine.SetTextFileLoc(TextFileLocDialog.FileName.ToString());
        }

        private void buttonTypeCustomText_Click(object sender, EventArgs e)
        {
            Steganography.Forms.TextTyper CustomTextWindow = new Steganography.Forms.TextTyper();
            if (SteganoEngine.CustomText != null) CustomTextWindow.SetCustomTextBox();
            CustomTextWindow.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SteganoEngine.SetRGBOverwriteMethod(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SteganoEngine.SetRGBOverwriteMethod(1);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SteganoEngine.SetRGBOverwriteMethod(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SteganoEngine.SetRGBOverwriteMethod(3);
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SteganoEngine.SetRGBOverwriteMethod(4);
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SteganoEngine.SetRGBOverwriteMethod(5);
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (SteganoEngine.ImageInputLoc == null)
                MessageBox.Show("Input image location not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!SteganoEngine.LoadBitmap())
                {
                    MessageBox.Show("Input image is incorrect!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.labelImageWidth.Text = "?";
                    this.labelImageHeight.Text = "?";
                    this.labelMaxChars.Text = "?";
                }
                else
                {
                    MessageBox.Show("Image successfully loaded!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.labelImageWidth.Text = SteganoEngine.InputBitmap.Width.ToString();
                    this.labelImageHeight.Text = SteganoEngine.InputBitmap.Height.ToString();
                    this.labelMaxChars.Text = (SteganoEngine.InputBitmap.Height * SteganoEngine.InputBitmap.Width).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SteganoEngine.ImageInputLoc == null)
                MessageBox.Show("Input image location not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (SteganoEngine.ImageOutputLoc == null)
                MessageBox.Show("Output image location not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (SteganoEngine.RGBOverwriteMethod == -1)
                MessageBox.Show("RGB Channel Overwrite not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (SteganoEngine.TextSource == -1)
                MessageBox.Show("Text source not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (SteganoEngine.TextSource == 0 && SteganoEngine.TextFileLoc == null)
                MessageBox.Show("Text file source set, but file is not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (SteganoEngine.TextSource == 1 && (SteganoEngine.CustomText == null || SteganoEngine.CustomText.Length == 0))
                MessageBox.Show("Custom text source set, but text is not set!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!SteganoEngine.LoadBitmap())
                    MessageBox.Show("Input image is incorrect!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Steganography.Forms.ProcessForm ProcessForm = new Steganography.Forms.ProcessForm();
                    ProcessForm.LoadInputImage();
                    this.Hide();
                    ProcessForm.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SteganoEngine.ResetVariables();
            this.Hide();
            Steganography.Forms.ImageReaderForm IRF = new Steganography.Forms.ImageReaderForm();
            IRF.Show();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {

        }

       

       

        

        

      
    }
}
