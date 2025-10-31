namespace DVLD_PresentationLayer.Licenses
{
    partial class frmShowDriverInternationalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDriverInternationalLicenseInfo));
            this.uctrlInternationalDriverLicense1 = new DVLD_PresentationLayer.Licenses.uctrlInternationalDriverLicense();
            this.lbShowLicenseInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uctrlInternationalDriverLicense1
            // 
            this.uctrlInternationalDriverLicense1.Location = new System.Drawing.Point(12, 206);
            this.uctrlInternationalDriverLicense1.Name = "uctrlInternationalDriverLicense1";
            this.uctrlInternationalDriverLicense1.Size = new System.Drawing.Size(1082, 324);
            this.uctrlInternationalDriverLicense1.TabIndex = 0;
            // 
            // lbShowLicenseInfo
            // 
            this.lbShowLicenseInfo.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseInfo.ForeColor = System.Drawing.Color.Red;
            this.lbShowLicenseInfo.Location = new System.Drawing.Point(222, 151);
            this.lbShowLicenseInfo.Name = "lbShowLicenseInfo";
            this.lbShowLicenseInfo.Size = new System.Drawing.Size(662, 41);
            this.lbShowLicenseInfo.TabIndex = 4;
            this.lbShowLicenseInfo.Text = "Driver International License Info";
            this.lbShowLicenseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(950, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 42);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowDriverInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 587);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbShowLicenseInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uctrlInternationalDriverLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowDriverInternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Driver International License Info";
            this.Load += new System.EventHandler(this.frmShowDriverInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private uctrlInternationalDriverLicense uctrlInternationalDriverLicense1;
        private System.Windows.Forms.Label lbShowLicenseInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}