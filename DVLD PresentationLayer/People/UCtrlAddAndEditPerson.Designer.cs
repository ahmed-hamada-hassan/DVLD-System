using System;

namespace DVLD_PresentationLayer.People
{
    partial class UCtrlAddAndEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCtrlAddAndEditPerson));
            this.lbPersonIDLabel = new System.Windows.Forms.Label();
            this.lbNA = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbThird = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLast = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.llbSetImage = new System.Windows.Forms.LinkLabel();
            this.llbRemove = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersonIDLabel
            // 
            this.lbPersonIDLabel.AutoSize = true;
            this.lbPersonIDLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbPersonIDLabel.Location = new System.Drawing.Point(23, 20);
            this.lbPersonIDLabel.Name = "lbPersonIDLabel";
            this.lbPersonIDLabel.Size = new System.Drawing.Size(156, 26);
            this.lbPersonIDLabel.TabIndex = 2;
            this.lbPersonIDLabel.Text = "Person ID : ";
            // 
            // lbNA
            // 
            this.lbNA.AutoSize = true;
            this.lbNA.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbNA.Location = new System.Drawing.Point(159, 20);
            this.lbNA.Name = "lbNA";
            this.lbNA.Size = new System.Drawing.Size(0, 26);
            this.lbNA.TabIndex = 3;
            // 
            // txtThirdName
            // 
            this.txtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtThirdName.Location = new System.Drawing.Point(731, 32);
            this.txtThirdName.MaxLength = 20;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(240, 30);
            this.txtThirdName.TabIndex = 7;
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnglishCharactersOnly_KeyPress);
            this.txtThirdName.Leave += new System.EventHandler(this.CheckTextBoxName);
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbSecond.Location = new System.Drawing.Point(559, 6);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(70, 22);
            this.lbSecond.TabIndex = 8;
            this.lbSecond.Text = "Second";
            // 
            // lbThird
            // 
            this.lbThird.AutoSize = true;
            this.lbThird.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbThird.Location = new System.Drawing.Point(821, 6);
            this.lbThird.Name = "lbThird";
            this.lbThird.Size = new System.Drawing.Size(60, 22);
            this.lbThird.TabIndex = 10;
            this.lbThird.Text = "Third";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtFirstName.Location = new System.Drawing.Point(217, 32);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 30);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnglishCharactersOnly_KeyPress);
            this.txtFirstName.Leave += new System.EventHandler(this.CheckTextBoxName);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtLastName.Location = new System.Drawing.Point(988, 32);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 30);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnglishCharactersOnly_KeyPress);
            this.txtLastName.Leave += new System.EventHandler(this.CheckTextBoxName);
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbFirst.Location = new System.Drawing.Point(307, 6);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(60, 22);
            this.lbFirst.TabIndex = 6;
            this.lbFirst.Text = "First";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbName.Image = ((System.Drawing.Image)(resources.GetObject("lbName.Image")));
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbName.Location = new System.Drawing.Point(14, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(186, 40);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name : ";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbLast.Location = new System.Drawing.Point(1083, 6);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(50, 22);
            this.lbLast.TabIndex = 12;
            this.lbLast.Text = "Last";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbNationalNo.Image = ((System.Drawing.Image)(resources.GetObject("lbNationalNo.Image")));
            this.lbNationalNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNationalNo.Location = new System.Drawing.Point(14, 95);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(186, 40);
            this.lbNationalNo.TabIndex = 13;
            this.lbNationalNo.Text = "National No : ";
            this.lbNationalNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalNo.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNationalNo.Location = new System.Drawing.Point(217, 102);
            this.txtNationalNo.MaxLength = 20;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(240, 30);
            this.txtNationalNo.TabIndex = 9;
            this.txtNationalNo.Leave += new System.EventHandler(this.CheckNationalNoTextBoxForAddingLeaveAsync);
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbDateOfBirth.Image = ((System.Drawing.Image)(resources.GetObject("lbDateOfBirth.Image")));
            this.lbDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDateOfBirth.Location = new System.Drawing.Point(474, 95);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(225, 40);
            this.lbDateOfBirth.TabIndex = 15;
            this.lbDateOfBirth.Text = "Date Of Birth : ";
            this.lbDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(731, 102);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(240, 30);
            this.dtpDateOfBirth.TabIndex = 10;
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 8, 10, 0, 0, 0, 0);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            // 
            // lbGender
            // 
            this.lbGender.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbGender.Image = ((System.Drawing.Image)(resources.GetObject("lbGender.Image")));
            this.lbGender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGender.Location = new System.Drawing.Point(14, 163);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(186, 40);
            this.lbGender.TabIndex = 17;
            this.lbGender.Text = "Gender : ";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMale.Location = new System.Drawing.Point(234, 172);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 23);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(354, 172);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(84, 23);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbPhone.Image = ((System.Drawing.Image)(resources.GetObject("lbPhone.Image")));
            this.lbPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPhone.Location = new System.Drawing.Point(474, 163);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(225, 40);
            this.lbPhone.TabIndex = 20;
            this.lbPhone.Text = "Phone : ";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPhone.Location = new System.Drawing.Point(731, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 30);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.Leave += new System.EventHandler(this.CheckPhoneTextBox);
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbEmail.Image = ((System.Drawing.Image)(resources.GetObject("lbEmail.Image")));
            this.lbEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbEmail.Location = new System.Drawing.Point(14, 231);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(186, 40);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "Email : ";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtEmail.Location = new System.Drawing.Point(217, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 30);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Leave += new System.EventHandler(this.CheckEmailTextBox);
            // 
            // lbCountry
            // 
            this.lbCountry.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbCountry.Image = ((System.Drawing.Image)(resources.GetObject("lbCountry.Image")));
            this.lbCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCountry.Location = new System.Drawing.Point(474, 231);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(225, 40);
            this.lbCountry.TabIndex = 24;
            this.lbCountry.Text = "Country : ";
            this.lbCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(731, 237);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(240, 30);
            this.cbCountry.TabIndex = 15;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbAddress.Image = ((System.Drawing.Image)(resources.GetObject("lbAddress.Image")));
            this.lbAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAddress.Location = new System.Drawing.Point(14, 342);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(186, 40);
            this.lbAddress.TabIndex = 26;
            this.lbAddress.Text = "Address : ";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAddress.Location = new System.Drawing.Point(217, 310);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(744, 104);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Leave += new System.EventHandler(this.CheckAddressTextBox);
            // 
            // llbSetImage
            // 
            this.llbSetImage.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbSetImage.Location = new System.Drawing.Point(999, 319);
            this.llbSetImage.Name = "llbSetImage";
            this.llbSetImage.Size = new System.Drawing.Size(219, 41);
            this.llbSetImage.TabIndex = 17;
            this.llbSetImage.TabStop = true;
            this.llbSetImage.Text = "Set Image";
            this.llbSetImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSetImage_LinkClicked);
            // 
            // llbRemove
            // 
            this.llbRemove.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.llbRemove.LinkColor = System.Drawing.Color.Red;
            this.llbRemove.Location = new System.Drawing.Point(999, 360);
            this.llbRemove.Name = "llbRemove";
            this.llbRemove.Size = new System.Drawing.Size(219, 41);
            this.llbRemove.TabIndex = 18;
            this.llbRemove.TabStop = true;
            this.llbRemove.Text = "Remove";
            this.llbRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbRemove.Visible = false;
            this.llbRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRemove_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.llbRemove);
            this.panel1.Controls.Add(this.llbSetImage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.lbDateOfBirth);
            this.panel1.Controls.Add(this.txtNationalNo);
            this.panel1.Controls.Add(this.lbNationalNo);
            this.panel1.Controls.Add(this.lbLast);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbFirst);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.lbThird);
            this.panel1.Controls.Add(this.lbSecond);
            this.panel1.Controls.Add(this.txtThirdName);
            this.panel1.Location = new System.Drawing.Point(27, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 460);
            this.panel1.TabIndex = 1;
            // 
            // txtSecondName
            // 
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtSecondName.Location = new System.Drawing.Point(474, 32);
            this.txtSecondName.MaxLength = 20;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(240, 30);
            this.txtSecondName.TabIndex = 6;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnglishCharactersOnly_KeyPress);
            this.txtSecondName.Leave += new System.EventHandler(this.CheckTextBoxName);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.male;
            this.pictureBox1.Location = new System.Drawing.Point(988, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UCtrlAddAndEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNA);
            this.Controls.Add(this.lbPersonIDLabel);
            this.Controls.Add(this.panel1);
            this.Name = "UCtrlAddAndEditPerson";
            this.Size = new System.Drawing.Size(1325, 545);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPersonIDLabel;
        private System.Windows.Forms.Label lbNA;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbThird;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llbSetImage;
        private System.Windows.Forms.LinkLabel llbRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
