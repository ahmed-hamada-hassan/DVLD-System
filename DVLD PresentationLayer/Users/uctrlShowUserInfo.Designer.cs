namespace DVLD_PresentationLayer.Users
{
    partial class uctrlShowUserInfo
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
            this.gbLoginInformation = new System.Windows.Forms.GroupBox();
            this.lbUserIDTitle = new System.Windows.Forms.Label();
            this.lbUserIDResult = new System.Windows.Forms.Label();
            this.lbUserNameResult = new System.Windows.Forms.Label();
            this.lbUserNameTitle = new System.Windows.Forms.Label();
            this.lbIsActiveResult = new System.Windows.Forms.Label();
            this.lbIsActiveTitle = new System.Windows.Forms.Label();
            this.uCtrlShowPersonInfo1 = new DVLD_PresentationLayer.People.UCtrlShowPersonInfo();
            this.gbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoginInformation
            // 
            this.gbLoginInformation.Controls.Add(this.lbIsActiveResult);
            this.gbLoginInformation.Controls.Add(this.lbIsActiveTitle);
            this.gbLoginInformation.Controls.Add(this.lbUserNameResult);
            this.gbLoginInformation.Controls.Add(this.lbUserNameTitle);
            this.gbLoginInformation.Controls.Add(this.lbUserIDResult);
            this.gbLoginInformation.Controls.Add(this.lbUserIDTitle);
            this.gbLoginInformation.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginInformation.Location = new System.Drawing.Point(3, 359);
            this.gbLoginInformation.Name = "gbLoginInformation";
            this.gbLoginInformation.Size = new System.Drawing.Size(1112, 98);
            this.gbLoginInformation.TabIndex = 1;
            this.gbLoginInformation.TabStop = false;
            this.gbLoginInformation.Text = "Login Information";
            // 
            // lbUserIDTitle
            // 
            this.lbUserIDTitle.Location = new System.Drawing.Point(119, 46);
            this.lbUserIDTitle.Name = "lbUserIDTitle";
            this.lbUserIDTitle.Size = new System.Drawing.Size(127, 26);
            this.lbUserIDTitle.TabIndex = 0;
            this.lbUserIDTitle.Text = "User ID : ";
            this.lbUserIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserIDResult
            // 
            this.lbUserIDResult.Location = new System.Drawing.Point(210, 46);
            this.lbUserIDResult.Name = "lbUserIDResult";
            this.lbUserIDResult.Size = new System.Drawing.Size(127, 26);
            this.lbUserIDResult.TabIndex = 1;
            this.lbUserIDResult.Text = "[???]";
            this.lbUserIDResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserNameResult
            // 
            this.lbUserNameResult.Location = new System.Drawing.Point(556, 46);
            this.lbUserNameResult.Name = "lbUserNameResult";
            this.lbUserNameResult.Size = new System.Drawing.Size(127, 26);
            this.lbUserNameResult.TabIndex = 3;
            this.lbUserNameResult.Text = "[???]";
            this.lbUserNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserNameTitle
            // 
            this.lbUserNameTitle.Location = new System.Drawing.Point(442, 46);
            this.lbUserNameTitle.Name = "lbUserNameTitle";
            this.lbUserNameTitle.Size = new System.Drawing.Size(127, 26);
            this.lbUserNameTitle.TabIndex = 2;
            this.lbUserNameTitle.Text = "User Name : ";
            this.lbUserNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIsActiveResult
            // 
            this.lbIsActiveResult.Location = new System.Drawing.Point(918, 46);
            this.lbIsActiveResult.Name = "lbIsActiveResult";
            this.lbIsActiveResult.Size = new System.Drawing.Size(127, 26);
            this.lbIsActiveResult.TabIndex = 5;
            this.lbIsActiveResult.Text = "[???]";
            this.lbIsActiveResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIsActiveTitle
            // 
            this.lbIsActiveTitle.Location = new System.Drawing.Point(804, 46);
            this.lbIsActiveTitle.Name = "lbIsActiveTitle";
            this.lbIsActiveTitle.Size = new System.Drawing.Size(127, 26);
            this.lbIsActiveTitle.TabIndex = 4;
            this.lbIsActiveTitle.Text = "Is Active : ";
            this.lbIsActiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uCtrlShowPersonInfo1
            // 
            this.uCtrlShowPersonInfo1.Location = new System.Drawing.Point(3, 3);
            this.uCtrlShowPersonInfo1.Name = "uCtrlShowPersonInfo1";
            this.uCtrlShowPersonInfo1.Size = new System.Drawing.Size(1112, 350);
            this.uCtrlShowPersonInfo1.TabIndex = 0;
            // 
            // uctrlShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLoginInformation);
            this.Controls.Add(this.uCtrlShowPersonInfo1);
            this.Name = "uctrlShowUserInfo";
            this.Size = new System.Drawing.Size(1120, 460);
            this.gbLoginInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private People.UCtrlShowPersonInfo uCtrlShowPersonInfo1;
        private System.Windows.Forms.GroupBox gbLoginInformation;
        private System.Windows.Forms.Label lbUserIDTitle;
        private System.Windows.Forms.Label lbIsActiveResult;
        private System.Windows.Forms.Label lbIsActiveTitle;
        private System.Windows.Forms.Label lbUserNameResult;
        private System.Windows.Forms.Label lbUserNameTitle;
        private System.Windows.Forms.Label lbUserIDResult;
    }
}
