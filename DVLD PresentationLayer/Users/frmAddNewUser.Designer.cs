using System;

namespace DVLD_PresentationLayer.Users
{
    partial class frmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUser));
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.tbcForUser = new System.Windows.Forms.TabControl();
            this.tbpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.uctrlAddNewUser1 = new DVLD_PresentationLayer.Users.uctrlAddNewUser();
            this.tbpLoginInfo = new System.Windows.Forms.TabPage();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.btnToggleConfirmPassword = new System.Windows.Forms.Button();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserIDResult = new System.Windows.Forms.Label();
            this.lbUserIDTitle = new System.Windows.Forms.Label();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbcForUser.SuspendLayout();
            this.tbpPersonalInfo.SuspendLayout();
            this.tbpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFormTitle.Font = new System.Drawing.Font("JetBrains Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormTitle.Location = new System.Drawing.Point(304, 9);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(551, 48);
            this.lbFormTitle.TabIndex = 1;
            this.lbFormTitle.Text = "Add New User";
            this.lbFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcForUser
            // 
            this.tbcForUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbcForUser.Controls.Add(this.tbpPersonalInfo);
            this.tbcForUser.Controls.Add(this.tbpLoginInfo);
            this.tbcForUser.Location = new System.Drawing.Point(8, 60);
            this.tbcForUser.Name = "tbcForUser";
            this.tbcForUser.SelectedIndex = 0;
            this.tbcForUser.Size = new System.Drawing.Size(1142, 590);
            this.tbcForUser.TabIndex = 2;
            this.tbcForUser.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcForUser_Selecting);
            // 
            // tbpPersonalInfo
            // 
            this.tbpPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpPersonalInfo.Controls.Add(this.btnNext);
            this.tbpPersonalInfo.Controls.Add(this.uctrlAddNewUser1);
            this.tbpPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpPersonalInfo.Name = "tbpPersonalInfo";
            this.tbpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonalInfo.Size = new System.Drawing.Size(1134, 561);
            this.tbpPersonalInfo.TabIndex = 0;
            this.tbpPersonalInfo.Text = "Personal Info";
            this.tbpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(1001, 497);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uctrlAddNewUser1
            // 
            this.uctrlAddNewUser1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uctrlAddNewUser1.Location = new System.Drawing.Point(2, 6);
            this.uctrlAddNewUser1.Name = "uctrlAddNewUser1";
            this.uctrlAddNewUser1.Size = new System.Drawing.Size(1124, 485);
            this.uctrlAddNewUser1.TabIndex = 0;
            // 
            // tbpLoginInfo
            // 
            this.tbpLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpLoginInfo.Controls.Add(this.chbIsActive);
            this.tbpLoginInfo.Controls.Add(this.btnToggleConfirmPassword);
            this.tbpLoginInfo.Controls.Add(this.btnTogglePassword);
            this.tbpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tbpLoginInfo.Controls.Add(this.txtPassword);
            this.tbpLoginInfo.Controls.Add(this.txtUserName);
            this.tbpLoginInfo.Controls.Add(this.lbUserIDResult);
            this.tbpLoginInfo.Controls.Add(this.lbUserIDTitle);
            this.tbpLoginInfo.Controls.Add(this.lbConfirmPassword);
            this.tbpLoginInfo.Controls.Add(this.lbPassword);
            this.tbpLoginInfo.Controls.Add(this.lbUserName);
            this.tbpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tbpLoginInfo.Name = "tbpLoginInfo";
            this.tbpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoginInfo.Size = new System.Drawing.Size(1134, 561);
            this.tbpLoginInfo.TabIndex = 1;
            this.tbpLoginInfo.Text = "Login Info";
            this.tbpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chbIsActive
            // 
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsActive.Image = ((System.Drawing.Image)(resources.GetObject("chbIsActive.Image")));
            this.chbIsActive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbIsActive.Location = new System.Drawing.Point(534, 397);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(163, 34);
            this.chbIsActive.TabIndex = 10;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnToggleConfirmPassword
            // 
            this.btnToggleConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleConfirmPassword.Image = global::DVLD_PresentationLayer.Properties.Resources.view;
            this.btnToggleConfirmPassword.Location = new System.Drawing.Point(819, 350);
            this.btnToggleConfirmPassword.Name = "btnToggleConfirmPassword";
            this.btnToggleConfirmPassword.Size = new System.Drawing.Size(36, 30);
            this.btnToggleConfirmPassword.TabIndex = 9;
            this.btnToggleConfirmPassword.UseVisualStyleBackColor = true;
            this.btnToggleConfirmPassword.Visible = false;
            this.btnToggleConfirmPassword.Click += new System.EventHandler(this.btnToggleConfirmPassword_Click);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePassword.Image = global::DVLD_PresentationLayer.Properties.Resources.view;
            this.btnTogglePassword.Location = new System.Drawing.Point(819, 284);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(36, 30);
            this.btnTogglePassword.TabIndex = 8;
            this.btnTogglePassword.UseVisualStyleBackColor = true;
            this.btnTogglePassword.Visible = false;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(534, 350);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(321, 30);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(534, 284);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(321, 30);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(534, 218);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(321, 30);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lbUserIDResult
            // 
            this.lbUserIDResult.AutoSize = true;
            this.lbUserIDResult.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDResult.Location = new System.Drawing.Point(465, 156);
            this.lbUserIDResult.Name = "lbUserIDResult";
            this.lbUserIDResult.Size = new System.Drawing.Size(60, 22);
            this.lbUserIDResult.TabIndex = 4;
            this.lbUserIDResult.Text = "[???]";
            // 
            // lbUserIDTitle
            // 
            this.lbUserIDTitle.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUserIDTitle.Location = new System.Drawing.Point(259, 145);
            this.lbUserIDTitle.Name = "lbUserIDTitle";
            this.lbUserIDTitle.Size = new System.Drawing.Size(187, 44);
            this.lbUserIDTitle.TabIndex = 3;
            this.lbUserIDTitle.Text = "User\'s ID : ";
            this.lbUserIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("lbConfirmPassword.Image")));
            this.lbConfirmPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbConfirmPassword.Location = new System.Drawing.Point(259, 343);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(256, 44);
            this.lbConfirmPassword.TabIndex = 2;
            this.lbConfirmPassword.Text = "Confirm Password : ";
            this.lbConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Image = ((System.Drawing.Image)(resources.GetObject("lbPassword.Image")));
            this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPassword.Location = new System.Drawing.Point(259, 277);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(256, 44);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password : ";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Image = ((System.Drawing.Image)(resources.GetObject("lbUserName.Image")));
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUserName.Location = new System.Drawing.Point(259, 211);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(256, 44);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name : ";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(1014, 656);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(865, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 712);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbcForUser);
            this.Controls.Add(this.lbFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tbcForUser.ResumeLayout(false);
            this.tbpPersonalInfo.ResumeLayout(false);
            this.tbpLoginInfo.ResumeLayout(false);
            this.tbpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.TabControl tbcForUser;
        private System.Windows.Forms.TabPage tbpPersonalInfo;
        private uctrlAddNewUser uctrlAddNewUser1;
        private System.Windows.Forms.TabPage tbpLoginInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbUserIDTitle;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserIDResult;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnToggleConfirmPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chbIsActive;
    }
}