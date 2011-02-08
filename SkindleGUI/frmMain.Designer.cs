namespace SkindleGUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseInputFolder = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.chkDump = new System.Windows.Forms.CheckBox();
            this.chkDecompress = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseInfo = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkUseInternet = new System.Windows.Forms.CheckBox();
            this.tabContainer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Location = new System.Drawing.Point(16, 53);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(527, 546);
            this.tabContainer.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtResults);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lstBooks);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnBrowseOut);
            this.tabPage2.Controls.Add(this.txtOutput);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.picCover);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(20, 287);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(479, 39);
            this.btnConvert.TabIndex = 24;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Program Output:";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(20, 361);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(479, 142);
            this.txtResults.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Your Kindle for PC Books:";
            // 
            // lstBooks
            // 
            this.lstBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(20, 39);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.ScrollAlwaysVisible = true;
            this.lstBooks.Size = new System.Drawing.Size(323, 199);
            this.lstBooks.TabIndex = 20;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Selected Book:";
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOut.Location = new System.Drawing.Point(424, 254);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOut.TabIndex = 17;
            this.btnBrowseOut.Text = "Browse...";
            this.btnBrowseOut.UseVisualStyleBackColor = true;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(164, 256);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(254, 20);
            this.txtOutput.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Place to save decrypted file:";
            // 
            // picCover
            // 
            this.picCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCover.Location = new System.Drawing.Point(349, 39);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(150, 200);
            this.picCover.TabIndex = 18;
            this.picCover.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkUseInternet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBrowseInputFolder);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPID);
            this.tabPage1.Controls.Add(this.chkDump);
            this.tabPage1.Controls.Add(this.chkDecompress);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnBrowseInfo);
            this.tabPage1.Controls.Add(this.txtInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Optional Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kindle Books Location:";
            // 
            // btnBrowseInputFolder
            // 
            this.btnBrowseInputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInputFolder.Location = new System.Drawing.Point(444, 12);
            this.btnBrowseInputFolder.Name = "btnBrowseInputFolder";
            this.btnBrowseInputFolder.Size = new System.Drawing.Size(69, 23);
            this.btnBrowseInputFolder.TabIndex = 18;
            this.btnBrowseInputFolder.Text = "Browse...";
            this.btnBrowseInputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseInputFolder.Click += new System.EventHandler(this.btnBrowseInputFolder_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(128, 15);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(310, 20);
            this.txtInput.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Additional PID values:";
            // 
            // txtPID
            // 
            this.txtPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPID.Location = new System.Drawing.Point(128, 71);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(310, 20);
            this.txtPID.TabIndex = 15;
            // 
            // chkDump
            // 
            this.chkDump.AutoSize = true;
            this.chkDump.Location = new System.Drawing.Point(9, 122);
            this.chkDump.Name = "chkDump";
            this.chkDump.Size = new System.Drawing.Size(150, 17);
            this.chkDump.TabIndex = 14;
            this.chkDump.Text = "Dump kindle.info Contents";
            this.chkDump.UseVisualStyleBackColor = true;
            // 
            // chkDecompress
            // 
            this.chkDecompress.AutoSize = true;
            this.chkDecompress.Location = new System.Drawing.Point(9, 99);
            this.chkDecompress.Name = "chkDecompress";
            this.chkDecompress.Size = new System.Drawing.Size(243, 17);
            this.chkDecompress.TabIndex = 13;
            this.chkDecompress.Text = "Decompressed output file (for Topaz files only)";
            this.chkDecompress.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kindle.info:";
            // 
            // btnBrowseInfo
            // 
            this.btnBrowseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInfo.Location = new System.Drawing.Point(444, 41);
            this.btnBrowseInfo.Name = "btnBrowseInfo";
            this.btnBrowseInfo.Size = new System.Drawing.Size(69, 23);
            this.btnBrowseInfo.TabIndex = 11;
            this.btnBrowseInfo.Text = "Browse...";
            this.btnBrowseInfo.UseVisualStyleBackColor = true;
            this.btnBrowseInfo.Click += new System.EventHandler(this.btnBrowseInfo_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(128, 45);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(310, 20);
            this.txtInfo.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(534, 41);
            this.label8.TabIndex = 15;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // chkUseInternet
            // 
            this.chkUseInternet.AutoSize = true;
            this.chkUseInternet.Checked = true;
            this.chkUseInternet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseInternet.Location = new System.Drawing.Point(9, 145);
            this.chkUseInternet.Name = "chkUseInternet";
            this.chkUseInternet.Size = new System.Drawing.Size(254, 17);
            this.chkUseInternet.TabIndex = 20;
            this.chkUseInternet.Text = "Use Internet to download book covers if needed";
            this.chkUseInternet.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 611);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Skindle GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tabContainer.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseOut;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseInputFolder;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.CheckBox chkDump;
        private System.Windows.Forms.CheckBox chkDecompress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkUseInternet;

    }
}

