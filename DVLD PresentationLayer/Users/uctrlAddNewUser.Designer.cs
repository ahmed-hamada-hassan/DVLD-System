namespace DVLD_PresentationLayer.Users
{
    partial class uctrlAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlAddNewUser));
            this.gpFilterBy = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uctrlShowPersonInfo = new DVLD_PresentationLayer.People.UCtrlShowPersonInfo();
            this.gpFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFilterBy
            // 
            this.gpFilterBy.Controls.Add(this.btnAdd);
            this.gpFilterBy.Controls.Add(this.btnSearch);
            this.gpFilterBy.Controls.Add(this.txtSearch);
            this.gpFilterBy.Controls.Add(this.cbFilterBy);
            this.gpFilterBy.Controls.Add(this.lbFilterBy);
            this.gpFilterBy.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFilterBy.Location = new System.Drawing.Point(8, 3);
            this.gpFilterBy.Name = "gpFilterBy";
            this.gpFilterBy.Size = new System.Drawing.Size(1116, 100);
            this.gpFilterBy.TabIndex = 4;
            this.gpFilterBy.TabStop = false;
            this.gpFilterBy.Text = "Filter";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(850, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 66);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(759, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 66);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(456, 38);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Visible = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(174, 38);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(266, 27);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Location = new System.Drawing.Point(43, 38);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(142, 30);
            this.lbFilterBy.TabIndex = 0;
            this.lbFilterBy.Text = "Find By : ";
            this.lbFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlShowPersonInfo
            // 
            this.uctrlShowPersonInfo.Location = new System.Drawing.Point(10, 109);
            this.uctrlShowPersonInfo.Name = "uctrlShowPersonInfo";
            this.uctrlShowPersonInfo.Size = new System.Drawing.Size(1112, 374);
            this.uctrlShowPersonInfo.TabIndex = 5;
            // 
            // uctrlAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uctrlShowPersonInfo);
            this.Controls.Add(this.gpFilterBy);
            this.Name = "uctrlAddNewUser";
            this.Size = new System.Drawing.Size(1129, 485);
            this.gpFilterBy.ResumeLayout(false);
            this.gpFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private People.UCtrlShowPersonInfo uctrlShowPersonInfo;
        private System.Windows.Forms.GroupBox gpFilterBy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
