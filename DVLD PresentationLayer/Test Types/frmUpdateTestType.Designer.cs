namespace DVLD_PresentationLayer.Test_Types
{
    partial class frmUpdateTestType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateTestType));
            this.lbTitleUpdateTestType = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbIDResult = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleUpdateTestType
            // 
            this.lbTitleUpdateTestType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitleUpdateTestType.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleUpdateTestType.ForeColor = System.Drawing.Color.Red;
            this.lbTitleUpdateTestType.Location = new System.Drawing.Point(141, 9);
            this.lbTitleUpdateTestType.Name = "lbTitleUpdateTestType";
            this.lbTitleUpdateTestType.Size = new System.Drawing.Size(342, 51);
            this.lbTitleUpdateTestType.TabIndex = 0;
            this.lbTitleUpdateTestType.Text = "Update Test Type";
            this.lbTitleUpdateTestType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(12, 77);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 33);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID :";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIDResult
            // 
            this.lbIDResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDResult.Location = new System.Drawing.Point(168, 77);
            this.lbIDResult.Name = "lbIDResult";
            this.lbIDResult.Size = new System.Drawing.Size(81, 33);
            this.lbIDResult.TabIndex = 2;
            this.lbIDResult.Text = "[???]";
            this.lbIDResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFees
            // 
            this.lbFees.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Image = ((System.Drawing.Image)(resources.GetObject("lbFees.Image")));
            this.lbFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFees.Location = new System.Drawing.Point(12, 349);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(190, 56);
            this.lbFees.TabIndex = 5;
            this.lbFees.Text = "Fees :";
            this.lbFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Image = ((System.Drawing.Image)(resources.GetObject("lbDescription.Image")));
            this.lbDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDescription.Location = new System.Drawing.Point(12, 237);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(190, 56);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "Description :";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbTitle.Image")));
            this.lbTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitle.Location = new System.Drawing.Point(12, 125);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(190, 56);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Title :";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(208, 138);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(374, 30);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(208, 186);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(374, 158);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtFees
            // 
            this.txtFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFees.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Location = new System.Drawing.Point(208, 362);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(374, 30);
            this.txtFees.TabIndex = 8;
            this.txtFees.Leave += new System.EventHandler(this.txtFees_Leave);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(466, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 56);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(317, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbIDResult);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTitleUpdateTestType);
            this.Name = "frmUpdateTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Test Type";
            this.Load += new System.EventHandler(this.frmUpdateTestType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleUpdateTestType;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbIDResult;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}