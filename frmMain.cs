/// File: frmMain.cs
/// Purpose: Defines functions and events for the MAIN user interface of the program. 
/// Version: 1.0(beta)
/// Date: March 6, 2019

/* 
Copyright (c) 2019, All rights are reserved by AB, The Tech Developers, PK.
https://www.TheTechDevelopers.cf

This program is licensed under the Apache License, Version 2.0 (the "License");
you may not download, install or use this program except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PNG2ICO
{
    public partial class frmMain : Form
    {
        //Used to access this form statically. 
        public static frmMain INSTANCE;
        //Stores possible sizes of icons
        public Size[] ImageSizes = new Size[8] 
        {
            new Size(16, 16),
            new Size(20, 20),
            new Size(24, 24),
            new Size(32, 32),
            new Size(48, 48),
            new Size(64, 64),
            new Size(128, 128),
            new Size(256, 256),
        };
        public frmMain()
        {
            InitializeComponent();
            comboSizes.SelectedIndex = 0;
            INSTANCE = this;
        }
        #region Events
        /// <summary>
        /// Occures when any button on form is clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                default:
                    break;
                case nameof(btnInput):
                    AddImage();
                    break;
                case nameof(btnBrowse):
                    Browse();
                    break;
                case nameof(btnSave):
                    Save();
                    break;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }
        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.TheTechDevelopers.cf");
        }
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/TecDevsIT");
        }
        private void comboSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || !(File.Exists(txtInput.Text)))
                return;
            LoadImage(Png2Ico.Resize(Image.FromFile(txtInput.Text), ImageSizes[comboSizes.SelectedIndex]));
        }
        private void checkOutputAll_CheckedChanged(object sender, EventArgs e)
        {
            comboSizes.Enabled = !checkAllSizes.Checked;
            groupOutput.Enabled = checkAllSizes.Checked;
        }
        private void checkAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtInput.Text))
                LoadImage(Image.FromFile(txtInput.Text).Resize(ImageSizes[comboSizes.SelectedIndex], checkAspectRatio.Checked));
        }
        #endregion
        #region Functions
        /// <summary>
        /// Enables or disables all the controls of form.
        /// </summary>
        /// <param name="flag"></param>
        private void SetControls(bool flag)
        {
            btnInput.Enabled = flag;
            btnBrowse.Enabled = flag;
            txtInput.Enabled = flag;
            btnInput.Enabled = flag;
            btnSave.Enabled = flag;
            txtOutput.Enabled = flag;
            groupOutput.Enabled = flag;
            checkAllSizes.Enabled = flag;
            checkAspectRatio.Enabled = flag;
        }
        /// <summary>
        /// Sets the text of status label. 
        /// </summary>
        /// <param name="sts"></param>
        public void SetStatus(string sts)
        {
            lblStatus.Text = "STATUS: "+sts;
        }
        /// <summary>
        /// Shows the save as dialog for output icon. 
        /// </summary>
        private void Browse()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "PNG2ICO - Save As";
                sfd.Filter = "Icon File|*.ico";
                sfd.OverwritePrompt = true;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = sfd.FileName;
                }
            }
        }
        /// <summary>
        /// Shows the open file dialog for input image. 
        /// </summary>
        private void AddImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "PNG2ICO - Choose Image";
                ofd.Multiselect = false;
                ofd.Filter = "Portable Network Graph|*.png";
                ofd.CheckFileExists = true;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = ofd.FileName;
                    LoadImage(Image.FromFile(ofd.FileName).Resize(ImageSizes[comboSizes.SelectedIndex], checkAspectRatio.Checked));
                }
            }
        }
        /// <summary>
        /// Start writing images in ICON file. 
        /// </summary>
        private void Save()
        {
            //Disable controls
            SetControls(false);
            SetStatus("Starting...");
            try
            {
                //Check if the output file already exists. 
                if (File.Exists(txtOutput.Text))
                {
                    var dr = MessageBox.Show("The file: " + txtOutput.Text + " already exist. Do you want to over-write with new one?", "PNG2ICO | WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                        Browse();
                    else if (dr == DialogResult.Cancel)
                        return;
                }
                //if not:
                Png2Ico.Convert(txtInput.Text, txtOutput.Text, SelectedSizes(),checkAllSizes.Checked && radioNewFile.Checked, checkAspectRatio.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "PNG2ICO - ERROR");
            }
            //Enable controls. 
            SetControls(true);
        }
        /// <summary>
        /// Returns array of size-variants according to selected options. 
        /// </summary>
        /// <returns></returns>
        private Size[] SelectedSizes()
        {
            if (checkAllSizes.Checked)
                return ImageSizes;
            return new Size[] { ImageSizes[comboSizes.SelectedIndex] };
        }
        /// <summary>
        /// Loads an image in the picture box. 
        /// </summary>
        /// <param name="img"></param>
        void LoadImage(Image img)
        {
            this.pictureBox.Image = img;
        }
        #endregion

    }
}
