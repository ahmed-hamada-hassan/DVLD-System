namespace DVLD_PresentationLayer.Applications
{
    partial class frmManageLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApplications));
            this.lbLocalDrivingLicenseApplicationsTitle = new System.Windows.Forms.Label();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicaitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterBySearch = new System.Windows.Forms.TextBox();
            this.btnAddNewLocalDrivingLicense = new System.Windows.Forms.Button();
            this.lbRecords = new System.Windows.Forms.Label();
            this.lbRecordsResult = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLocalDrivingLicenseApplicationsTitle
            // 
            this.lbLocalDrivingLicenseApplicationsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLocalDrivingLicenseApplicationsTitle.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalDrivingLicenseApplicationsTitle.Location = new System.Drawing.Point(270, 247);
            this.lbLocalDrivingLicenseApplicationsTitle.Name = "lbLocalDrivingLicenseApplicationsTitle";
            this.lbLocalDrivingLicenseApplicationsTitle.Size = new System.Drawing.Size(656, 48);
            this.lbLocalDrivingLicenseApplicationsTitle.TabIndex = 0;
            this.lbLocalDrivingLicenseApplicationsTitle.Text = "Local Driving License Applications";
            this.lbLocalDrivingLicenseApplicationsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AllowUserToOrderColumns = true;
            this.dgvLocalLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalLicenses.GridColor = System.Drawing.Color.Black;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(12, 361);
            this.dgvLocalLicenses.MultiSelect = false;
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.RowHeadersWidth = 51;
            this.dgvLocalLicenses.RowTemplate.Height = 24;
            this.dgvLocalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(1172, 415);
            this.dgvLocalLicenses.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationsToolStripMenuItem,
            this.deleteApplicaitonToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.scToolStripMenuItem,
            this.toolStripSeparator4,
            this.issueDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(437, 344);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showApplicationDetailsToolStripMenuItem.Image")));
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(433, 6);
            // 
            // editApplicationsToolStripMenuItem
            // 
            this.editApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationsToolStripMenuItem.Image")));
            this.editApplicationsToolStripMenuItem.Name = "editApplicationsToolStripMenuItem";
            this.editApplicationsToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.editApplicationsToolStripMenuItem.Text = "Edit Application";
            this.editApplicationsToolStripMenuItem.Click += new System.EventHandler(this.editApplicationsToolStripMenuItem_Click);
            // 
            // deleteApplicaitonToolStripMenuItem
            // 
            this.deleteApplicaitonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteApplicaitonToolStripMenuItem.Image")));
            this.deleteApplicaitonToolStripMenuItem.Name = "deleteApplicaitonToolStripMenuItem";
            this.deleteApplicaitonToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.deleteApplicaitonToolStripMenuItem.Text = "Delete Applicaiton";
            this.deleteApplicaitonToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicaitonToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(433, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(433, 6);
            // 
            // scToolStripMenuItem
            // 
            this.scToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionToolStripMenuItem,
            this.scheduleWrittingTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.scToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scToolStripMenuItem.Image")));
            this.scToolStripMenuItem.Name = "scToolStripMenuItem";
            this.scToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.scToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionToolStripMenuItem
            // 
            this.scheduleVisionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleVisionToolStripMenuItem.Image")));
            this.scheduleVisionToolStripMenuItem.Name = "scheduleVisionToolStripMenuItem";
            this.scheduleVisionToolStripMenuItem.Size = new System.Drawing.Size(316, 38);
            this.scheduleVisionToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionToolStripMenuItem_Click);
            // 
            // scheduleWrittingTestToolStripMenuItem
            // 
            this.scheduleWrittingTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleWrittingTestToolStripMenuItem.Image")));
            this.scheduleWrittingTestToolStripMenuItem.Name = "scheduleWrittingTestToolStripMenuItem";
            this.scheduleWrittingTestToolStripMenuItem.Size = new System.Drawing.Size(316, 38);
            this.scheduleWrittingTestToolStripMenuItem.Text = "Schedule Writing Test";
            this.scheduleWrittingTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittingTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleStreetTestToolStripMenuItem.Image")));
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(316, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(433, 6);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueDrivingLicenseToolStripMenuItem.Image")));
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(433, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(433, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(436, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(12, 329);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(141, 23);
            this.lbFilterBy.TabIndex = 3;
            this.lbFilterBy.Text = "Filter By : ";
            this.lbFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(157, 325);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(268, 30);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterBySearch
            // 
            this.txtFilterBySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterBySearch.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBySearch.Location = new System.Drawing.Point(429, 325);
            this.txtFilterBySearch.MaxLength = 14;
            this.txtFilterBySearch.Name = "txtFilterBySearch";
            this.txtFilterBySearch.Size = new System.Drawing.Size(292, 30);
            this.txtFilterBySearch.TabIndex = 5;
            this.txtFilterBySearch.TextChanged += new System.EventHandler(this.txtFilterBySearch_TextChanged);
            this.txtFilterBySearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBySearch_KeyPress);
            // 
            // btnAddNewLocalDrivingLicense
            // 
            this.btnAddNewLocalDrivingLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewLocalDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLocalDrivingLicense.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLocalDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewLocalDrivingLicense.Image")));
            this.btnAddNewLocalDrivingLicense.Location = new System.Drawing.Point(1097, 270);
            this.btnAddNewLocalDrivingLicense.Name = "btnAddNewLocalDrivingLicense";
            this.btnAddNewLocalDrivingLicense.Size = new System.Drawing.Size(87, 85);
            this.btnAddNewLocalDrivingLicense.TabIndex = 6;
            this.btnAddNewLocalDrivingLicense.UseVisualStyleBackColor = true;
            this.btnAddNewLocalDrivingLicense.Click += new System.EventHandler(this.btnAddNewLocalDrivingLicense_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(12, 792);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(130, 23);
            this.lbRecords.TabIndex = 7;
            this.lbRecords.Text = "# Records : ";
            this.lbRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecordsResult
            // 
            this.lbRecordsResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsResult.Location = new System.Drawing.Point(148, 792);
            this.lbRecordsResult.Name = "lbRecordsResult";
            this.lbRecordsResult.Size = new System.Drawing.Size(77, 23);
            this.lbRecordsResult.TabIndex = 8;
            this.lbRecordsResult.Text = "[???]";
            this.lbRecordsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(429, 325);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(292, 30);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1044, 782);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 42);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 830);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbRecordsResult);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btnAddNewLocalDrivingLicense);
            this.Controls.Add(this.txtFilterBySearch);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLocalLicenses);
            this.Controls.Add(this.lbLocalDrivingLicenseApplicationsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLocalDrivingLicenseApplicationsTitle;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterBySearch;
        private System.Windows.Forms.Button btnAddNewLocalDrivingLicense;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label lbRecordsResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicaitonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
    }
}