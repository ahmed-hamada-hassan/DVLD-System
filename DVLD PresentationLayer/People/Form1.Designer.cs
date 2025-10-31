namespace DVLD_PresentationLayer.People
{
    partial class frmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsTitle = new System.Windows.Forms.Label();
            this.lbRecordsResult = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancelManagePeople = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.pbManagePeople = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbGenderType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.lbManagePeople.Font = new System.Drawing.Font("JetBrains Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lbManagePeople.Location = new System.Drawing.Point(521, 284);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(479, 55);
            this.lbManagePeople.TabIndex = 1;
            this.lbManagePeople.Text = "Manage People";
            this.lbManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(14, 379);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(171, 24);
            this.lbFilterBy.TabIndex = 3;
            this.lbFilterBy.Text = "Filter By :";
            this.lbFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(152, 376);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(262, 30);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsManagePeople;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(7, 412);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1502, 352);
            this.dataGridView1.TabIndex = 9;
            // 
            // cmsManagePeople
            // 
            this.cmsManagePeople.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmsManagePeople.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowDetails,
            this.toolStripSeparator1,
            this.cmsAddNewPerson,
            this.cmsEdit,
            this.cmsDelete,
            this.toolStripSeparator2,
            this.cmsSendEmail,
            this.cmsPhoneCall});
            this.cmsManagePeople.Name = "cmsManagePeople";
            this.cmsManagePeople.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsManagePeople.Size = new System.Drawing.Size(237, 244);
            // 
            // cmsShowDetails
            // 
            this.cmsShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("cmsShowDetails.Image")));
            this.cmsShowDetails.Name = "cmsShowDetails";
            this.cmsShowDetails.Size = new System.Drawing.Size(236, 38);
            this.cmsShowDetails.Text = "Show Details";
            this.cmsShowDetails.Click += new System.EventHandler(this.cmsShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // cmsAddNewPerson
            // 
            this.cmsAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("cmsAddNewPerson.Image")));
            this.cmsAddNewPerson.Name = "cmsAddNewPerson";
            this.cmsAddNewPerson.Size = new System.Drawing.Size(236, 38);
            this.cmsAddNewPerson.Text = "Add New Person";
            this.cmsAddNewPerson.Click += new System.EventHandler(this.cmsAddNewPerson_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Image = ((System.Drawing.Image)(resources.GetObject("cmsEdit.Image")));
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(236, 38);
            this.cmsEdit.Text = "Edit";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmsDelete.Image")));
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(236, 38);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // cmsSendEmail
            // 
            this.cmsSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("cmsSendEmail.Image")));
            this.cmsSendEmail.Name = "cmsSendEmail";
            this.cmsSendEmail.Size = new System.Drawing.Size(236, 38);
            this.cmsSendEmail.Text = "Send Email";
            // 
            // cmsPhoneCall
            // 
            this.cmsPhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("cmsPhoneCall.Image")));
            this.cmsPhoneCall.Name = "cmsPhoneCall";
            this.cmsPhoneCall.Size = new System.Drawing.Size(236, 38);
            this.cmsPhoneCall.Text = "Phone Call";
            // 
            // lbRecordsTitle
            // 
            this.lbRecordsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordsTitle.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsTitle.Location = new System.Drawing.Point(14, 785);
            this.lbRecordsTitle.Name = "lbRecordsTitle";
            this.lbRecordsTitle.Size = new System.Drawing.Size(171, 24);
            this.lbRecordsTitle.TabIndex = 10;
            this.lbRecordsTitle.Text = "# Records : ";
            // 
            // lbRecordsResult
            // 
            this.lbRecordsResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordsResult.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsResult.Location = new System.Drawing.Point(176, 785);
            this.lbRecordsResult.Name = "lbRecordsResult";
            this.lbRecordsResult.Size = new System.Drawing.Size(135, 24);
            this.lbRecordsResult.TabIndex = 11;
            this.lbRecordsResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(420, 376);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 30);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnCancelManagePeople
            // 
            this.btnCancelManagePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelManagePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelManagePeople.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelManagePeople.Image")));
            this.btnCancelManagePeople.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelManagePeople.Location = new System.Drawing.Point(1384, 770);
            this.btnCancelManagePeople.Name = "btnCancelManagePeople";
            this.btnCancelManagePeople.Size = new System.Drawing.Size(125, 55);
            this.btnCancelManagePeople.TabIndex = 12;
            this.btnCancelManagePeople.Text = "Cancel";
            this.btnCancelManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelManagePeople.UseVisualStyleBackColor = true;
            this.btnCancelManagePeople.Click += new System.EventHandler(this.btnCancelManagePeople_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.Image")));
            this.btnAddNewPerson.Location = new System.Drawing.Point(1384, 342);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(125, 64);
            this.btnAddNewPerson.TabIndex = 8;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // pbManagePeople
            // 
            this.pbManagePeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("pbManagePeople.Image")));
            this.pbManagePeople.Location = new System.Drawing.Point(521, 12);
            this.pbManagePeople.Name = "pbManagePeople";
            this.pbManagePeople.Size = new System.Drawing.Size(479, 269);
            this.pbManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManagePeople.TabIndex = 0;
            this.pbManagePeople.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbGenderType
            // 
            this.cbGenderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderType.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderType.FormattingEnabled = true;
            this.cbGenderType.Location = new System.Drawing.Point(420, 376);
            this.cbGenderType.Name = "cbGenderType";
            this.cbGenderType.Size = new System.Drawing.Size(262, 30);
            this.cbGenderType.TabIndex = 14;
            this.cbGenderType.SelectedIndexChanged += new System.EventHandler(this.cbGenderType_SelectedIndexChanged);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1521, 852);
            this.Controls.Add(this.cbGenderType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelManagePeople);
            this.Controls.Add(this.lbRecordsResult);
            this.Controls.Add(this.lbRecordsTitle);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pbManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManagePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManagePeople;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbRecordsTitle;
        private System.Windows.Forms.Label lbRecordsResult;
        private System.Windows.Forms.ContextMenuStrip cmsManagePeople;
        private System.Windows.Forms.ToolStripMenuItem cmsShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsPhoneCall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnCancelManagePeople;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbGenderType;
    }
}