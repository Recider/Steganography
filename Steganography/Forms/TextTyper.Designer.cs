namespace Steganography.Forms
{
    partial class TextTyper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextTyper));
            this.CustomTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCharCounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomTextBox
            // 
            this.CustomTextBox.Location = new System.Drawing.Point(12, 12);
            this.CustomTextBox.Name = "CustomTextBox";
            this.CustomTextBox.Size = new System.Drawing.Size(542, 220);
            this.CustomTextBox.TabIndex = 0;
            this.CustomTextBox.Text = "";
            this.CustomTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ch:";
            // 
            // labelCharCounter
            // 
            this.labelCharCounter.AutoSize = true;
            this.labelCharCounter.Location = new System.Drawing.Point(42, 239);
            this.labelCharCounter.Name = "labelCharCounter";
            this.labelCharCounter.Size = new System.Drawing.Size(13, 13);
            this.labelCharCounter.TabIndex = 2;
            this.labelCharCounter.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Apply and close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextTyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCharCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TextTyper";
            this.Text = "TextTyper";
            this.Load += new System.EventHandler(this.TextTyper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CustomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCharCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}