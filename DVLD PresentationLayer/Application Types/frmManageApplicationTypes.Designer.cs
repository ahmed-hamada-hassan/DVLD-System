namespace DVLD_PresentationLayer.Applications
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbManageApplicationTypes = new System.Windows.Forms.Label();
            this.dgvManageApplicationTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsTitle = new System.Windows.Forms.Label();
            this.lbRecordsResult = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbManageApplicationTypes
            // 
            this.lbManageApplicationTypes.AutoSize = true;
            this.lbManageApplicationTypes.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageApplicationTypes.Location = new System.Drawing.Point(120, 209);
            this.lbManageApplicationTypes.Name = "lbManageApplicationTypes";
            this.lbManageApplicationTypes.Size = new System.Drawing.Size(425, 37);
            this.lbManageApplicationTypes.TabIndex = 1;
            this.lbManageApplicationTypes.Text = "Manage Application Types";
            // 
            // dgvManageApplicationTypes
            // 
            this.dgvManageApplicationTypes.AllowUserToAddRows = false;
            this.dgvManageApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvManageApplicationTypes.AllowUserToOrderColumns = true;
            this.dgvManageApplicationTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvManageApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManageApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvManageApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvManageApplicationTypes.GridColor = System.Drawing.Color.Black;
            this.dgvManageApplicationTypes.Location = new System.Drawing.Point(18, 276);
            this.dgvManageApplicationTypes.MultiSelect = false;
            this.dgvManageApplicationTypes.Name = "dgvManageApplicationTypes";
            this.dgvManageApplicationTypes.ReadOnly = true;
            this.dgvManageApplicationTypes.RowHeadersWidth = 51;
            this.dgvManageApplicationTypes.RowTemplate.Height = 24;
            this.dgvManageApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageApplicationTypes.Size = new System.Drawing.Size(628, 293);
            this.dgvManageApplicationTypes.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 56);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationTypeToolStripMenuItem.Image")));
            this.editApplicationTypeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(249, 52);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // lbRecordsTitle
            // 
            this.lbRecordsTitle.AutoSize = true;
            this.lbRecordsTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsTitle.Location = new System.Drawing.Point(12, 589);
            this.lbRecordsTitle.Name = "lbRecordsTitle";
            this.lbRecordsTitle.Size = new System.Drawing.Size(130, 22);
            this.lbRecordsTitle.TabIndex = 3;
            this.lbRecordsTitle.Text = "# Records : ";
            // 
            // lbRecordsResult
            // 
            this.lbRecordsResult.AutoSize = true;
            this.lbRecordsResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsResult.Location = new System.Drawing.Point(137, 589);
            this.lbRecordsResult.Name = "lbRecordsResult";
            this.lbRecordsResult.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsResult.TabIndex = 4;
            this.lbRecordsResult.Text = "[???]";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(507, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 638);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbRecordsResult);
            this.Controls.Add(this.lbRecordsTitle);
            this.Controls.Add(this.dgvManageApplicationTypes);
            this.Controls.Add(this.lbManageApplicationTypes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbManageApplicationTypes;
        private System.Windows.Forms.DataGridView dgvManageApplicationTypes;
        private System.Windows.Forms.Label lbRecordsTitle;
        private System.Windows.Forms.Label lbRecordsResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}