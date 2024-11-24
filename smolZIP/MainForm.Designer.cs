namespace smolZIP
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnExtractZip;
        private System.Windows.Forms.Button btnCreateZip;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnExtractZip = new System.Windows.Forms.Button();
            this.btnCreateZip = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExtractZip
            // 
            this.btnExtractZip.BackColor = System.Drawing.Color.Transparent;
            this.btnExtractZip.Location = new System.Drawing.Point(12, 325);
            this.btnExtractZip.Name = "btnExtractZip";
            this.btnExtractZip.Size = new System.Drawing.Size(109, 43);
            this.btnExtractZip.TabIndex = 2;
            this.btnExtractZip.Text = "Extract ZIP";
            this.btnExtractZip.UseVisualStyleBackColor = false;
            this.btnExtractZip.Click += new System.EventHandler(this.btnExtractZip_Click);
            // 
            // btnCreateZip
            // 
            this.btnCreateZip.Location = new System.Drawing.Point(190, 325);
            this.btnCreateZip.Name = "btnCreateZip";
            this.btnCreateZip.Size = new System.Drawing.Size(104, 43);
            this.btnCreateZip.TabIndex = 3;
            this.btnCreateZip.Text = "Create ZIP";
            this.btnCreateZip.UseVisualStyleBackColor = true;
            this.btnCreateZip.Click += new System.EventHandler(this.btnCreateZip_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 285);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(282, 23);
            this.progressBar.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Space Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(21, 109);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "smolZIP by abrendan";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(225, 269);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.0.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::smolZIP.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnCreateZip);
            this.Controls.Add(this.btnExtractZip);
            this.Name = "MainForm";
            this.Text = "smolZIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}