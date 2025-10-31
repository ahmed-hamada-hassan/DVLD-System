namespace DVLD_PresentationLayer.Licenses
{
    partial class frmDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainedLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCreatedByResult = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbLicenseIDResult = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.txtFineFeesResult = new System.Windows.Forms.TextBox();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.lbDetainDateResult = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainIDResult = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.llbShowNewLicense = new System.Windows.Forms.LinkLabel();
            this.llbShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uctrlLicenseInfoBySearch1 = new DVLD_PresentationLayer.Licenses.uctrlLicenseInfoBySearch();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detain License";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCreatedByResult);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.lbLicenseIDResult);
            this.groupBox1.Controls.Add(this.lbLicenseID);
            this.groupBox1.Controls.Add(this.txtFineFeesResult);
            this.groupBox1.Controls.Add(this.lbFineFees);
            this.groupBox1.Controls.Add(this.lbDetainDateResult);
            this.groupBox1.Controls.Add(this.lbDetainDate);
            this.groupBox1.Controls.Add(this.lbDetainIDResult);
            this.groupBox1.Controls.Add(this.lbDetainID);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 568);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // lbCreatedByResult
            // 
            this.lbCreatedByResult.AutoSize = true;
            this.lbCreatedByResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByResult.Location = new System.Drawing.Point(832, 81);
            this.lbCreatedByResult.Name = "lbCreatedByResult";
            this.lbCreatedByResult.Size = new System.Drawing.Size(54, 19);
            this.lbCreatedByResult.TabIndex = 37;
            this.lbCreatedByResult.Text = "[???]";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("lbCreatedBy.Image")));
            this.lbCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCreatedBy.Location = new System.Drawing.Point(570, 71);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(246, 38);
            this.lbCreatedBy.TabIndex = 36;
            this.lbCreatedBy.Text = "Created By :";
            this.lbCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLicenseIDResult
            // 
            this.lbLicenseIDResult.AutoSize = true;
            this.lbLicenseIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseIDResult.Location = new System.Drawing.Point(832, 38);
            this.lbLicenseIDResult.Name = "lbLicenseIDResult";
            this.lbLicenseIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbLicenseIDResult.TabIndex = 35;
            this.lbLicenseIDResult.Text = "[???]";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("lbLicenseID.Image")));
            this.lbLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLicenseID.Location = new System.Drawing.Point(570, 32);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(246, 31);
            this.lbLicenseID.TabIndex = 34;
            this.lbLicenseID.Text = "License ID :";
            this.lbLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFineFeesResult
            // 
            this.txtFineFeesResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFineFeesResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineFeesResult.Location = new System.Drawing.Point(252, 120);
            this.txtFineFeesResult.MaxLength = 10;
            this.txtFineFeesResult.Name = "txtFineFeesResult";
            this.txtFineFeesResult.Size = new System.Drawing.Size(161, 27);
            this.txtFineFeesResult.TabIndex = 33;
            this.txtFineFeesResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineFeesResult_KeyPress);
            // 
            // lbFineFees
            // 
            this.lbFineFees.Image = ((System.Drawing.Image)(resources.GetObject("lbFineFees.Image")));
            this.lbFineFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFineFees.Location = new System.Drawing.Point(6, 118);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(231, 31);
            this.lbFineFees.TabIndex = 32;
            this.lbFineFees.Text = "Fine Fees :";
            this.lbFineFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDetainDateResult
            // 
            this.lbDetainDateResult.AutoSize = true;
            this.lbDetainDateResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDateResult.Location = new System.Drawing.Point(252, 81);
            this.lbDetainDateResult.Name = "lbDetainDateResult";
            this.lbDetainDateResult.Size = new System.Drawing.Size(54, 19);
            this.lbDetainDateResult.TabIndex = 22;
            this.lbDetainDateResult.Text = "[???]";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.Image = ((System.Drawing.Image)(resources.GetObject("lbDetainDate.Image")));
            this.lbDetainDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDetainDate.Location = new System.Drawing.Point(6, 69);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(231, 43);
            this.lbDetainDate.TabIndex = 21;
            this.lbDetainDate.Text = "Detain Date :";
            this.lbDetainDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDetainIDResult
            // 
            this.lbDetainIDResult.AutoSize = true;
            this.lbDetainIDResult.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainIDResult.Location = new System.Drawing.Point(252, 38);
            this.lbDetainIDResult.Name = "lbDetainIDResult";
            this.lbDetainIDResult.Size = new System.Drawing.Size(54, 19);
            this.lbDetainIDResult.TabIndex = 16;
            this.lbDetainIDResult.Text = "[???]";
            // 
            // lbDetainID
            // 
            this.lbDetainID.Image = ((System.Drawing.Image)(resources.GetObject("lbDetainID.Image")));
            this.lbDetainID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDetainID.Location = new System.Drawing.Point(6, 32);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(231, 31);
            this.lbDetainID.TabIndex = 15;
            this.lbDetainID.Text = "Detain ID :";
            this.lbDetainID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbShowNewLicense
            // 
            this.llbShowNewLicense.AutoSize = true;
            this.llbShowNewLicense.Enabled = false;
            this.llbShowNewLicense.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbShowNewLicense.Location = new System.Drawing.Point(275, 743);
            this.llbShowNewLicense.Name = "llbShowNewLicense";
            this.llbShowNewLicense.Size = new System.Drawing.Size(170, 22);
            this.llbShowNewLicense.TabIndex = 64;
            this.llbShowNewLicense.TabStop = true;
            this.llbShowNewLicense.Text = "Show New License";
            this.llbShowNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowNewLicense_LinkClicked);
            // 
            // llbShowLicenseHistory
            // 
            this.llbShowLicenseHistory.AutoSize = true;
            this.llbShowLicenseHistory.Enabled = false;
            this.llbShowLicenseHistory.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbShowLicenseHistory.Location = new System.Drawing.Point(18, 743);
            this.llbShowLicenseHistory.Name = "llbShowLicenseHistory";
            this.llbShowLicenseHistory.Size = new System.Drawing.Size(210, 22);
            this.llbShowLicenseHistory.TabIndex = 63;
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
            this.btnCancel.Location = new System.Drawing.Point(788, 732);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Enabled = false;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetain.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.Location = new System.Drawing.Point(934, 732);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(129, 45);
            this.btnDetain.TabIndex = 61;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlLicenseInfoBySearch1
            // 
            this.uctrlLicenseInfoBySearch1.Location = new System.Drawing.Point(12, 45);
            this.uctrlLicenseInfoBySearch1.Name = "uctrlLicenseInfoBySearch1";
            this.uctrlLicenseInfoBySearch1.Size = new System.Drawing.Size(1051, 518);
            this.uctrlLicenseInfoBySearch1.TabIndex = 0;
            this.uctrlLicenseInfoBySearch1.OnSearchClicked += new System.EventHandler(this.uctrlLicenseInfoBySearch1_OnSearchClicked);
            // 
            // frmDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 785);
            this.Controls.Add(this.llbShowNewLicense);
            this.Controls.Add(this.llbShowLicenseHistory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uctrlLicenseInfoBySearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detained License";
            this.Load += new System.EventHandler(this.frmDetainedLicense_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetainedLicense_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlLicenseInfoBySearch uctrlLicenseInfoBySearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDetainIDResult;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label lbDetainDateResult;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.TextBox txtFineFeesResult;
        private System.Windows.Forms.Label lbLicenseIDResult;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbCreatedByResult;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.LinkLabel llbShowNewLicense;
        private System.Windows.Forms.LinkLabel llbShowLicenseHistory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}