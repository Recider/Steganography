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
    public partial class ReadedImageViewer : Form
    {
        public ReadedImageViewer()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetReadImage(String text)
        {
            this.richTextBox1.Text = text;
        }

        private void ReadedImageViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void ReadedImageViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
