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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buildFolderButton = new System.Windows.Forms.Button();
            this.SDFolderButton = new System.Windows.Forms.Button();
            this.buildFP = new System.Windows.Forms.Label();
            this.SDFP = new System.Windows.Forms.Label();
            this.openSDFile = new System.Windows.Forms.OpenFileDialog();
            this.UpdateWebApp = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buildFolderButton
            // 
            this.buildFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildFolderButton.Location = new System.Drawing.Point(12, 151);
            this.buildFolderButton.Name = "buildFolderButton";
            this.buildFolderButton.Size = new System.Drawing.Size(265, 39);
            this.buildFolderButton.TabIndex = 0;
            this.buildFolderButton.Text = "OpenBuildFolder";
            this.buildFolderButton.UseVisualStyleBackColor = true;
            this.buildFolderButton.Click += new System.EventHandler(this.buildFolderButton_Click);
            // 
            // SDFolderButton
            // 
            this.SDFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDFolderButton.Location = new System.Drawing.Point(12, 255);
            this.SDFolderButton.Name = "SDFolderButton";
            this.SDFolderButton.Size = new System.Drawing.Size(265, 45);
            this.SDFolderButton.TabIndex = 1;
            this.SDFolderButton.Text = "OpenSDFolder";
            this.SDFolderButton.UseVisualStyleBackColor = true;
            this.SDFolderButton.Click += new System.EventHandler(this.SDFolderButton_Click);
            // 
            // buildFP
            // 
            this.buildFP.AutoSize = true;
            this.buildFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildFP.Location = new System.Drawing.Point(95, 193);
            this.buildFP.Name = "buildFP";
            this.buildFP.Size = new System.Drawing.Size(183, 31);
            this.buildFP.TabIndex = 3;
            this.buildFP.Text = "buildFolderFP";
            // 
            // SDFP
            // 
            this.SDFP.AutoSize = true;
            this.SDFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDFP.Location = new System.Drawing.Point(98, 316);
            this.SDFP.Name = "SDFP";
            this.SDFP.Size = new System.Drawing.Size(155, 31);
            this.SDFP.TabIndex = 5;
            this.SDFP.Text = "sdFolderFP";
            this.SDFP.Click += new System.EventHandler(this.SDFP_Click);
            // 
            // openSDFile
            // 
            this.openSDFile.FileName = "openFileDialog2";
            // 
            // UpdateWebApp
            // 
            this.UpdateWebApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateWebApp.Location = new System.Drawing.Point(12, 382);
            this.UpdateWebApp.Name = "UpdateWebApp";
            this.UpdateWebApp.Size = new System.Drawing.Size(265, 51);
            this.UpdateWebApp.TabIndex = 6;
            this.UpdateWebApp.Text = "UpdateWebApp";
            this.UpdateWebApp.UseVisualStyleBackColor = true;
            this.UpdateWebApp.Click += new System.EventHandler(this.updateWebApp_Click);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Location = new System.Drawing.Point(98, 457);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(88, 13);
            this.statusMessage.TabIndex = 7;
            this.statusMessage.Text = "Status Messages";
            this.statusMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Front-End Developer Utility";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 115);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1032, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1032, 589);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.UpdateWebApp);
            this.Controls.Add(this.SDFP);
            this.Controls.Add(this.buildFP);
            this.Controls.Add(this.SDFolderButton);
            this.Controls.Add(this.buildFolderButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

