using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Services;
using DVLD_BusinessLayer.UserBL;
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

namespace DVLD_PresentationLayer.Users
{
    public partial class frmChangePassword : Form
    {
        ClsUserBusinessLayer _UserBL = new ClsUserBusinessLayer();
        ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private ClsUser _CurrentUser = null;
        private int _UserID;
        private int _PersonID;

        public frmChangePassword(int userID , int personID)
        {
            InitializeComponent();
            _UserID = userID;
            _PersonID = personID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            PopulateUserInformation();
        }

        #region Private Methods
        private async Task<ClsPersonAndUserInfo> BringUserInfo(int userID,int personID)
        {
            var Person = await _PeopleBL.GetPersonByIDAsync(personID);
            var User = await _UserBL.GetUserInfoByUserIDAsync(userID);
            _CurrentUser = User;

            return new ClsPersonAndUserInfo(Person, User);
        }
        private async void PopulateUserInformation()
        {
            var Result = await BringUserInfo(_UserID, _PersonID);
            uctrlShowUserInfo1.LoadPersonAndUserInformation(Result.Person, Result.User);
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
        private void CheckTextBoxLeaveProperty(Control Ctrl, string Pattern, string error)
        {
            if (string.IsNullOrEmpty(Ctrl.Text))
            {
                ShowValidationError(Ctrl, "This field is required");
                return;
            }

            var validate = ClsUserValidateServices.Validate(Ctrl.Text, Pattern);
            if (!validate)
            {
                ShowValidationError(Ctrl, error);
                return;
            }

            ClearValidationError(Ctrl);
        }
        private void ClearValidationError(Control ctrl)
        {
            errorProvider1.SetError(ctrl, string.Empty);
            ctrl.BackColor = Color.White;
        }
        private void ShowValidationError(Control ctrl, string error)
        {
            errorProvider1.SetError(ctrl, error);
            ctrl.BackColor = Color.LightPink;
            ctrl.Focus();
        }
        private void ConfirmPasswordCheck(Control Ctrl)
        {
            if (string.IsNullOrEmpty(Ctrl.Text))
            {
                ShowValidationError(Ctrl, "This field is required");
                return;
            }

            var validate = ClsUserValidateServices.Validate(Ctrl.Text, ClsUserValidateServices.PasswordPattern);
            if (!validate)
            {
                ShowValidationError(Ctrl, ClsUserValidateServices.PasswordError);
                return;
            }

            if (!string.Equals(txtNewPassword.Text, Ctrl.Text, StringComparison.Ordinal))
            {
                ShowValidationError(Ctrl, "The password is different. It must match.");
                return;
            }
            ClearValidationError(Ctrl);
        }
        private bool IsFormValid()
        {
            bool isValid = true; 

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txtCurrentPassword, "Current Password is required.");
                isValid = false; 
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, ""); 
            }

            var newPassValidation = ClsUserValidateServices.ValidateField(
                txtNewPassword.Text,
                ClsUserValidateServices.PasswordPattern,
                ClsUserValidateServices.PasswordError,
                "New Password"
            );

            if (!newPassValidation.isValid)
            {
                errorProvider1.SetError(txtNewPassword, newPassValidation.errorMessage);
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Please confirm your new password.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }

            if (isValid && txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "New Password and Confirm Password do not match.");
                isValid = false;
            }

            if (isValid && txtCurrentPassword.Text == txtNewPassword.Text)
            {
                errorProvider1.SetError(txtNewPassword, "New password must be different from the old password.");
                isValid = false;
            }

            return isValid;
        }
        #endregion

        #region Envent Handlers
        private void btnToggleCurrentPassword_Click(object sender, EventArgs e)
        {
            TogglePassword(btnToggleCurrentPassword, txtCurrentPassword);
        }
        private void btnToggleNewPassword_Click(object sender, EventArgs e)
        {
            TogglePassword(btnToggleNewPassword, txtNewPassword);
        }
        private void btnToggleConfirmPassword_Click(object sender, EventArgs e)
        {
            TogglePassword(btnToggleConfirmPassword, txtConfirmPassword);
        }
        private void txtCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                ShowValidationError(txtCurrentPassword, "This field is required.");
            }
            else
            {
                ClearValidationError(txtCurrentPassword);
            }
        }
        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            CheckTextBoxLeaveProperty(txtNewPassword, ClsUserValidateServices.PasswordPattern, ClsUserValidateServices.PasswordError);
        }
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            ConfirmPasswordCheck(txtConfirmPassword);
        }
        private void txtCurrentPassword_Enter(object sender, EventArgs e)
        {
            btnToggleCurrentPassword.Visible = true;
        }
        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            btnToggleNewPassword.Visible = true;
        }
        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            btnToggleConfirmPassword.Visible = true;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                MessageBox.Show("Please correct the errors on the form.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult Result = MessageBox.Show("Are you sure you want to update your password?", "Updating Password",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
            {
                MessageBox.Show("Password update canceled.", "Canceled Update",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --- This is the new, secure call ---
            string oldPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;

            bool updateSuccess = await _UserBL.UpdatePasswordAsync(oldPassword, newPassword, _CurrentUser.UserID);

            if (updateSuccess)
            {
                MessageBox.Show("Password updated successfully.", "Successfully Updated",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
            {
                // The BLL returned false, which means the "Old Password" was wrong.
                MessageBox.Show("Your 'Old Password' was incorrect. Update failed.", "Invalid Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
