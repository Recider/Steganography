namespace Steganography.Forms
{
    partial class ImageReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageReaderForm));
            this.ChannelsGroup = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxImageInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetInputLoc = new System.Windows.Forms.Button();
            this.ReadableImageInput = new System.Windows.Forms.PictureBox();
            this.readImageButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.ReadingOptionsGroup = new System.Windows.Forms.GroupBox();
            this.textEOTString = new System.Windows.Forms.TextBox();
            this.searchForEOTCheckbox = new System.Windows.Forms.CheckBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ChannelsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadableImageInput)).BeginInit();
            this.ReadingOptionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChannelsGroup
            // 
            this.ChannelsGroup.Controls.Add(this.radioButton8);
            this.ChannelsGroup.Controls.Add(this.radioButton7);
            this.ChannelsGroup.Controls.Add(this.radioButton3);
            this.ChannelsGroup.Controls.Add(this.radioButton6);
            this.ChannelsGroup.Controls.Add(this.radioButton2);
            this.ChannelsGroup.Controls.Add(this.radioButton1);
            this.ChannelsGroup.Controls.Add(this.label3);
            this.ChannelsGroup.Location = new System.Drawing.Point(15, 32);
            this.ChannelsGroup.Name = "ChannelsGroup";
            this.ChannelsGroup.Size = new System.Drawing.Size(390, 61);
            this.ChannelsGroup.TabIndex = 12;
            this.ChannelsGroup.TabStop = false;
            this.ChannelsGroup.Text = "Channels";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(239, 38);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(55, 17);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "ARGB";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(170, 38);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "RGB";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Alpha";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(239, 17);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(53, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "BLUE";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(170, 17);
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
            this.radioButton1.Location = new System.Drawing.Point(116, 17);
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
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RGB Channel read:";
            // 
            // textboxImageInput
            // 
            this.textboxImageInput.Location = new System.Drawing.Point(133, 6);
            this.textboxImageInput.Name = "textboxImageInput";
            this.textboxImageInput.ReadOnly = true;
            this.textboxImageInput.Size = new System.Drawing.Size(191, 20);
            this.textboxImageInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source image location:";
            // 
            // buttonSetInputLoc
            // 
            this.buttonSetInputLoc.Location = new System.Drawing.Point(330, 4);
            this.buttonSetInputLoc.Name = "buttonSetInputLoc";
            this.buttonSetInputLoc.Size = new System.Drawing.Size(75, 23);
            this.buttonSetInputLoc.TabIndex = 5;
            this.buttonSetInputLoc.Text = "Select...";
            this.buttonSetInputLoc.UseVisualStyleBackColor = true;
            this.buttonSetInputLoc.Click += new System.EventHandler(this.buttonSetInputLoc_Click);
            // 
            // ReadableImageInput
            // 
            this.ReadableImageInput.Location = new System.Drawing.Point(411, 4);
            this.ReadableImageInput.Name = "ReadableImageInput";
            this.ReadableImageInput.Size = new System.Drawing.Size(266, 226);
            this.ReadableImageInput.TabIndex = 13;
            this.ReadableImageInput.TabStop = false;
            // 
            // readImageButton
            // 
            this.readImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readImageButton.Location = new System.Drawing.Point(15, 170);
            this.readImageButton.Name = "readImageButton";
            this.readImageButton.Size = new System.Drawing.Size(93, 23);
            this.readImageButton.TabIndex = 14;
            this.readImageButton.Text = "Read image";
            this.readImageButton.UseVisualStyleBackColor = true;
            this.readImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 207);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 23);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(176, 175);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(116, 13);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Waiting for user input...";
            // 
            // ReadingOptionsGroup
            // 
            this.ReadingOptionsGroup.Controls.Add(this.textEOTString);
            this.ReadingOptionsGroup.Controls.Add(this.searchForEOTCheckbox);
            this.ReadingOptionsGroup.Controls.Add(this.radioButton5);
            this.ReadingOptionsGroup.Controls.Add(this.radioButton4);
            this.ReadingOptionsGroup.Location = new System.Drawing.Point(15, 99);
            this.ReadingOptionsGroup.Name = "ReadingOptionsGroup";
            this.ReadingOptionsGroup.Size = new System.Drawing.Size(388, 65);
            this.ReadingOptionsGroup.TabIndex = 18;
            this.ReadingOptionsGroup.TabStop = false;
            this.ReadingOptionsGroup.Text = "Reading options";
            // 
            // textEOTString
            // 
            this.textEOTString.Enabled = false;
            this.textEOTString.Location = new System.Drawing.Point(222, 16);
            this.textEOTString.Name = "textEOTString";
            this.textEOTString.Size = new System.Drawing.Size(100, 20);
            this.textEOTString.TabIndex = 3;
            this.textEOTString.TextChanged += new System.EventHandler(this.textEOTString_TextChanged);
            // 
            // searchForEOTCheckbox
            // 
            this.searchForEOTCheckbox.AutoSize = true;
            this.searchForEOTCheckbox.Location = new System.Drawing.Point(116, 19);
            this.searchForEOTCheckbox.Name = "searchForEOTCheckbox";
            this.searchForEOTCheckbox.Size = new System.Drawing.Size(100, 17);
            this.searchForEOTCheckbox.TabIndex = 2;
            this.searchForEOTCheckbox.Text = "Search for EOT";
            this.searchForEOTCheckbox.UseVisualStyleBackColor = true;
            this.searchForEOTCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(16, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Horizontal";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Vertical";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // ImageReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 236);
            this.Controls.Add(this.ReadingOptionsGroup);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.readImageButton);
            this.Controls.Add(this.ReadableImageInput);
            this.Controls.Add(this.textboxImageInput);
            this.Controls.Add(this.ChannelsGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetInputLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImageReaderForm";
            this.Text = "Image Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageReaderForm_FormClosed);
            this.Load += new System.EventHandler(this.ImageReaderForm_Load);
            this.ChannelsGroup.ResumeLayout(false);
            this.ChannelsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadableImageInput)).EndInit();
            this.ReadingOptionsGroup.ResumeLayout(false);
            this.ReadingOptionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ChannelsGroup;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxImageInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetInputLoc;
        private System.Windows.Forms.PictureBox ReadableImageInput;
        private System.Windows.Forms.Button readImageButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox ReadingOptionsGroup;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.TextBox textEOTString;
        private System.Windows.Forms.CheckBox searchForEOTCheckbox;
    }
}