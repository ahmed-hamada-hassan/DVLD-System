namespace DVLD_PresentationLayer.Test_Types
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            this.lbManageTestTypesTitle = new System.Windows.Forms.Label();
            this.dgvManageTestType = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsTitle = new System.Windows.Forms.Label();
            this.lbRecordsResult = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestType)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageTestTypesTitle
            // 
            this.lbManageTestTypesTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbManageTestTypesTitle.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageTestTypesTitle.Location = new System.Drawing.Point(247, 214);
            this.lbManageTestTypesTitle.Name = "lbManageTestTypesTitle";
            this.lbManageTestTypesTitle.Size = new System.Drawing.Size(296, 44);
            this.lbManageTestTypesTitle.TabIndex = 1;
            this.lbManageTestTypesTitle.Text = "Manage Test Type";
            // 
            // dgvManageTestType
            // 
            this.dgvManageTestType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageTestType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManageTestType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvManageTestType.BackgroundColor = System.Drawing.Color.White;
            this.dgvManageTestType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTestType.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageTestType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageTestType.GridColor = System.Drawing.Color.Black;
            this.dgvManageTestType.Location = new System.Drawing.Point(5, 276);
            this.dgvManageTestType.MultiSelect = false;
            this.dgvManageTestType.Name = "dgvManageTestType";
            this.dgvManageTestType.RowHeadersWidth = 51;
            this.dgvManageTestType.RowTemplate.Height = 24;
            this.dgvManageTestType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageTestType.Size = new System.Drawing.Size(789, 259);
            this.dgvManageTestType.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 42);
            // 
            // edToolStripMenuItem
            // 
            this.edToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("edToolStripMenuItem.Image")));
            this.edToolStripMenuItem.Name = "edToolStripMenuItem";
            this.edToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.edToolStripMenuItem.Text = "Edit Type Test";
            this.edToolStripMenuItem.Click += new System.EventHandler(this.edToolStripMenuItem_Click);
            // 
            // lbRecordsTitle
            // 
            this.lbRecordsTitle.AutoSize = true;
            this.lbRecordsTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsTitle.Location = new System.Drawing.Point(5, 556);
            this.lbRecordsTitle.Name = "lbRecordsTitle";
            this.lbRecordsTitle.Size = new System.Drawing.Size(130, 22);
            this.lbRecordsTitle.TabIndex = 3;
            this.lbRecordsTitle.Text = "# Records : ";
            // 
            // lbRecordsResult
            // 
            this.lbRecordsResult.AutoSize = true;
            this.lbRecordsResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsResult.Location = new System.Drawing.Point(129, 556);
            this.lbRecordsResult.Name = "lbRecordsResult";
            this.lbRecordsResult.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsResult.TabIndex = 4;
            this.lbRecordsResult.Text = "[???]";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(655, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 53);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbRecordsResult);
            this.Controls.Add(this.lbRecordsTitle);
            this.Controls.Add(this.dgvManageTestType);
            this.Controls.Add(this.lbManageTestTypesTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestType)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbManageTestTypesTitle;
        private System.Windows.Forms.DataGridView dgvManageTestType;
        private System.Windows.Forms.Label lbRecordsTitle;
        private System.Windows.Forms.Label lbRecordsResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem edToolStripMenuItem;
    }
}