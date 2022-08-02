﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrontEndDevUtility
{
    public partial class Form1 : Form
    {
        string buildFolder = "";
        string sdFolder = "";
        public Form1()
        {
            InitializeComponent();
            buildFolder = Properties.Settings.Default.defaultBuildFP;
            sdFolder = Properties.Settings.Default.defaultSDFP;
            statusMessage.Text = "";
            buildFP.Text = buildFolder;
            SDFP.Text = sdFolder;
        }
        private void buildFolderButton_Click(object sender, EventArgs e)
        {
            statusMessage.Text = "";
            buildFP.Text = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected folder in the folder dialog
                buildFolder = fbd.SelectedPath;
                buildFP.Text = buildFolder;
                Properties.Settings.Default.defaultBuildFP = buildFolder;
                Properties.Settings.Default.Save();

        }


        private void SDFolderButton_Click(object sender, EventArgs e)
        {
            statusMessage.Text = "";
            SDFP.Text = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected folder in the folder dialog
                sdFolder = fbd.SelectedPath;
            SDFP.Text = sdFolder;
            Properties.Settings.Default.defaultSDFP = sdFolder;
            Properties.Settings.Default.Save();
            

        }

        private void SDFP_Click(object sender, EventArgs e)
        {
            
            openSDFile.Multiselect = false;
            if (openSDFile.ShowDialog() == DialogResult.OK)
            {
                sdFolder = Path.GetFileName(openFileDialog1.FileName);
            }
        }
        private void updateWebApp_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(sdFolder);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in di.EnumerateDirectories())
            {
                subDirectory.Delete(true);
            }
            foreach (string dirPath in Directory.GetDirectories(buildFolder, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(buildFolder, sdFolder));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(buildFolder, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(buildFolder, sdFolder), true);
            }
            DialogResult res = MessageBox.Show("Web App Updated Successfully. Eject SD card", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                
                
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*  private void SDCardPath_Click(object sender, EventArgs e)
          {

          }
        */
    }

    
}
