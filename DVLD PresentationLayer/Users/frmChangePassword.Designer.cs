namespace DVLD_PresentationLayer.Users
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnToggleNewPassword = new System.Windows.Forms.Button();
            this.btnToggleConfirmPassword = new System.Windows.Forms.Button();
            this.btnToggleCurrentPassword = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uctrlShowUserInfo1 = new DVLD_PresentationLayer.Users.uctrlShowUserInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.Image = ((System.Drawing.Image)(resources.GetObject("lbCurrentPassword.Image")));
            this.lbCurrentPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCurrentPassword.Location = new System.Drawing.Point(12, 492);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(264, 41);
            this.lbCurrentPassword.TabIndex = 1;
            this.lbCurrentPassword.Text = "Current Password :";
            this.lbCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("lbNewPassword.Image")));
            this.lbNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNewPassword.Location = new System.Drawing.Point(12, 542);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(264, 41);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "New Password :";
            this.lbNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(298, 498);
            this.txtCurrentPassword.MaxLength = 20;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(264, 30);
            this.txtCurrentPassword.TabIndex = 4;
            this.txtCurrentPassword.Enter += new System.EventHandler(this.txtCurrentPassword_Enter);
            this.txtCurrentPassword.Leave += new System.EventHandler(this.txtCurrentPassword_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(298, 547);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(264, 30);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.Enter += new System.EventHandler(this.txtNewPassword_Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(298, 597);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(264, 30);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(972, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(972, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnToggleNewPassword
            // 
            this.btnToggleNewPassword.Image = global::DVLD_PresentationLayer.Properties.Resources.view;
            this.btnToggleNewPassword.Location = new System.Drawing.Point(591, 547);
            this.btnToggleNewPassword.Name = "btnToggleNewPassword";
            this.btnToggleNewPassword.Size = new System.Drawing.Size(39, 30);
            this.btnToggleNewPassword.TabIndex = 10;
            this.btnToggleNewPassword.UseVisualStyleBackColor = true;
            this.btnToggleNewPassword.Visible = false;
            this.btnToggleNewPassword.Click += new System.EventHandler(this.btnToggleNewPassword_Click);
            // 
            // btnToggleConfirmPassword
            // 
            this.btnToggleConfirmPassword.Image = global::DVLD_PresentationLayer.Properties.Resources.view;
            this.btnToggleConfirmPassword.Location = new System.Drawing.Point(591, 597);
            this.btnToggleConfirmPassword.Name = "btnToggleConfirmPassword";
            this.btnToggleConfirmPassword.Size = new System.Drawing.Size(39, 30);
            this.btnToggleConfirmPassword.TabIndex = 11;
            this.btnToggleConfirmPassword.UseVisualStyleBackColor = true;
            this.btnToggleConfirmPassword.Visible = false;
            this.btnToggleConfirmPassword.Click += new System.EventHandler(this.btnToggleConfirmPassword_Click);
            // 
            // btnToggleCurrentPassword
            // 
            this.btnToggleCurrentPassword.Image = global::DVLD_PresentationLayer.Properties.Resources.view;
            this.btnToggleCurrentPassword.Location = new System.Drawing.Point(591, 498);
            this.btnToggleCurrentPassword.Name = "btnToggleCurrentPassword";
            this.btnToggleCurrentPassword.Size = new System.Drawing.Size(39, 30);
            this.btnToggleCurrentPassword.TabIndex = 12;
            this.btnToggleCurrentPassword.UseVisualStyleBackColor = true;
            this.btnToggleCurrentPassword.Visible = false;
            this.btnToggleCurrentPassword.Click += new System.EventHandler(this.btnToggleCurrentPassword_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlShowUserInfo1
            // 
            this.uctrlShowUserInfo1.Location = new System.Drawing.Point(12, 12);
            this.uctrlShowUserInfo1.Name = "uctrlShowUserInfo1";
            this.uctrlShowUserInfo1.Size = new System.Drawing.Size(1120, 460);
            this.uctrlShowUserInfo1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 651);
            this.Controls.Add(this.btnToggleCurrentPassword);
            this.Controls.Add(this.btnToggleConfirmPassword);
            this.Controls.Add(this.btnToggleNewPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbCurrentPassword);
            this.Controls.Add(this.uctrlShowUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlShowUserInfo uctrlShowUserInfo1;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnToggleNewPassword;
        private System.Windows.Forms.Button btnToggleConfirmPassword;
        private System.Windows.Forms.Button btnToggleCurrentPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}