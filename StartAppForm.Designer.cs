namespace miniAccess2018_V1_0
{
    partial class StartAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartAppForm));
            this.label1 = new System.Windows.Forms.Label();
            this.picLogoAbout = new System.Windows.Forms.PictureBox();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.startingBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AQUI VA EL LOGO";
            // 
            // picLogoAbout
            // 
            this.picLogoAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoAbout.ErrorImage = null;
            this.picLogoAbout.Image = ((System.Drawing.Image)(resources.GetObject("picLogoAbout.Image")));
            this.picLogoAbout.Location = new System.Drawing.Point(40, 27);
            this.picLogoAbout.Name = "picLogoAbout";
            this.picLogoAbout.Size = new System.Drawing.Size(406, 187);
            this.picLogoAbout.TabIndex = 3;
            this.picLogoAbout.TabStop = false;
            // 
            // timerRun
            // 
            this.timerRun.Interval = 3000;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // startingBar
            // 
            this.startingBar.Location = new System.Drawing.Point(40, 241);
            this.startingBar.MarqueeAnimationSpeed = 3000;
            this.startingBar.Maximum = 3000;
            this.startingBar.Name = "startingBar";
            this.startingBar.Size = new System.Drawing.Size(406, 23);
            this.startingBar.Step = 1;
            this.startingBar.TabIndex = 4;
            this.startingBar.Click += new System.EventHandler(this.startingBar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Version 1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Created By Francisco Maldonado";
            // 
            // StartAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(491, 318);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startingBar);
            this.Controls.Add(this.picLogoAbout);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartAppForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartAppForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StartAppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogoAbout;
        public System.Windows.Forms.Timer timerRun;
        public System.Windows.Forms.ProgressBar startingBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}