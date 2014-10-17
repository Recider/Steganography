using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Forms
{
    public partial class ImageOverwriterForm : Form
    {

        public ImageOverwriterForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadInputImage()
        {
            this.InputBitmap.Image = SteganoEngine.InputBitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            SteganoEngine.OverwriteColorChannel(this);
        }

        public void SetupProgressBar(int Maximum)
        {
            this.progressBar1.Invoke(new MethodInvoker(delegate { this.progressBar1.Value = 0; }));
            this.progressBar1.Invoke(new MethodInvoker(delegate { this.progressBar1.Maximum = Maximum; }));
        }

        public void CallErrorMessage(String message)
        {
            MessageBox.Show(message, "I hate titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CallErrorMessage(MessageBoxIcon x, String message)
        {
            MessageBox.Show(message, "I hate titles", MessageBoxButtons.OK, x);
        }

        public void UpdateProgress(String Status)
        {
            this.labelStatus.Invoke(new MethodInvoker(delegate { labelStatus.Text = Status; }));
        }

        public void UpdateProgress(int CurrentProgress, String Status, Image Output)
        {

            this.progressBar1.Invoke(new MethodInvoker(delegate { this.progressBar1.Value = CurrentProgress; }));
            this.labelStatus.Invoke(new MethodInvoker(delegate { labelStatus.Text = Status; }));
            this.InputBitmap.Invoke(new MethodInvoker(delegate { this.OutputBitmap.Image = Output; }));

        }
        public void UpdateProgress(String Status, Image Output)
        {
            this.labelStatus.Invoke(new MethodInvoker(delegate { labelStatus.Text = Status; }));
            this.InputBitmap.Invoke(new MethodInvoker(delegate { this.OutputBitmap.Image = Output; }));
        }

        public void EndingProcedure(Image Output)
        {
            this.button1.Invoke(new MethodInvoker(delegate { this.button1.Enabled = true; }));
            this.InputBitmap.Invoke(new MethodInvoker(delegate { this.OutputBitmap.Image = Output; }));
            this.buttonBackToMenu.Invoke(new MethodInvoker(delegate { this.buttonBackToMenu.Enabled = true; }));
        }

        private void ProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(SteganoEngine.ImageOutputLoc);
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Steganography.StartingForm SF = new Steganography.StartingForm();
            SF.Show();
        }
    }
}
