using DVLD_BusinessLayer.Services;
using DVLD_BusinessLayer.UserBL;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmLoginScreen : Form
    {
        #region Fields
        private readonly ClsUserBusinessLayer _userBL = new ClsUserBusinessLayer();
        #endregion

        #region Constructor
        public frmLoginScreen()
        {
            InitializeComponent();
            if (Properties.Settings.Default.RememberMe)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                chkRememberMe.Checked = true;
            }
            KeyPreview = true;
        }
        #endregion

        #region Private Methods
        private void HandleRememberMe(string username)
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = username;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();
        }
        private void SetUILoading(bool isLoading)
        {
            if (isLoading)
            {
                btnLoginIN.Enabled = false;
                btnLoginIN.Text = "Authenticating...";
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                chkRememberMe.Enabled = false;
                this.UseWaitCursor = true;
            }
            else
            {
                btnLoginIN.Enabled = true;
                btnLoginIN.Text = "Login";
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                chkRememberMe.Enabled = true;
                this.UseWaitCursor = false;
            }
        }
        private void ValidatePassword(object sender)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrEmpty(txtPassword.Text) &&
                ClsUserValidateServices.Validate(txtPassword.Text, ClsUserValidateServices.PasswordPattern))
                {
                    errorProvider1.SetError(txtPassword, string.Empty);
                    txtPassword.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(txtPassword, ClsUserValidateServices.PasswordError);
                    txtPassword.BackColor = Color.LightPink;
                }
            }
        }
        private void TogglePassword(Button btn, TextBox txt)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
                btn.Image = Resources.close_eye;
            }
            else
            {
                txt.PasswordChar = '*';
                btn.Image = Resources.view;
            }
        }
        #endregion

        #region Form's Event Handlers
        private async void btnLoginIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsUser authenticatedUser = null;
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            SetUILoading(true);

            try
            {
                authenticatedUser = await _userBL.AuthenticateUserAsync(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A critical error occurred. Please contact support.\nError: {ex.Message}",
                                "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                SetUILoading(false);
            }

            if (authenticatedUser != null)
            {
                HandleRememberMe(username);
                Program.CurrentUser = authenticatedUser;

                this.Hide();
                frmMainScreen mainScreen = new frmMainScreen();
                mainScreen.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidateUserName(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrEmpty(txtUserName.Text) &&
                ClsUserValidateServices.Validate(txtUserName.Text, ClsUserValidateServices.UserNamePattern))
                {
                    errorProvider1.SetError(txtUserName, string.Empty);
                    txtUserName.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(txtUserName, ClsUserValidateServices.UserNameError);
                    txtUserName.BackColor = Color.LightPink;
                }
            }
        }
        private void btnToggleNewPassword_Click(object sender, EventArgs e)
        {
            TogglePassword(btnTogglePassword,txtPassword);
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            btnTogglePassword.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidatePassword(sender);
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!btnTogglePassword.Focused)
                btnTogglePassword.Visible = false;
        }
        private void btnTogglePassword_Leave(object sender, EventArgs e)
        {
            btnTogglePassword.Visible = false;
        }
        private void frmLoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginIN.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        #endregion

    }
}
