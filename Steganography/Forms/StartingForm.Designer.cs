namespace Steganography
{
    partial class StartingForm
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
            this.buttonSetInputLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxImageInput = new System.Windows.Forms.TextBox();
            this.textboxImageOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetOutputLoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonTypeCustomText = new System.Windows.Forms.Button();
            this.buttonSelectTextFile = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaxChars = new System.Windows.Forms.Label();
            this.labelImageHeight = new System.Windows.Forms.Label();
            this.labelImageWidth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetInputLoc
            // 
            this.buttonSetInputLoc.Location = new System.Drawing.Point(394, 4);
            this.buttonSetInputLoc.Name = "buttonSetInputLoc";
            this.buttonSetInputLoc.Size = new System.Drawing.Size(75, 23);
            this.buttonSetInputLoc.TabIndex = 0;
            this.buttonSetInputLoc.Text = "Select...";
            this.buttonSetInputLoc.UseVisualStyleBackColor = true;
            this.buttonSetInputLoc.Click += new System.EventHandler(this.buttonSetInputLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source image location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxImageInput
            // 
            this.textboxImageInput.Location = new System.Drawing.Point(133, 6);
            this.textboxImageInput.Name = "textboxImageInput";
            this.textboxImageInput.ReadOnly = true;
            this.textboxImageInput.Size = new System.Drawing.Size(255, 20);
            this.textboxImageInput.TabIndex = 2;
            // 
            // textboxImageOutput
            // 
            this.textboxImageOutput.Location = new System.Drawing.Point(133, 32);
            this.textboxImageOutput.Name = "textboxImageOutput";
            this.textboxImageOutput.ReadOnly = true;
            this.textboxImageOutput.Size = new System.Drawing.Size(255, 20);
            this.textboxImageOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output image location:";
            // 
            // buttonSetOutputLoc
            // 
            this.buttonSetOutputLoc.Location = new System.Drawing.Point(394, 30);
            this.buttonSetOutputLoc.Name = "buttonSetOutputLoc";
            this.buttonSetOutputLoc.Size = new System.Drawing.Size(75, 23);
            this.buttonSetOutputLoc.TabIndex = 3;
            this.buttonSetOutputLoc.Text = "Select...";
            this.buttonSetOutputLoc.UseVisualStyleBackColor = true;
            this.buttonSetOutputLoc.Click += new System.EventHandler(this.buttonSetOutputLoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.buttonTypeCustomText);
            this.groupBox1.Controls.Add(this.buttonSelectTextFile);
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hidden text source";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(13, 52);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(80, 17);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Custom text";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "From text file";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // buttonTypeCustomText
            // 
            this.buttonTypeCustomText.Enabled = false;
            this.buttonTypeCustomText.Location = new System.Drawing.Point(106, 49);
            this.buttonTypeCustomText.Name = "buttonTypeCustomText";
            this.buttonTypeCustomText.Size = new System.Drawing.Size(75, 23);
            this.buttonTypeCustomText.TabIndex = 8;
            this.buttonTypeCustomText.Text = "Set text...";
            this.buttonTypeCustomText.UseVisualStyleBackColor = true;
            this.buttonTypeCustomText.Click += new System.EventHandler(this.buttonTypeCustomText_Click);
            // 
            // buttonSelectTextFile
            // 
            this.buttonSelectTextFile.Enabled = false;
            this.buttonSelectTextFile.Location = new System.Drawing.Point(106, 20);
            this.buttonSelectTextFile.Name = "buttonSelectTextFile";
            this.buttonSelectTextFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectTextFile.TabIndex = 7;
            this.buttonSelectTextFile.Text = "Select...";
            this.buttonSelectTextFile.UseVisualStyleBackColor = true;
            this.buttonSelectTextFile.Click += new System.EventHandler(this.buttonSelectTextFile_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(202, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Alpha";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(133, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "GREEN";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(133, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RED";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RGBA Channel override:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelImageWidth);
            this.groupBox2.Controls.Add(this.labelImageHeight);
            this.groupBox2.Controls.Add(this.labelMaxChars);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(330, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 151);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input image properties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Image char capacity:";
            // 
            // labelMaxChars
            // 
            this.labelMaxChars.AutoSize = true;
            this.labelMaxChars.Location = new System.Drawing.Point(6, 90);
            this.labelMaxChars.Name = "labelMaxChars";
            this.labelMaxChars.Size = new System.Drawing.Size(13, 13);
            this.labelMaxChars.TabIndex = 14;
            this.labelMaxChars.Text = "?";
            // 
            // labelImageHeight
            // 
            this.labelImageHeight.AutoSize = true;
            this.labelImageHeight.Location = new System.Drawing.Point(50, 48);
            this.labelImageHeight.Name = "labelImageHeight";
            this.labelImageHeight.Size = new System.Drawing.Size(13, 13);
            this.labelImageHeight.TabIndex = 15;
            this.labelImageHeight.Text = "?";
            // 
            // labelImageWidth
            // 
            this.labelImageWidth.AutoSize = true;
            this.labelImageWidth.Location = new System.Drawing.Point(50, 23);
            this.labelImageWidth.Name = "labelImageWidth";
            this.labelImageWidth.Size = new System.Drawing.Size(13, 13);
            this.labelImageWidth.TabIndex = 16;
            this.labelImageWidth.Text = "?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(236, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Check input image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(365, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Steganography";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(15, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 61);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Channels";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(202, 15);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(53, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "BLUE";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 257);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textboxImageOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSetOutputLoc);
            this.Controls.Add(this.textboxImageInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetInputLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartingForm";
            this.Text = "Steganography";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetInputLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxImageInput;
        private System.Windows.Forms.TextBox textboxImageOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetOutputLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTypeCustomText;
        private System.Windows.Forms.Button buttonSelectTextFile;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;

        private void enableSelectTextFileButton()
        {
            buttonSelectTextFile.Enabled = true;
            buttonTypeCustomText.Enabled = false;
        }

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelImageWidth;
        private System.Windows.Forms.Label labelImageHeight;
        private System.Windows.Forms.Label labelMaxChars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}

