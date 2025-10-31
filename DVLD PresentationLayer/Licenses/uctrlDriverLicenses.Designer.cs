namespace DVLD_PresentationLayer.Licenses
{
    partial class uctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlDriverLicenses));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbRecordsLocalResult = new System.Windows.Forms.Label();
            this.lbRecordsLocal = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbRecordsInternationalResult = new System.Windows.Forms.Label();
            this.lbRecordsInternational = new System.Windows.Forms.Label();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1285, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1273, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.lbRecordsLocalResult);
            this.tabPage1.Controls.Add(this.lbRecordsLocal);
            this.tabPage1.Controls.Add(this.dgvLocal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1265, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbRecordsLocalResult
            // 
            this.lbRecordsLocalResult.AutoSize = true;
            this.lbRecordsLocalResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsLocalResult.Location = new System.Drawing.Point(122, 279);
            this.lbRecordsLocalResult.Name = "lbRecordsLocalResult";
            this.lbRecordsLocalResult.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsLocalResult.TabIndex = 3;
            this.lbRecordsLocalResult.Text = "[???]";
            // 
            // lbRecordsLocal
            // 
            this.lbRecordsLocal.AutoSize = true;
            this.lbRecordsLocal.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsLocal.Location = new System.Drawing.Point(6, 279);
            this.lbRecordsLocal.Name = "lbRecordsLocal";
            this.lbRecordsLocal.Size = new System.Drawing.Size(110, 22);
            this.lbRecordsLocal.TabIndex = 2;
            this.lbRecordsLocal.Text = "#Records :";
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AllowUserToDeleteRows = false;
            this.dgvLocal.AllowUserToOrderColumns = true;
            this.dgvLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLocal.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.ContextMenuStrip = this.cms;
            this.dgvLocal.GridColor = System.Drawing.Color.Black;
            this.dgvLocal.Location = new System.Drawing.Point(6, 39);
            this.dgvLocal.MultiSelect = false;
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.RowHeadersWidth = 51;
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocal.Size = new System.Drawing.Size(1251, 232);
            this.dgvLocal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local License History:";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.lbRecordsInternationalResult);
            this.tabPage2.Controls.Add(this.lbRecordsInternational);
            this.tabPage2.Controls.Add(this.dgvInternational);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1265, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbRecordsInternationalResult
            // 
            this.lbRecordsInternationalResult.AutoSize = true;
            this.lbRecordsInternationalResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsInternationalResult.Location = new System.Drawing.Point(122, 270);
            this.lbRecordsInternationalResult.Name = "lbRecordsInternationalResult";
            this.lbRecordsInternationalResult.Size = new System.Drawing.Size(60, 22);
            this.lbRecordsInternationalResult.TabIndex = 6;
            this.lbRecordsInternationalResult.Text = "[???]";
            // 
            // lbRecordsInternational
            // 
            this.lbRecordsInternational.AutoSize = true;
            this.lbRecordsInternational.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsInternational.Location = new System.Drawing.Point(6, 270);
            this.lbRecordsInternational.Name = "lbRecordsInternational";
            this.lbRecordsInternational.Size = new System.Drawing.Size(110, 22);
            this.lbRecordsInternational.TabIndex = 5;
            this.lbRecordsInternational.Text = "#Records :";
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.AllowUserToDeleteRows = false;
            this.dgvInternational.AllowUserToOrderColumns = true;
            this.dgvInternational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInternational.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.ContextMenuStrip = this.cms;
            this.dgvInternational.GridColor = System.Drawing.Color.Black;
            this.dgvInternational.Location = new System.Drawing.Point(6, 34);
            this.dgvInternational.MultiSelect = false;
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.RowHeadersWidth = 51;
            this.dgvInternational.RowTemplate.Height = 24;
            this.dgvInternational.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternational.Size = new System.Drawing.Size(1251, 233);
            this.dgvInternational.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "International License History:";
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(279, 56);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(278, 52);
            this.showLicenseToolStripMenuItem.Text = "Show License Info";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // uctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1285, 384);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecordsLocal;
        private System.Windows.Forms.Label lbRecordsLocalResult;
        private System.Windows.Forms.Label lbRecordsInternationalResult;
        private System.Windows.Forms.Label lbRecordsInternational;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
    }
}
