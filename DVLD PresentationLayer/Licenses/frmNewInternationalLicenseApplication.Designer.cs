namespace DVLD_PresentationLayer.Licenses
{
    partial class frmNewInternationalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewInternationalLicenseApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCreatedByResult = new System.Windows.Forms.Label();
            this.lbExpirationDateResult = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbLocalLicenseIDResult = new System.Windows.Forms.Label();
            this.lbLocalLicenseID = new System.Windows.Forms.Label();
            this.lbFeesResult = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbApplicationDateResult = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbIssueDateResult = new System.Windows.Forms.Label();
            this.lbInternationalLicenseIDResult = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lbInternationalLicenseID = new System.Windows.Forms.Label();
            this.lbInternationalLicenseApplicationIDResult = new System.Windows.Forms.Label();
            this.lbInternationalLicenseApplicationID = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.llbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llbShowLicense = new System.Windows.Forms.LinkLabel();
            this.uctrlLicenseInfoBySearch1 = new DVLD_PresentationLayer.Licenses.uctrlLicenseInfoBySearch();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "International License Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCreatedByResult);
            this.groupBox1.Controls.Add(this.lbExpirationDateResult);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.lbLocalLicenseIDResult);
            this.groupBox1.Controls.Add(this.lbLocalLicenseID);
            this.groupBox1.Controls.Add(this.lbFeesResult);
            this.groupBox1.Controls.Add(this.lbFees);
            this.groupBox1.Controls.Add(this.lbApplicationDateResult);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbIssueDateResult);
            this.groupBox1.Controls.Add(this.lbInternationalLicenseIDResult);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.lbInternationalLicenseID);
            this.groupBox1.Controls.Add(this.lbInternationalLicenseApplicationIDResult);
            this.groupBox1.Controls.Add(this.lbInternationalLicenseApplicationID);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // lbCreatedByResult
            // 
            this.lbCreatedByResult.AutoSize = true;
            this.lbCreatedByResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByResult.Location = new System.Drawing.Point(751, 175);
            this.lbCreatedByResult.Name = "lbCreatedByResult";
            this.lbCreatedByResult.Size = new System.Drawing.Size(54, 19);
            this.lbCreatedByResult.TabIndex = 20;
            this.lbCreatedByResult.Text = "[???]";
            // 
            // lbExpirationDateResult
            // 
            this.lbExpirationDateResult.AutoSize = true;
            this.lbExpirationDateResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDateResult.Location = new System.Drawing.Point(751, 132);
            this.lbExpirationDateResult.Name = "lbExpirationDateResult";
            this.lbExpirationDateResult.Size = new System.Drawing.Size(54, 19);
            this.lbExpirationDateResult.TabIndex = 31;
            this.lbExpirationDateResult.Text = "[???]";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("lbCreatedBy.Image")));
            this.lbCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCreatedBy.Location = new System.Drawing.Point(521, 165);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(215, 38);
            this.lbCreatedBy.TabIndex = 19;
            this.lbCreatedBy.Text = "Created By :";
            this.lbCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.Image = ((System.Drawing.Image)(resources.GetObject("lbExpirationDate.Image")));
            this.lbExpirationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbExpirationDate.Location = new System.Drawing.Point(521, 121);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(215, 41);
            this.lbExpirationDate.TabIndex = 30;
            this.lbExpirationDate.Text = "Expiration Date :";
            this.lbExpirationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLocalLicenseIDResult
            // 
            this.lbLocalLicenseIDResult.AutoSize = true;
            this.lbLocalLicenseIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalLicenseIDResult.Location = new System.Drawing.Point(751, 83);
            this.lbLocalLicenseIDResult.Name = "lbLocalLicenseIDResult";
            this.lbLocalLicenseIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbLocalLicenseIDResult.TabIndex = 29;
            this.lbLocalLicenseIDResult.Text = "[???]";
            // 
            // lbLocalLicenseID
            // 
            this.lbLocalLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("lbLocalLicenseID.Image")));
            this.lbLocalLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLocalLicenseID.Location = new System.Drawing.Point(521, 77);
            this.lbLocalLicenseID.Name = "lbLocalLicenseID";
            this.lbLocalLicenseID.Size = new System.Drawing.Size(215, 31);
            this.lbLocalLicenseID.TabIndex = 28;
            this.lbLocalLicenseID.Text = "Local License ID :";
            this.lbLocalLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFeesResult
            // 
            this.lbFeesResult.AutoSize = true;
            this.lbFeesResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesResult.Location = new System.Drawing.Point(283, 175);
            this.lbFeesResult.Name = "lbFeesResult";
            this.lbFeesResult.Size = new System.Drawing.Size(54, 19);
            this.lbFeesResult.TabIndex = 27;
            this.lbFeesResult.Text = "[???]";
            // 
            // lbFees
            // 
            this.lbFees.Image = ((System.Drawing.Image)(resources.GetObject("lbFees.Image")));
            this.lbFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFees.Location = new System.Drawing.Point(6, 169);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(261, 30);
            this.lbFees.TabIndex = 26;
            this.lbFees.Text = "Fees :";
            this.lbFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApplicationDateResult
            // 
            this.lbApplicationDateResult.AutoSize = true;
            this.lbApplicationDateResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateResult.Location = new System.Drawing.Point(283, 83);
            this.lbApplicationDateResult.Name = "lbApplicationDateResult";
            this.lbApplicationDateResult.Size = new System.Drawing.Size(54, 19);
            this.lbApplicationDateResult.TabIndex = 25;
            this.lbApplicationDateResult.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.Image = ((System.Drawing.Image)(resources.GetObject("lbApplicationDate.Image")));
            this.lbApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbApplicationDate.Location = new System.Drawing.Point(6, 71);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(261, 43);
            this.lbApplicationDate.TabIndex = 24;
            this.lbApplicationDate.Text = "Application Date :";
            this.lbApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIssueDateResult
            // 
            this.lbIssueDateResult.AutoSize = true;
            this.lbIssueDateResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDateResult.Location = new System.Drawing.Point(283, 132);
            this.lbIssueDateResult.Name = "lbIssueDateResult";
            this.lbIssueDateResult.Size = new System.Drawing.Size(54, 19);
            this.lbIssueDateResult.TabIndex = 23;
            this.lbIssueDateResult.Text = "[???]";
            // 
            // lbInternationalLicenseIDResult
            // 
            this.lbInternationalLicenseIDResult.AutoSize = true;
            this.lbInternationalLicenseIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalLicenseIDResult.Location = new System.Drawing.Point(751, 40);
            this.lbInternationalLicenseIDResult.Name = "lbInternationalLicenseIDResult";
            this.lbInternationalLicenseIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbInternationalLicenseIDResult.TabIndex = 16;
            this.lbInternationalLicenseIDResult.Text = "[???]";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.Image = ((System.Drawing.Image)(resources.GetObject("lbIssueDate.Image")));
            this.lbIssueDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbIssueDate.Location = new System.Drawing.Point(6, 120);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(261, 43);
            this.lbIssueDate.TabIndex = 22;
            this.lbIssueDate.Text = "Issue Date :";
            this.lbIssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInternationalLicenseID
            // 
            this.lbInternationalLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("lbInternationalLicenseID.Image")));
            this.lbInternationalLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbInternationalLicenseID.Location = new System.Drawing.Point(521, 34);
            this.lbInternationalLicenseID.Name = "lbInternationalLicenseID";
            this.lbInternationalLicenseID.Size = new System.Drawing.Size(215, 31);
            this.lbInternationalLicenseID.TabIndex = 15;
            this.lbInternationalLicenseID.Text = "Int.License ID :";
            this.lbInternationalLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInternationalLicenseApplicationIDResult
            // 
            this.lbInternationalLicenseApplicationIDResult.AutoSize = true;
            this.lbInternationalLicenseApplicationIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalLicenseApplicationIDResult.Location = new System.Drawing.Point(283, 40);
            this.lbInternationalLicenseApplicationIDResult.Name = "lbInternationalLicenseApplicationIDResult";
            this.lbInternationalLicenseApplicationIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbInternationalLicenseApplicationIDResult.TabIndex = 14;
            this.lbInternationalLicenseApplicationIDResult.Text = "[???]";
            // 
            // lbInternationalLicenseApplicationID
            // 
            this.lbInternationalLicenseApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("lbInternationalLicenseApplicationID.Image")));
            this.lbInternationalLicenseApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbInternationalLicenseApplicationID.Location = new System.Drawing.Point(6, 34);
            this.lbInternationalLicenseApplicationID.Name = "lbInternationalLicenseApplicationID";
            this.lbInternationalLicenseApplicationID.Size = new System.Drawing.Size(261, 31);
            this.lbInternationalLicenseApplicationID.TabIndex = 13;
            this.lbInternationalLicenseApplicationID.Text = "Int.L.Application ID :";
            this.lbInternationalLicenseApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.Location = new System.Drawing.Point(924, 805);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(133, 45);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(778, 805);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // llbShowLicenseHistory
            // 
            this.llbShowLicenseHistory.AutoSize = true;
            this.llbShowLicenseHistory.Enabled = false;
            this.llbShowLicenseHistory.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbShowLicenseHistory.Location = new System.Drawing.Point(12, 816);
            this.llbShowLicenseHistory.Name = "llbShowLicenseHistory";
            this.llbShowLicenseHistory.Size = new System.Drawing.Size(210, 22);
            this.llbShowLicenseHistory.TabIndex = 51;
            this.llbShowLicenseHistory.TabStop = true;
            this.llbShowLicenseHistory.Text = "Show License History";
            this.llbShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicenseHistory_LinkClicked);
            // 
            // llbShowLicense
            // 
            this.llbShowLicense.AutoSize = true;
            this.llbShowLicense.Enabled = false;
            this.llbShowLicense.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbShowLicense.Location = new System.Drawing.Point(269, 816);
            this.llbShowLicense.Name = "llbShowLicense";
            this.llbShowLicense.Size = new System.Drawing.Size(130, 22);
            this.llbShowLicense.TabIndex = 52;
            this.llbShowLicense.TabStop = true;
            this.llbShowLicense.Text = "Show License";
            this.llbShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicense_LinkClicked);
            // 
            // uctrlLicenseInfoBySearch1
            // 
            this.uctrlLicenseInfoBySearch1.Location = new System.Drawing.Point(12, 52);
            this.uctrlLicenseInfoBySearch1.Name = "uctrlLicenseInfoBySearch1";
            this.uctrlLicenseInfoBySearch1.Size = new System.Drawing.Size(1053, 522);
            this.uctrlLicenseInfoBySearch1.TabIndex = 0;
            this.uctrlLicenseInfoBySearch1.OnSearchClicked += new System.EventHandler(this.uctrlLicenseInfoBySearch1_OnSearchClicked);
            // 
            // frmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1077, 856);
            this.Controls.Add(this.llbShowLicense);
            this.Controls.Add(this.llbShowLicenseHistory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uctrlLicenseInfoBySearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmNewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New International License Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewInternationalLicenseApplication_FormClosing);
            this.Load += new System.EventHandler(this.frmNewInternationalLicenseApplication_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNewInternationalLicenseApplication_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlLicenseInfoBySearch uctrlLicenseInfoBySearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbInternationalLicenseApplicationID;
        private System.Windows.Forms.Label lbInternationalLicenseIDResult;
        private System.Windows.Forms.Label lbInternationalLicenseID;
        private System.Windows.Forms.Label lbInternationalLicenseApplicationIDResult;
        private System.Windows.Forms.Label lbIssueDateResult;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label lbApplicationDateResult;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbFeesResult;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbLocalLicenseIDResult;
        private System.Windows.Forms.Label lbLocalLicenseID;
        private System.Windows.Forms.Label lbExpirationDateResult;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label lbCreatedByResult;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel llbShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llbShowLicense;
    }
}