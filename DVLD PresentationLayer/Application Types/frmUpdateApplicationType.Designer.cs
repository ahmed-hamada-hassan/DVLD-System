namespace DVLD_PresentationLayer.Applications
{
    partial class frmUpdateApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateApplicationType));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbIDTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbIDResult = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(55, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(475, 41);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Update Application Type";
            // 
            // lbIDTitle
            // 
            this.lbIDTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTitle.Location = new System.Drawing.Point(55, 80);
            this.lbIDTitle.Name = "lbIDTitle";
            this.lbIDTitle.Size = new System.Drawing.Size(125, 23);
            this.lbIDTitle.TabIndex = 1;
            this.lbIDTitle.Text = "ID : ";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Image = ((System.Drawing.Image)(resources.GetObject("lbName.Image")));
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbName.Location = new System.Drawing.Point(55, 122);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(125, 31);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Title : ";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFees
            // 
            this.lbFees.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Image = ((System.Drawing.Image)(resources.GetObject("lbFees.Image")));
            this.lbFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFees.Location = new System.Drawing.Point(55, 168);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(125, 31);
            this.lbFees.TabIndex = 3;
            this.lbFees.Text = "Fees : ";
            this.lbFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIDResult
            // 
            this.lbIDResult.AutoSize = true;
            this.lbIDResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDResult.Location = new System.Drawing.Point(201, 80);
            this.lbIDResult.Name = "lbIDResult";
            this.lbIDResult.Size = new System.Drawing.Size(60, 22);
            this.lbIDResult.TabIndex = 4;
            this.lbIDResult.Text = "[???]";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(201, 122);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(312, 30);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtFees
            // 
            this.txtFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFees.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Location = new System.Drawing.Point(201, 170);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(312, 30);
            this.txtFees.TabIndex = 6;
            this.txtFees.Leave += new System.EventHandler(this.txtFees_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(396, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 55);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(258, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 55);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbIDResult);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbIDTitle);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.frmUpdateApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbIDTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbIDResult;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}