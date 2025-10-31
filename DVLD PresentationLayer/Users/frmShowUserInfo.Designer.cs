namespace DVLD_PresentationLayer.Users
{
    partial class frmShowUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUserInfo));
            this.button1 = new System.Windows.Forms.Button();
            this.uctrlShowUserInfo1 = new DVLD_PresentationLayer.Users.uctrlShowUserInfo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1009, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uctrlShowUserInfo1
            // 
            this.uctrlShowUserInfo1.Location = new System.Drawing.Point(12, 12);
            this.uctrlShowUserInfo1.Name = "uctrlShowUserInfo1";
            this.uctrlShowUserInfo1.Size = new System.Drawing.Size(1120, 460);
            this.uctrlShowUserInfo1.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uctrlShowUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show User Info";
            this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uctrlShowUserInfo uctrlShowUserInfo1;
        private System.Windows.Forms.Button button1;
    }
}