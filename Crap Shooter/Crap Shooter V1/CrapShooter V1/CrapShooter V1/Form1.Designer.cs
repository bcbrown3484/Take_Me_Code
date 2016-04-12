namespace CrapShooter_V1
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.laserCannon = new System.Windows.Forms.PictureBox();
            this.lazerBeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazerBeam)).BeginInit();
            this.SuspendLayout();
            // 
            // laserCannon
            // 
            this.laserCannon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laserCannon.BackgroundImage")));
            this.laserCannon.Image = ((System.Drawing.Image)(resources.GetObject("laserCannon.Image")));
            this.laserCannon.Location = new System.Drawing.Point(322, 293);
            this.laserCannon.Name = "laserCannon";
            this.laserCannon.Size = new System.Drawing.Size(60, 60);
            this.laserCannon.TabIndex = 0;
            this.laserCannon.TabStop = false;
            // 
            // lazerBeam
            // 
            this.lazerBeam.Image = ((System.Drawing.Image)(resources.GetObject("lazerBeam.Image")));
            this.lazerBeam.Location = new System.Drawing.Point(351, 293);
            this.lazerBeam.Name = "lazerBeam";
            this.lazerBeam.Size = new System.Drawing.Size(3, 10);
            this.lazerBeam.TabIndex = 1;
            this.lazerBeam.TabStop = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.lazerBeam);
            this.Controls.Add(this.laserCannon);
            this.Name = "mainWindow";
            this.Text = "BCB\'s Lazer Cannon";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laserCannon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazerBeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox laserCannon;
        private System.Windows.Forms.PictureBox lazerBeam;
    }
}

