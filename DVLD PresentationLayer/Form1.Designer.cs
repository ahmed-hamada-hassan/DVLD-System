namespace DVLD_PresentationLayer
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWelcomeMessage = new System.Windows.Forms.Label();
            this.pbLoginScreenImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.btnLoginIN = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbLoginTo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginScreenImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbWelcomeMessage);
            this.panel1.Controls.Add(this.pbLoginScreenImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 546);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Version 1.0";
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcomeMessage.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeMessage.ForeColor = System.Drawing.Color.White;
            this.lbWelcomeMessage.Location = new System.Drawing.Point(25, 290);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(379, 198);
            this.lbWelcomeMessage.TabIndex = 1;
            this.lbWelcomeMessage.Text = "Welcome To\r\nDRIVING && VEHICLE LICENSE DEPARTMENT \r\n(DVLD) SYSTEM\r\n";
            this.lbWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLoginScreenImage
            // 
            this.pbLoginScreenImage.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginScreenImage.Image")));
            this.pbLoginScreenImage.Location = new System.Drawing.Point(91, 25);
            this.pbLoginScreenImage.Name = "pbLoginScreenImage";
            this.pbLoginScreenImage.Size = new System.Drawing.Size(247, 248);
            this.pbLoginScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginScreenImage.TabIndex = 0;
            this.pbLoginScreenImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTogglePassword);
            this.panel2.Controls.Add(this.btnLoginIN);
            this.panel2.Controls.Add(this.chkRememberMe);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.lbPassword);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.lbLoginTo);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(448, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 546);
            this.panel2.TabIndex = 1;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePassword.Image = global::DVLD_PresentationLayer.Properties.Resources.view;
            this.btnTogglePassword.Location = new System.Drawing.Point(419, 260);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(39, 30);
            this.btnTogglePassword.TabIndex = 11;
            this.btnTogglePassword.UseVisualStyleBackColor = true;
            this.btnTogglePassword.Visible = false;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnToggleNewPassword_Click);
            this.btnTogglePassword.Leave += new System.EventHandler(this.btnTogglePassword_Leave);
            // 
            // btnLoginIN
            // 
            this.btnLoginIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginIN.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginIN.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginIN.Image")));
            this.btnLoginIN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoginIN.Location = new System.Drawing.Point(211, 346);
            this.btnLoginIN.Name = "btnLoginIN";
            this.btnLoginIN.Size = new System.Drawing.Size(247, 45);
            this.btnLoginIN.TabIndex = 7;
            this.btnLoginIN.Text = "Login In";
            this.btnLoginIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginIN.UseVisualStyleBackColor = true;
            this.btnLoginIN.Click += new System.EventHandler(this.btnLoginIN_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.Location = new System.Drawing.Point(211, 304);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(198, 30);
            this.chkRememberMe.TabIndex = 6;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(211, 260);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(247, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(211, 196);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 30);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Leave += new System.EventHandler(this.ValidateUserName);
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Image = ((System.Drawing.Image)(resources.GetObject("lbPassword.Image")));
            this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPassword.Location = new System.Drawing.Point(29, 252);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(176, 49);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password  : ";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Image = ((System.Drawing.Image)(resources.GetObject("lbUserName.Image")));
            this.lbUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUserName.Location = new System.Drawing.Point(29, 187);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(176, 49);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name : ";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLoginTo
            // 
            this.lbLoginTo.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginTo.Location = new System.Drawing.Point(63, 104);
            this.lbLoginTo.Name = "lbLoginTo";
            this.lbLoginTo.Size = new System.Drawing.Size(382, 40);
            this.lbLoginTo.TabIndex = 1;
            this.lbLoginTo.Text = "Login To Your Account";
            this.lbLoginTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(465, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(983, 546);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginScreenImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLoginScreenImage;
        private System.Windows.Forms.Label lbWelcomeMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbLoginTo;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnLoginIN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTogglePassword;
    }
}

