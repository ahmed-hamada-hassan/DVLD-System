namespace DVLD_PresentationLayer.Application_Types
{
    partial class frmNewLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewLocalDrivingLicenseApplication));
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lbCreatedByResult = new System.Windows.Forms.Label();
            this.lbApplicationFeesResult = new System.Windows.Forms.Label();
            this.lbApplicationDateResult = new System.Windows.Forms.Label();
            this.lbApplicationIDResult = new System.Windows.Forms.Label();
            this.lbLicenseClass = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.uctrlAddNewUser1 = new DVLD_PresentationLayer.Users.uctrlAddNewUser();
            this.tabControl1.SuspendLayout();
            this.tbpPersonalInfo.SuspendLayout();
            this.tbpApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFormTitle.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormTitle.ForeColor = System.Drawing.Color.Red;
            this.lbFormTitle.Location = new System.Drawing.Point(247, 9);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(681, 45);
            this.lbFormTitle.TabIndex = 0;
            this.lbFormTitle.Text = "New Local Driving License Application";
            this.lbFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpPersonalInfo);
            this.tabControl1.Controls.Add(this.tbpApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 587);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tbpPersonalInfo
            // 
            this.tbpPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpPersonalInfo.Controls.Add(this.btnNext);
            this.tbpPersonalInfo.Controls.Add(this.uctrlAddNewUser1);
            this.tbpPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpPersonalInfo.Name = "tbpPersonalInfo";
            this.tbpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonalInfo.Size = new System.Drawing.Size(1142, 558);
            this.tbpPersonalInfo.TabIndex = 0;
            this.tbpPersonalInfo.Text = "Personal Info";
            this.tbpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(999, 500);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbpApplicationInfo
            // 
            this.tbpApplicationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tbpApplicationInfo.Controls.Add(this.lbCreatedByResult);
            this.tbpApplicationInfo.Controls.Add(this.lbApplicationFeesResult);
            this.tbpApplicationInfo.Controls.Add(this.lbApplicationDateResult);
            this.tbpApplicationInfo.Controls.Add(this.lbApplicationIDResult);
            this.tbpApplicationInfo.Controls.Add(this.lbLicenseClass);
            this.tbpApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.tbpApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tbpApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tbpApplicationInfo.Controls.Add(this.lbApplicationID);
            this.tbpApplicationInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpApplicationInfo.Name = "tbpApplicationInfo";
            this.tbpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpApplicationInfo.Size = new System.Drawing.Size(1142, 558);
            this.tbpApplicationInfo.TabIndex = 1;
            this.tbpApplicationInfo.Text = "Application Info";
            this.tbpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(408, 229);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(349, 27);
            this.cbLicenseClass.TabIndex = 9;
            // 
            // lbCreatedByResult
            // 
            this.lbCreatedByResult.AutoSize = true;
            this.lbCreatedByResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByResult.Location = new System.Drawing.Point(408, 367);
            this.lbCreatedByResult.Name = "lbCreatedByResult";
            this.lbCreatedByResult.Size = new System.Drawing.Size(60, 22);
            this.lbCreatedByResult.TabIndex = 8;
            this.lbCreatedByResult.Text = "[???]";
            // 
            // lbApplicationFeesResult
            // 
            this.lbApplicationFeesResult.AutoSize = true;
            this.lbApplicationFeesResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesResult.Location = new System.Drawing.Point(408, 299);
            this.lbApplicationFeesResult.Name = "lbApplicationFeesResult";
            this.lbApplicationFeesResult.Size = new System.Drawing.Size(60, 22);
            this.lbApplicationFeesResult.TabIndex = 7;
            this.lbApplicationFeesResult.Text = "[???]";
            // 
            // lbApplicationDateResult
            // 
            this.lbApplicationDateResult.AutoSize = true;
            this.lbApplicationDateResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateResult.Location = new System.Drawing.Point(408, 163);
            this.lbApplicationDateResult.Name = "lbApplicationDateResult";
            this.lbApplicationDateResult.Size = new System.Drawing.Size(60, 22);
            this.lbApplicationDateResult.TabIndex = 6;
            this.lbApplicationDateResult.Text = "[???]";
            // 
            // lbApplicationIDResult
            // 
            this.lbApplicationIDResult.AutoSize = true;
            this.lbApplicationIDResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationIDResult.Location = new System.Drawing.Point(408, 99);
            this.lbApplicationIDResult.Name = "lbApplicationIDResult";
            this.lbApplicationIDResult.Size = new System.Drawing.Size(60, 22);
            this.lbApplicationIDResult.TabIndex = 5;
            this.lbApplicationIDResult.Text = "[???]";
            // 
            // lbLicenseClass
            // 
            this.lbLicenseClass.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseClass.Image = ((System.Drawing.Image)(resources.GetObject("lbLicenseClass.Image")));
            this.lbLicenseClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLicenseClass.Location = new System.Drawing.Point(74, 216);
            this.lbLicenseClass.Name = "lbLicenseClass";
            this.lbLicenseClass.Size = new System.Drawing.Size(282, 53);
            this.lbLicenseClass.TabIndex = 4;
            this.lbLicenseClass.Text = "License Class : ";
            this.lbLicenseClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("lbCreatedBy.Image")));
            this.lbCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCreatedBy.Location = new System.Drawing.Point(74, 352);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(282, 53);
            this.lbCreatedBy.TabIndex = 3;
            this.lbCreatedBy.Text = "Created By :";
            this.lbCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Image = ((System.Drawing.Image)(resources.GetObject("lbApplicationFees.Image")));
            this.lbApplicationFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbApplicationFees.Location = new System.Drawing.Point(74, 284);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(282, 53);
            this.lbApplicationFees.TabIndex = 2;
            this.lbApplicationFees.Text = "Application Fees : ";
            this.lbApplicationFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Image = ((System.Drawing.Image)(resources.GetObject("lbApplicationDate.Image")));
            this.lbApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbApplicationDate.Location = new System.Drawing.Point(74, 148);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(282, 53);
            this.lbApplicationDate.TabIndex = 1;
            this.lbApplicationDate.Text = "Application Date : ";
            this.lbApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("lbApplicationID.Image")));
            this.lbApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbApplicationID.Location = new System.Drawing.Point(74, 80);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(282, 53);
            this.lbApplicationID.TabIndex = 0;
            this.lbApplicationID.Text = "Application ID : ";
            this.lbApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(1017, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(860, 650);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uctrlAddNewUser1
            // 
            this.uctrlAddNewUser1.Location = new System.Drawing.Point(7, 7);
            this.uctrlAddNewUser1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlAddNewUser1.Name = "uctrlAddNewUser1";
            this.uctrlAddNewUser1.Size = new System.Drawing.Size(1125, 486);
            this.uctrlAddNewUser1.TabIndex = 0;
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 709);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Local Driving License Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewLocalDrivingLicenseApplication_FormClosing);
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpPersonalInfo.ResumeLayout(false);
            this.tbpApplicationInfo.ResumeLayout(false);
            this.tbpApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPersonalInfo;
        private Users.uctrlAddNewUser uctrlAddNewUser1;
        private System.Windows.Forms.TabPage tbpApplicationInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbLicenseClass;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbCreatedByResult;
        private System.Windows.Forms.Label lbApplicationFeesResult;
        private System.Windows.Forms.Label lbApplicationDateResult;
        private System.Windows.Forms.Label lbApplicationIDResult;
        private System.Windows.Forms.ComboBox cbLicenseClass;
    }
}