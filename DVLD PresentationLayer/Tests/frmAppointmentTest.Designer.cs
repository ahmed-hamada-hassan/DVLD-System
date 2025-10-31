namespace DVLD_PresentationLayer.Tests
{
    partial class frmAppointmentTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentTest));
            this.lbScheduleTestName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAppointments = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.lbRecordsResult = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.uctrlApplicationAndApplicantInfo1 = new DVLD_PresentationLayer.Tests.uctrlApplicationAndApplicantInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScheduleTestName
            // 
            this.lbScheduleTestName.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScheduleTestName.ForeColor = System.Drawing.Color.Red;
            this.lbScheduleTestName.Location = new System.Drawing.Point(245, 135);
            this.lbScheduleTestName.Name = "lbScheduleTestName";
            this.lbScheduleTestName.Size = new System.Drawing.Size(514, 37);
            this.lbScheduleTestName.TabIndex = 2;
            this.lbScheduleTestName.Text = "Schedule Test Appointment";
            this.lbScheduleTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 606);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(971, 158);
            this.dataGridView1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 108);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(199, 52);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(199, 52);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // lbAppointments
            // 
            this.lbAppointments.AutoSize = true;
            this.lbAppointments.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointments.Location = new System.Drawing.Point(12, 566);
            this.lbAppointments.Name = "lbAppointments";
            this.lbAppointments.Size = new System.Drawing.Size(150, 22);
            this.lbAppointments.TabIndex = 5;
            this.lbAppointments.Text = "Appointments :";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(12, 782);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(110, 22);
            this.lbRecords.TabIndex = 6;
            this.lbRecords.Text = "#Records :";
            // 
            // lbRecordsResult
            // 
            this.lbRecordsResult.AutoSize = true;
            this.lbRecordsResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsResult.Location = new System.Drawing.Point(128, 782);
            this.lbRecordsResult.Name = "lbRecordsResult";
            this.lbRecordsResult.Size = new System.Drawing.Size(20, 22);
            this.lbRecordsResult.TabIndex = 7;
            this.lbRecordsResult.Text = "0";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.Location = new System.Drawing.Point(927, 557);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(56, 43);
            this.btnAddAppointment.TabIndex = 3;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Location = new System.Drawing.Point(337, 13);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(331, 114);
            this.pbTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestImage.TabIndex = 1;
            this.pbTestImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(849, 770);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 46);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uctrlApplicationAndApplicantInfo1
            // 
            this.uctrlApplicationAndApplicantInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uctrlApplicationAndApplicantInfo1.Location = new System.Drawing.Point(12, 182);
            this.uctrlApplicationAndApplicantInfo1.Name = "uctrlApplicationAndApplicantInfo1";
            this.uctrlApplicationAndApplicantInfo1.Size = new System.Drawing.Size(980, 369);
            this.uctrlApplicationAndApplicantInfo1.TabIndex = 0;
            this.uctrlApplicationAndApplicantInfo1.OnClickViewPersonInfo += new System.EventHandler(this.uctrlApplicationAndApplicantInfo1_OnClickViewPersonInfo);
            this.uctrlApplicationAndApplicantInfo1.OnClickShowLicenseInfo += new System.EventHandler(this.uctrlApplicationAndApplicantInfo1_OnClickShowLicenseInfo);
            // 
            // frmAppointmentTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 824);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbRecordsResult);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.lbAppointments);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lbScheduleTestName);
            this.Controls.Add(this.pbTestImage);
            this.Controls.Add(this.uctrlApplicationAndApplicantInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAppointmentTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAppointmentTest_FormClosing);
            this.Load += new System.EventHandler(this.frmAppointmentTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlApplicationAndApplicantInfo uctrlApplicationAndApplicantInfo1;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Label lbScheduleTestName;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbAppointments;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label lbRecordsResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
    }
}