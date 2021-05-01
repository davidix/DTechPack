namespace DTechPack
{
    partial class frmASCI
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
            this.btnTXTdec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTXTenc = new System.Windows.Forms.Button();
            this.rbTXT = new System.Windows.Forms.RadioButton();
            this.rbFILE = new System.Windows.Forms.RadioButton();
            this.grptext = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grptext.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTXTdec
            // 
            this.btnTXTdec.Location = new System.Drawing.Point(209, 4);
            this.btnTXTdec.Name = "btnTXTdec";
            this.btnTXTdec.Size = new System.Drawing.Size(60, 50);
            this.btnTXTdec.TabIndex = 15;
            this.btnTXTdec.Text = "Decrypt";
            this.btnTXTdec.UseVisualStyleBackColor = true;
            this.btnTXTdec.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "IV :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SSX",
            "Quat",
            "MX7-SE"});
            this.comboBox2.Location = new System.Drawing.Point(40, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SQX",
            "NTL",
            "4C#"});
            this.comboBox1.Location = new System.Drawing.Point(40, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btnTXTenc
            // 
            this.btnTXTenc.Location = new System.Drawing.Point(143, 4);
            this.btnTXTenc.Name = "btnTXTenc";
            this.btnTXTenc.Size = new System.Drawing.Size(60, 50);
            this.btnTXTenc.TabIndex = 10;
            this.btnTXTenc.Text = "Encrypt";
            this.btnTXTenc.UseVisualStyleBackColor = true;
            this.btnTXTenc.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbTXT
            // 
            this.rbTXT.AutoSize = true;
            this.rbTXT.Location = new System.Drawing.Point(8, 60);
            this.rbTXT.Name = "rbTXT";
            this.rbTXT.Size = new System.Drawing.Size(99, 17);
            this.rbTXT.TabIndex = 17;
            this.rbTXT.TabStop = true;
            this.rbTXT.Text = "Text Encryption";
            this.rbTXT.UseVisualStyleBackColor = true;
            this.rbTXT.CheckedChanged += new System.EventHandler(this.rbTXT_CheckedChanged);
            // 
            // rbFILE
            // 
            this.rbFILE.AutoSize = true;
            this.rbFILE.Location = new System.Drawing.Point(113, 60);
            this.rbFILE.Name = "rbFILE";
            this.rbFILE.Size = new System.Drawing.Size(94, 17);
            this.rbFILE.TabIndex = 18;
            this.rbFILE.TabStop = true;
            this.rbFILE.Text = "File Encryption";
            this.rbFILE.UseVisualStyleBackColor = true;
            this.rbFILE.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // grptext
            // 
            this.grptext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grptext.Controls.Add(this.textBox1);
            this.grptext.Controls.Add(this.richTextBox1);
            this.grptext.Location = new System.Drawing.Point(11, 83);
            this.grptext.Name = "grptext";
            this.grptext.Size = new System.Drawing.Size(254, 243);
            this.grptext.TabIndex = 35;
            this.grptext.TabStop = false;
            this.grptext.Text = "Text Encryption";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(5, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(242, 103);
            this.textBox1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 103);
            this.richTextBox1.TabIndex = 20;
            // 
            // grpFile
            // 
            this.grpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFile.Controls.Add(this.label3);
            this.grpFile.Controls.Add(this.label4);
            this.grpFile.Controls.Add(this.textBox3);
            this.grpFile.Controls.Add(this.textBox2);
            this.grpFile.Location = new System.Drawing.Point(8, 332);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(257, 75);
            this.grpFile.TabIndex = 36;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "File Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "D File :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "S File :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(53, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 36;
            this.textBox3.DoubleClick += new System.EventHandler(this.textBox3_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(53, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 35;
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // frmASCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 419);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.grptext);
            this.Controls.Add(this.rbFILE);
            this.Controls.Add(this.rbTXT);
            this.Controls.Add(this.btnTXTdec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnTXTenc);
            this.Name = "frmASCI";
            this.Text = "frmASCI";
            this.Load += new System.EventHandler(this.frmASCI_Load);
            this.grptext.ResumeLayout(false);
            this.grptext.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTXTdec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTXTenc;
        private System.Windows.Forms.RadioButton rbTXT;
        private System.Windows.Forms.RadioButton rbFILE;
        private System.Windows.Forms.GroupBox grptext;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}