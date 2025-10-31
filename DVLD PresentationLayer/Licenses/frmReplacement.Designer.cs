namespace DVLD_PresentationLayer.Licenses
{
    partial class frmReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacement));
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCreatedByResult = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbApplicationFeesResult = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbOldLicenseIDResult = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.lbApplicatioDateResult = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbReplacedLicenseIDResult = new System.Windows.Forms.Label();
            this.lbReplacedLicenseID = new System.Windows.Forms.Label();
            this.lbRLApplicationIDResult = new System.Windows.Forms.Label();
            this.lbRLApplicationID = new System.Windows.Forms.Label();
            this.llbShowNewLicense = new System.Windows.Forms.LinkLabel();
            this.llbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.uctrlLicenseInfoBySearch1 = new DVLD_PresentationLayer.Licenses.uctrlLicenseInfoBySearch();
            this.gbReplacementFor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementFor.Location = new System.Drawing.Point(741, 51);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(311, 91);
            this.gbReplacementFor.TabIndex = 1;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(6, 55);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(138, 23);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(6, 26);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(165, 23);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1051, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Replacement For Damaged License";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCreatedByResult);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbApplicationFeesResult);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.lbOldLicenseIDResult);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.lbApplicatioDateResult);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.lbReplacedLicenseIDResult);
            this.groupBox1.Controls.Add(this.lbReplacedLicenseID);
            this.groupBox1.Controls.Add(this.lbRLApplicationIDResult);
            this.groupBox1.Controls.Add(this.lbRLApplicationID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 575);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info for License Replacement";
            // 
            // lbCreatedByResult
            // 
            this.lbCreatedByResult.AutoSize = true;
            this.lbCreatedByResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByResult.Location = new System.Drawing.Point(802, 133);
            this.lbCreatedByResult.Name = "lbCreatedByResult";
            this.lbCreatedByResult.Size = new System.Drawing.Size(54, 19);
            this.lbCreatedByResult.TabIndex = 30;
            this.lbCreatedByResult.Text = "[???]";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("lbCreatedBy.Image")));
            this.lbCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCreatedBy.Location = new System.Drawing.Point(540, 123);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(246, 38);
            this.lbCreatedBy.TabIndex = 29;
            this.lbCreatedBy.Text = "Created By :";
            this.lbCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApplicationFeesResult
            // 
            this.lbApplicationFeesResult.AutoSize = true;
            this.lbApplicationFeesResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesResult.Location = new System.Drawing.Point(252, 133);
            this.lbApplicationFeesResult.Name = "lbApplicationFeesResult";
            this.lbApplicationFeesResult.Size = new System.Drawing.Size(54, 19);
            this.lbApplicationFeesResult.TabIndex = 32;
            this.lbApplicationFeesResult.Text = "[???]";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.Image = ((System.Drawing.Image)(resources.GetObject("lbApplicationFees.Image")));
            this.lbApplicationFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbApplicationFees.Location = new System.Drawing.Point(6, 127);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(231, 31);
            this.lbApplicationFees.TabIndex = 31;
            this.lbApplicationFees.Text = "Application Fees :";
            this.lbApplicationFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOldLicenseIDResult
            // 
            this.lbOldLicenseIDResult.AutoSize = true;
            this.lbOldLicenseIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseIDResult.Location = new System.Drawing.Point(802, 85);
            this.lbOldLicenseIDResult.Name = "lbOldLicenseIDResult";
            this.lbOldLicenseIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbOldLicenseIDResult.TabIndex = 22;
            this.lbOldLicenseIDResult.Text = "[???]";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("lbOldLicenseID.Image")));
            this.lbOldLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbOldLicenseID.Location = new System.Drawing.Point(540, 79);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(246, 31);
            this.lbOldLicenseID.TabIndex = 21;
            this.lbOldLicenseID.Text = "Old License ID :";
            this.lbOldLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApplicatioDateResult
            // 
            this.lbApplicatioDateResult.AutoSize = true;
            this.lbApplicatioDateResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicatioDateResult.Location = new System.Drawing.Point(252, 85);
            this.lbApplicatioDateResult.Name = "lbApplicatioDateResult";
            this.lbApplicatioDateResult.Size = new System.Drawing.Size(54, 19);
            this.lbApplicatioDateResult.TabIndex = 20;
            this.lbApplicatioDateResult.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.Image = ((System.Drawing.Image)(resources.GetObject("lbApplicationDate.Image")));
            this.lbApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbApplicationDate.Location = new System.Drawing.Point(6, 73);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(231, 43);
            this.lbApplicationDate.TabIndex = 19;
            this.lbApplicationDate.Text = "Application Date :";
            this.lbApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbReplacedLicenseIDResult
            // 
            this.lbReplacedLicenseIDResult.AutoSize = true;
            this.lbReplacedLicenseIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplacedLicenseIDResult.Location = new System.Drawing.Point(802, 39);
            this.lbReplacedLicenseIDResult.Name = "lbReplacedLicenseIDResult";
            this.lbReplacedLicenseIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbReplacedLicenseIDResult.TabIndex = 16;
            this.lbReplacedLicenseIDResult.Text = "[???]";
            // 
            // lbReplacedLicenseID
            // 
            this.lbReplacedLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("lbReplacedLicenseID.Image")));
            this.lbReplacedLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbReplacedLicenseID.Location = new System.Drawing.Point(540, 33);
            this.lbReplacedLicenseID.Name = "lbReplacedLicenseID";
            this.lbReplacedLicenseID.Size = new System.Drawing.Size(246, 31);
            this.lbReplacedLicenseID.TabIndex = 15;
            this.lbReplacedLicenseID.Text = "Replaced License ID :";
            this.lbReplacedLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRLApplicationIDResult
            // 
            this.lbRLApplicationIDResult.AutoSize = true;
            this.lbRLApplicationIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLApplicationIDResult.Location = new System.Drawing.Point(252, 39);
            this.lbRLApplicationIDResult.Name = "lbRLApplicationIDResult";
            this.lbRLApplicationIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbRLApplicationIDResult.TabIndex = 14;
            this.lbRLApplicationIDResult.Text = "[???]";
            // 
            // lbRLApplicationID
            // 
            this.lbRLApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("lbRLApplicationID.Image")));
            this.lbRLApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbRLApplicationID.Location = new System.Drawing.Point(6, 33);
            this.lbRLApplicationID.Name = "lbRLApplicationID";
            this.lbRLApplicationID.Size = new System.Drawing.Size(231, 31);
            this.lbRLApplicationID.TabIndex = 13;
            this.lbRLApplicationID.Text = "R.L.Application ID :";
            this.lbRLApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbShowNewLicense
            // 
            this.llbShowNewLicense.AutoSize = true;
            this.llbShowNewLicense.Enabled = false;
            this.llbShowNewLicense.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbShowNewLicense.Location = new System.Drawing.Point(275, 763);
            this.llbShowNewLicense.Name = "llbShowNewLicense";
            this.llbShowNewLicense.Size = new System.Drawing.Size(170, 22);
            this.llbShowNewLicense.TabIndex = 60;
            this.llbShowNewLicense.TabStop = true;
            this.llbShowNewLicense.Text = "Show New License";
            this.llbShowNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowNewLicense_LinkClicked);
            // 
            // llbShowLicenseHistory
            // 
            this.llbShowLicenseHistory.AutoSize = true;
            this.llbShowLicenseHistory.Enabled = false;
            this.llbShowLicenseHistory.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbShowLicenseHistory.Location = new System.Drawing.Point(18, 763);
            this.llbShowLicenseHistory.Name = "llbShowLicenseHistory";
            this.llbShowLicenseHistory.Size = new System.Drawing.Size(210, 22);
            this.llbShowLicenseHistory.TabIndex = 59;
            this.llbShowLicenseHistory.TabStop = true;
            this.llbShowLicenseHistory.Text = "Show License History";
            this.llbShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowLicenseHistory_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(672, 752);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueReplacement.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueReplacement.Image")));
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.Location = new System.Drawing.Point(818, 752);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(245, 45);
            this.btnIssueReplacement.TabIndex = 57;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // uctrlLicenseInfoBySearch1
            // 
            this.uctrlLicenseInfoBySearch1.Location = new System.Drawing.Point(12, 51);
            this.uctrlLicenseInfoBySearch1.Name = "uctrlLicenseInfoBySearch1";
            this.uctrlLicenseInfoBySearch1.Size = new System.Drawing.Size(1051, 518);
            this.uctrlLicenseInfoBySearch1.TabIndex = 0;
            this.uctrlLicenseInfoBySearch1.OnSearchClicked += new System.EventHandler(this.uctrlLicenseInfoBySearch1_OnSearchClicked);
            // 
            // frmReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 806);
            this.Controls.Add(this.llbShowNewLicense);
            this.Controls.Add(this.llbShowLicenseHistory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.uctrlLicenseInfoBySearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replacement For Damaged License";
            this.Load += new System.EventHandler(this.frmReplacement_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReplacement_KeyDown);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlLicenseInfoBySearch uctrlLicenseInfoBySearch1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRLApplicationIDResult;
        private System.Windows.Forms.Label lbRLApplicationID;
        private System.Windows.Forms.Label lbReplacedLicenseIDResult;
        private System.Windows.Forms.Label lbReplacedLicenseID;
        private System.Windows.Forms.Label lbOldLicenseIDResult;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label lbApplicatioDateResult;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbCreatedByResult;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbApplicationFeesResult;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.LinkLabel llbShowNewLicense;
        private System.Windows.Forms.LinkLabel llbShowLicenseHistory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIssueReplacement;
    }
}