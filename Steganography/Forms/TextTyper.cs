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
    public partial class TextTyper : Form
    {
        public TextTyper()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.labelCharCounter.Text = this.CustomTextBox.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SteganoEngine.SetCustomText(this.CustomTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SteganoEngine.SetCustomText(this.CustomTextBox.Text);
            this.Close();
        }

        private void TextTyper_Load(object sender, EventArgs e)
        {

        }

        public void SetCustomTextBox(){
            this.CustomTextBox.Text = SteganoEngine.CustomText;
            this.labelCharCounter.Text = this.CustomTextBox.Text.Length.ToString();
        }
    }
}
