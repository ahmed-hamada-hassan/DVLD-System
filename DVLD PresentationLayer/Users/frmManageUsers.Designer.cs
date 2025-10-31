namespace DVLD_PresentationLayer.Users
{
    partial class frmManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.lbTitleManageUsers = new System.Windows.Forms.Label();
            this.dgvManageUsers = new System.Windows.Forms.DataGridView();
            this.cmsManageUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetaislToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.cbFilterByUsers = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbRecordsTitle = new System.Windows.Forms.Label();
            this.lbRecordsResult = new System.Windows.Forms.Label();
            this.btnAddNewUsers = new System.Windows.Forms.Button();
            this.pbManageUsers = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbIsActiveChoices = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).BeginInit();
            this.cmsManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleManageUsers
            // 
            this.lbTitleManageUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitleManageUsers.AutoSize = true;
            this.lbTitleManageUsers.Font = new System.Drawing.Font("JetBrains Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleManageUsers.Location = new System.Drawing.Point(330, 240);
            this.lbTitleManageUsers.Name = "lbTitleManageUsers";
            this.lbTitleManageUsers.Size = new System.Drawing.Size(259, 44);
            this.lbTitleManageUsers.TabIndex = 1;
            this.lbTitleManageUsers.Text = "Manage Users";
            // 
            // dgvManageUsers
            // 
            this.dgvManageUsers.AllowUserToAddRows = false;
            this.dgvManageUsers.AllowUserToDeleteRows = false;
            this.dgvManageUsers.AllowUserToOrderColumns = true;
            this.dgvManageUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManageUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageUsers.ContextMenuStrip = this.cmsManageUsers;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageUsers.Location = new System.Drawing.Point(12, 333);
            this.dgvManageUsers.MultiSelect = false;
            this.dgvManageUsers.Name = "dgvManageUsers";
            this.dgvManageUsers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageUsers.RowHeadersWidth = 51;
            this.dgvManageUsers.RowTemplate.Height = 24;
            this.dgvManageUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageUsers.Size = new System.Drawing.Size(910, 358);
            this.dgvManageUsers.TabIndex = 2;
            // 
            // cmsManageUsers
            // 
            this.cmsManageUsers.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageUsers.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsManageUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetaislToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsManageUsers.Name = "cmsManageUsers";
            this.cmsManageUsers.Size = new System.Drawing.Size(247, 282);
            // 
            // showDetaislToolStripMenuItem
            // 
            this.showDetaislToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetaislToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetaislToolStripMenuItem.Image")));
            this.showDetaislToolStripMenuItem.Name = "showDetaislToolStripMenuItem";
            this.showDetaislToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.showDetaislToolStripMenuItem.Text = "Show Details";
            this.showDetaislToolStripMenuItem.Click += new System.EventHandler(this.showDetaislToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserToolStripMenuItem.Image")));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(12, 296);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(141, 27);
            this.lbFilterBy.TabIndex = 3;
            this.lbFilterBy.Text = "Filter By : ";
            this.lbFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterByUsers
            // 
            this.cbFilterByUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByUsers.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByUsers.FormattingEnabled = true;
            this.cbFilterByUsers.Location = new System.Drawing.Point(144, 296);
            this.cbFilterByUsers.Name = "cbFilterByUsers";
            this.cbFilterByUsers.Size = new System.Drawing.Size(219, 27);
            this.cbFilterByUsers.TabIndex = 4;
            this.cbFilterByUsers.SelectedIndexChanged += new System.EventHandler(this.cbFilterByUsers_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(369, 296);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lbRecordsTitle
            // 
            this.lbRecordsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordsTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsTitle.Location = new System.Drawing.Point(12, 709);
            this.lbRecordsTitle.Name = "lbRecordsTitle";
            this.lbRecordsTitle.Size = new System.Drawing.Size(141, 34);
            this.lbRecordsTitle.TabIndex = 7;
            this.lbRecordsTitle.Text = "# Records : ";
            this.lbRecordsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecordsResult
            // 
            this.lbRecordsResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordsResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsResult.Location = new System.Drawing.Point(144, 709);
            this.lbRecordsResult.Name = "lbRecordsResult";
            this.lbRecordsResult.Size = new System.Drawing.Size(127, 34);
            this.lbRecordsResult.TabIndex = 8;
            this.lbRecordsResult.Text = "??";
            this.lbRecordsResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddNewUsers
            // 
            this.btnAddNewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUsers.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUsers.Image")));
            this.btnAddNewUsers.Location = new System.Drawing.Point(819, 228);
            this.btnAddNewUsers.Name = "btnAddNewUsers";
            this.btnAddNewUsers.Size = new System.Drawing.Size(103, 95);
            this.btnAddNewUsers.TabIndex = 6;
            this.btnAddNewUsers.UseVisualStyleBackColor = true;
            this.btnAddNewUsers.Click += new System.EventHandler(this.btnAddNewUsers_Click);
            // 
            // pbManageUsers
            // 
            this.pbManageUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("pbManageUsers.Image")));
            this.pbManageUsers.Location = new System.Drawing.Point(325, 12);
            this.pbManageUsers.Name = "pbManageUsers";
            this.pbManageUsers.Size = new System.Drawing.Size(269, 213);
            this.pbManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageUsers.TabIndex = 0;
            this.pbManageUsers.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbIsActiveChoices
            // 
            this.cbIsActiveChoices.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActiveChoices.FormattingEnabled = true;
            this.cbIsActiveChoices.Location = new System.Drawing.Point(369, 296);
            this.cbIsActiveChoices.Name = "cbIsActiveChoices";
            this.cbIsActiveChoices.Size = new System.Drawing.Size(245, 27);
            this.cbIsActiveChoices.TabIndex = 9;
            this.cbIsActiveChoices.Visible = false;
            this.cbIsActiveChoices.SelectedIndexChanged += new System.EventHandler(this.cbIsActiveChoices_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(798, 697);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 58);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 759);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbIsActiveChoices);
            this.Controls.Add(this.lbRecordsResult);
            this.Controls.Add(this.lbRecordsTitle);
            this.Controls.Add(this.btnAddNewUsers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbFilterByUsers);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.dgvManageUsers);
            this.Controls.Add(this.lbTitleManageUsers);
            this.Controls.Add(this.pbManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).EndInit();
            this.cmsManageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManageUsers;
        private System.Windows.Forms.Label lbTitleManageUsers;
        private System.Windows.Forms.DataGridView dgvManageUsers;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterByUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNewUsers;
        private System.Windows.Forms.Label lbRecordsTitle;
        private System.Windows.Forms.Label lbRecordsResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbIsActiveChoices;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip cmsManageUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetaislToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}