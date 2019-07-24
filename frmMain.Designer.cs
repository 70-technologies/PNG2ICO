namespace PNG2ICO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtInput = new System.Windows.Forms.TextBox();
            this.comboSizes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkAllSizes = new System.Windows.Forms.CheckBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.radioNewFile = new System.Windows.Forms.RadioButton();
            this.radioAIO = new System.Windows.Forms.RadioButton();
            this.checkAspectRatio = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(430, 74);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 30);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "BROWSE";
            this.toolTip.SetToolTip(this.btnBrowse, "Browse for the output file");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(87, 78);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(319, 22);
            this.txtOutput.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtOutput, "Choose the output file for icon");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.facebookToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input:";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(430, 31);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(86, 30);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "BROWSE";
            this.toolTip.SetToolTip(this.btnInput, "Select input image");
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.toolTip.SetToolTip(this.btnSave, "Create an ICON from selected images");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(543, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lblStatus.Size = new System.Drawing.Size(528, 20);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Status: Ready.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(275, 124);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(87, 35);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(319, 22);
            this.txtInput.TabIndex = 2;
            // 
            // comboSizes
            // 
            this.comboSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSizes.FormattingEnabled = true;
            this.comboSizes.Items.AddRange(new object[] {
            "16",
            "20",
            "24",
            "32",
            "48",
            "64",
            "128",
            "256"});
            this.comboSizes.Location = new System.Drawing.Point(87, 124);
            this.comboSizes.Name = "comboSizes";
            this.comboSizes.Size = new System.Drawing.Size(182, 24);
            this.comboSizes.TabIndex = 7;
            this.comboSizes.SelectedIndexChanged += new System.EventHandler(this.comboSizes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Icon Size:";
            // 
            // checkAllSizes
            // 
            this.checkAllSizes.AutoSize = true;
            this.checkAllSizes.Location = new System.Drawing.Point(87, 154);
            this.checkAllSizes.Name = "checkAllSizes";
            this.checkAllSizes.Size = new System.Drawing.Size(131, 21);
            this.checkAllSizes.TabIndex = 9;
            this.checkAllSizes.Text = "Save in all sizes";
            this.checkAllSizes.UseVisualStyleBackColor = true;
            this.checkAllSizes.CheckedChanged += new System.EventHandler(this.checkOutputAll_CheckedChanged);
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.radioNewFile);
            this.groupOutput.Controls.Add(this.radioAIO);
            this.groupOutput.Enabled = false;
            this.groupOutput.Location = new System.Drawing.Point(87, 181);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(182, 91);
            this.groupOutput.TabIndex = 10;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "OUTPUT";
            // 
            // radioNewFile
            // 
            this.radioNewFile.AutoSize = true;
            this.radioNewFile.Checked = true;
            this.radioNewFile.Location = new System.Drawing.Point(17, 55);
            this.radioNewFile.Name = "radioNewFile";
            this.radioNewFile.Size = new System.Drawing.Size(153, 21);
            this.radioNewFile.TabIndex = 11;
            this.radioNewFile.TabStop = true;
            this.radioNewFile.Text = "New file for all sizes";
            this.radioNewFile.UseVisualStyleBackColor = true;
            // 
            // radioAIO
            // 
            this.radioAIO.AutoSize = true;
            this.radioAIO.Location = new System.Drawing.Point(17, 28);
            this.radioAIO.Name = "radioAIO";
            this.radioAIO.Size = new System.Drawing.Size(145, 21);
            this.radioAIO.TabIndex = 11;
            this.radioAIO.Text = "All sizes in one file";
            this.radioAIO.UseVisualStyleBackColor = true;
            // 
            // checkAspectRatio
            // 
            this.checkAspectRatio.AutoSize = true;
            this.checkAspectRatio.Location = new System.Drawing.Point(87, 278);
            this.checkAspectRatio.Name = "checkAspectRatio";
            this.checkAspectRatio.Size = new System.Drawing.Size(147, 21);
            this.checkAspectRatio.TabIndex = 11;
            this.checkAspectRatio.Text = "Keep Aspect Ratio";
            this.checkAspectRatio.UseVisualStyleBackColor = true;
            this.checkAspectRatio.Visible = false;
            this.checkAspectRatio.CheckedChanged += new System.EventHandler(this.checkAspectRatio_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 449);
            this.ControlBox = false;
            this.Controls.Add(this.checkAspectRatio);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.checkAllSizes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSizes);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG2ICO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox comboSizes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkAllSizes;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.RadioButton radioNewFile;
        private System.Windows.Forms.RadioButton radioAIO;
        private System.Windows.Forms.CheckBox checkAspectRatio;
    }
}

