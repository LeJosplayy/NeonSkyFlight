namespace MultiWiiWinGUI
{
    partial class splash_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_screen));
            this.l_version = new System.Windows.Forms.Label();
            this.colorProgressBar1 = new MultiWiiGUIControls.ColorProgressBar();
            this.SuspendLayout();
            // 
            // l_version
            // 
            this.l_version.BackColor = System.Drawing.Color.Transparent;
            this.l_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_version.ForeColor = System.Drawing.Color.LightGray;
            this.l_version.Location = new System.Drawing.Point(336, 9);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(252, 18);
            this.l_version.TabIndex = 0;
            this.l_version.Text = "Version 2400 NeonSkyFlight";
            this.l_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_version.Visible = false;
            // 
            // colorProgressBar1
            // 
            this.colorProgressBar1.BarColor = System.Drawing.Color.Cyan;
            this.colorProgressBar1.BkgColor = System.Drawing.Color.Transparent;
            this.colorProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.colorProgressBar1.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Dashed;
            this.colorProgressBar1.Location = new System.Drawing.Point(0, 269);
            this.colorProgressBar1.Maximum = 100;
            this.colorProgressBar1.Minimum = 0;
            this.colorProgressBar1.Name = "colorProgressBar1";
            this.colorProgressBar1.Size = new System.Drawing.Size(599, 10);
            this.colorProgressBar1.Step = 10;
            this.colorProgressBar1.TabIndex = 1;
            this.colorProgressBar1.Text = "colorProgressBar1";
            this.colorProgressBar1.Value = 0;
            this.colorProgressBar1.Visible = false;
            // 
            // splash_screen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 278);
            this.ControlBox = false;
            this.Controls.Add(this.colorProgressBar1);
            this.Controls.Add(this.l_version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 280);
            this.Name = "splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.splash_screen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public MultiWiiGUIControls.ColorProgressBar colorProgressBar1;
        public System.Windows.Forms.Label l_version;
    }
}