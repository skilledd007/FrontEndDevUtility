namespace FrontEndDevUtility
{
    partial class Form1
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
            this.buildFolderButton = new System.Windows.Forms.Button();
            this.SDFolderButton = new System.Windows.Forms.Button();
            this.buildFP = new System.Windows.Forms.Label();
            this.SDFP = new System.Windows.Forms.Label();
            this.openSDFile = new System.Windows.Forms.OpenFileDialog();
            this.UpdateWebApp = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buildFolderButton
            // 
            this.buildFolderButton.Location = new System.Drawing.Point(429, 204);
            this.buildFolderButton.Name = "buildFolderButton";
            this.buildFolderButton.Size = new System.Drawing.Size(133, 23);
            this.buildFolderButton.TabIndex = 0;
            this.buildFolderButton.Text = "OpenBuildFolder";
            this.buildFolderButton.UseVisualStyleBackColor = true;
            this.buildFolderButton.Click += new System.EventHandler(this.buildFolderButton_Click);
            // 
            // SDFolderButton
            // 
            this.SDFolderButton.Location = new System.Drawing.Point(429, 318);
            this.SDFolderButton.Name = "SDFolderButton";
            this.SDFolderButton.Size = new System.Drawing.Size(135, 23);
            this.SDFolderButton.TabIndex = 1;
            this.SDFolderButton.Text = "OpenSDFolder";
            this.SDFolderButton.UseVisualStyleBackColor = true;
            this.SDFolderButton.Click += new System.EventHandler(this.SDFolderButton_Click);
            // 
            // buildFP
            // 
            this.buildFP.AutoSize = true;
            this.buildFP.Location = new System.Drawing.Point(474, 230);
            this.buildFP.Name = "buildFP";
            this.buildFP.Size = new System.Drawing.Size(35, 13);
            this.buildFP.TabIndex = 3;
            this.buildFP.Text = "label2";
            // 
            // SDFP
            // 
            this.SDFP.AutoSize = true;
            this.SDFP.Location = new System.Drawing.Point(474, 344);
            this.SDFP.Name = "SDFP";
            this.SDFP.Size = new System.Drawing.Size(35, 13);
            this.SDFP.TabIndex = 5;
            this.SDFP.Text = "label4";
            this.SDFP.Click += new System.EventHandler(this.SDFP_Click);
            // 
            // openSDFile
            // 
            this.openSDFile.FileName = "openFileDialog2";
            // 
            // UpdateWebApp
            // 
            this.UpdateWebApp.Location = new System.Drawing.Point(429, 425);
            this.UpdateWebApp.Name = "UpdateWebApp";
            this.UpdateWebApp.Size = new System.Drawing.Size(135, 23);
            this.UpdateWebApp.TabIndex = 6;
            this.UpdateWebApp.Text = "UpdateWebApp";
            this.UpdateWebApp.UseVisualStyleBackColor = true;
            this.UpdateWebApp.Click += new System.EventHandler(this.updateWebApp_Click);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Location = new System.Drawing.Point(474, 489);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(88, 13);
            this.statusMessage.TabIndex = 7;
            this.statusMessage.Text = "Status Messages";
            this.statusMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1032, 589);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.UpdateWebApp);
            this.Controls.Add(this.SDFP);
            this.Controls.Add(this.buildFP);
            this.Controls.Add(this.SDFolderButton);
            this.Controls.Add(this.buildFolderButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Button SDCardPath;
        private System.Windows.Forms.Button buildFolderButton;
        private System.Windows.Forms.Button SDFolderButton;
        private System.Windows.Forms.Label buildFP;
        private System.Windows.Forms.Label SDFP;
        private System.Windows.Forms.OpenFileDialog openSDFile;
        private System.Windows.Forms.Button UpdateWebApp;
        private System.Windows.Forms.Label statusMessage;
    }
}

