using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Forms
{
    public partial class ImageReaderForm : Form
    {
        public ImageReaderForm()
        {
            InitializeComponent();
        }

        private void ImageReaderForm_Load(object sender, EventArgs e)
        {

        }

        private void ImageReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                if (SteganoEngine.LoadBitmap())
                {
                    this.ReadableImageInput.Image = SteganoEngine.InputBitmap;
                }
                else
                {
                    MessageBox.Show("Input image is incorrect!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void SetupProgressBar(int Maximum)
        {
            this.progressBar1.Maximum = Maximum;
        }

        public void UpdateProgress(int CurrentProgress, String Status)
        {
            this.progressBar1.Invoke(new MethodInvoker(delegate { this.progressBar1.Value = CurrentProgress; }));
            this.labelStatus.Invoke(new MethodInvoker(delegate { labelStatus.Text = Status; }));
        }

        public void CallErrorMessage(String message)
        {
            MessageBox.Show(message, "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CallErrorMessage(MessageBoxIcon x, String message)
        {
            MessageBox.Show(message, "I hate titles", MessageBoxButtons.OK, x);
        }


        public void EndingProcedure(String Output)
        {
            Steganography.Forms.ReadedImageViewer RIV = new Steganography.Forms.ReadedImageViewer();
            RIV.SetReadImage(Output);
            RIV.ShowDialog();
            //this.Invoke(new MethodInvoker(delegate { this.Hide(); }));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SteganoEngine.InputBitmap == null)
            {
                MessageBox.Show("You need to load input image first!", "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                SteganoEngine.ReadTextFromImage(this);
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

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
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
      
    }
}
