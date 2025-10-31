using DVLD_BusinessLayer;
using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.Services;
using DVLD_BusinessLayer.UserBL;
using DVLD_PresentationLayer.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_PresentationLayer.Users.uctrlAddNewUser;

namespace DVLD_PresentationLayer.Users
{

    public partial class frmAddNewUser : Form
    {
        #region Fields , Properties , Events and Enums
        private ClsUserBusinessLayer _userBL = new ClsUserBusinessLayer();
        private ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        public event Action<ClsUser> SavedUser;
        public event Action<ClsUser> UpdatedUser;
        private ClsUser _currentUser = null;
        private ClsPerson _CurrentPerson = null;

        public enum EnMode { Add = 1, Edit = 0 }
        public EnMode _formMode = EnMode.Add;
        #endregion

        #region Constructors
        public frmAddNewUser()
        {
            InitializeComponent();
            _formMode = EnMode.Add;
        }
        public frmAddNewUser(ClsUser user) : this()
        {
            _formMode = EnMode.Edit;
            _currentUser = user;
            lbFormTitle.Text = "Edit User";
            btnSave.Text = "Update";
        }
        private async void frmAddNewUser_Load(object sender, EventArgs e)
        {
            await Task.Yield();
            UpdateFormTitle();
            btnSave.Enabled = false;

            if (_formMode == EnMode.Edit && _currentUser != null)
            {
                btnSave.Enabled = true;
                await LoadInfo(_currentUser);
                return;
            }
            else
            {
                uctrlAddNewUser1.PersonChanged += (Person) =>
                {
                    btnSave.Enabled = true;
                    _CurrentPerson = Person;
                };
                return;
            }
                
        }

        #endregion

        #region Event Handlers
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (Owner is frmManageUsers ParentForm)
                await ParentForm.UpdateDataGridView();
            Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_formMode == EnMode.Add && await IsThisUserExists())
            {
                MessageBox.Show("⚠️ This person already exists in the system.",
                                "Invalid User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!CheckBeforeSave())
            {
                MessageBox.Show("⚠️ Please complete all login information before saving.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            string message = _formMode == EnMode.Add
                ? "Are you sure you want to add this user to the system?"
                : "Are you sure you want to update this user?";

            string caption = _formMode == EnMode.Add
                ? "Add New User"
                : "Update User";

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // 4. Perform action
            if (_formMode == EnMode.Add)
            {
                await AddUserAsync();
                SavedUser?.Invoke(_currentUser);
            }
            else
            {
                await UpdateUserAsync();
                UpdatedUser?.Invoke(_currentUser);
            }
        }
        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_formMode == EnMode.Add && _CurrentPerson == null)
            {
                MessageBox.Show("Please select or add a person first.",
                                "No Person Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (_formMode == EnMode.Add && await _userBL.FindUserByAsync(_CurrentPerson.PersonID))
            {
                MessageBox.Show("This person is already registered as a user.",
                                "Duplicate User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            tbcForUser.SelectedTab = tbpLoginInfo;
        }
        private void btnTogglePassword_Click(object sender, EventArgs e) => TogglePassword(btnTogglePassword, txtPassword);
        private void btnToggleConfirmPassword_Click(object sender, EventArgs e) => TogglePassword(btnToggleConfirmPassword, txtConfirmPassword);
        private void txtUserName_Leave(object sender, EventArgs e) => 
            ValidateInput(txtUserName, ClsUserValidateServices.UserNamePattern, ClsUserValidateServices.UserNameError);
        private void txtPassword_Leave(object sender, EventArgs e) => btnTogglePassword.Visible = ValidateInput(txtPassword, 
                                                                                                  ClsUserValidateServices.PasswordPattern,
                                                                                                  ClsUserValidateServices.PasswordError).Item1;
        private void txtPassword_Enter(object sender, EventArgs e) => btnTogglePassword.Visible = true;
        private void txtConfirmPassword_Leave(object sender, EventArgs e) =>
            btnToggleConfirmPassword.Visible = ValidateInput(txtConfirmPassword, ClsUserValidateServices.PasswordPattern,
                                                               "Confirm Password is required and must match password",
                                               string.Equals(txtConfirmPassword.Text, txtPassword.Text, StringComparison.Ordinal)).Item1;
        private void txtConfirmPassword_Enter(object sender, EventArgs e) => btnToggleConfirmPassword.Visible = true;
        private void tbcForUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(_formMode == EnMode.Add && e.TabPage == tbpLoginInfo)
            {
                var result = ValidateLoginInfoTabAsync();
                if (!result.Item1)
                {
                    MessageBox.Show(result.Item2, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true; 
                }
            }
        }
        private async void uctrlAddNewUser1_OnAddClicked(object sender, EventArgs e)
        {
            using (var AddNewPerson = new frmAddAndEditPerson())
            {
                AddNewPerson.ShowDialog();
                await uctrlAddNewUser1.LoadPersonInfoAsync(AddNewPerson.CurrentPerson);
            }
        }
        #endregion

        #region Private Methods
        private async Task AddUserAsync()
        {
            ClsUser NewUser = new ClsUser();
            NewUser = GetUserInfo();
            var success = await _userBL.AddNewUserAsync(NewUser);

            if(!success)
            {
                MessageBox.Show("Failed to add new user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentUser = NewUser;
            lbUserIDResult.Text = NewUser.UserID.ToString();

            MessageBox.Show($"User added successfully with User ID = {NewUser.UserID}", "Confirm Add New User", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

            if (MessageBox.Show("Do you need to add new user ?", "Asking For Add Anthor User", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                ResetForm();
            else
                Close();
        }
        private async Task UpdateUserAsync()
        {
            ClsUser UpdatedUser = GetUserInfo();
            UpdatedUser.UserID = _currentUser.UserID;
            var success = await _userBL.UpdateUserInfoAsync(UpdatedUser);

            if(!success)
            {
                MessageBox.Show("User updated failed", "Failed Updated User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentUser = UpdatedUser;
            btnSave.Enabled = false;
            MessageBox.Show("User updated successfully", "Confirm Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private ClsUser GetUserInfo() => new ClsUser
        {
                PersonID = _CurrentPerson.PersonID,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                IsActive = chbIsActive.Checked ? true : false,
        };
        private async Task<bool> IsThisUserExists() => await _userBL.FindUserByAsync(_CurrentPerson.PersonID);
        private void ResetForm()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            errorProvider1.Clear();

            lbUserIDResult.Text = "[???]";
            chbIsActive.Checked = true;
            tbcForUser.SelectedIndex = 0;
        }
        private void UpdateFormTitle() => Text = _formMode == EnMode.Add ? "Add New User" : "Edit User";
        private void TogglePassword(Button btnTogglePassword, TextBox txtPassword)
        {
            bool isHidden = txtPassword.PasswordChar == '*';
            txtPassword.PasswordChar = isHidden ? '\0' : '*';
            btnTogglePassword.Image = isHidden
                ? Properties.Resources.close_eye
                : Properties.Resources.view;
        }
        private (bool IsValid, string Message) ValidateInput(TextBox txt, string Pattern, string ErrorMessage, bool ExtraCondition = true)
        {
            bool isValid = !string.IsNullOrEmpty(txt.Text)
                           && ClsUserValidateServices.Validate(txt.Text, Pattern)
                           && ExtraCondition;
            if (!isValid)
            {
                errorProvider1.SetError(txt, ErrorMessage);
                txt.BackColor = Color.LightPink;
                return (false, ErrorMessage);
            }

            errorProvider1.SetError(txt, string.Empty);
            txt.BackColor = Color.White;
            return (true, string.Empty);
        }
        private (bool IsValid, string Message) ValidateLoginInfoTabAsync()
        {
            var person = uctrlAddNewUser1.CurrentPerson;
            if (person is null)
                return (false, "⚠️ Please select or add a person first.");
            if (_formMode == EnMode.Add)
            {
                bool exists = _userBL.FindUserBy(person.PersonID);
                if (exists)
                    return (false, "⚠️ This person is already registered as a user.");
            }
            return (true,string.Empty);
        }
        private void FoucsTabOfControl(Control Ctrl)
        {
            TabPage ParentTab = Ctrl.Parent as TabPage;
            if (ParentTab != null)
            {
                tbcForUser.SelectedTab = ParentTab;
            }
        }
        private bool CheckBeforeSave()
        {
            var validations = new List<(bool IsValid, string Error)>
            {
                ValidateInput(txtUserName, ClsUserValidateServices.UserNamePattern, "User Name is required"),
                ValidateInput(txtPassword, ClsUserValidateServices.PasswordPattern, "Password is required"),
                ValidateInput(txtConfirmPassword, ClsUserValidateServices.PasswordPattern,
                    "Confirm Password must match", txtConfirmPassword.Text == txtPassword.Text)
            };

            if (validations.Any(v => !v.IsValid))
            {
                var firstInvalid = validations.First(v => !v.IsValid);
                MessageBox.Show(firstInvalid.Error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private async Task LoadInfo(ClsUser UserInfo)
        {
            _CurrentPerson = await _PeopleBL.GetPersonByIDAsync(UserInfo.PersonID);
            await uctrlAddNewUser1.LoadPersonInfoAsync(_CurrentPerson);
            FillLoginInfoPage(UserInfo);
        }
        private void FillLoginInfoPage(ClsUser user)
        {
            lbUserIDResult.Text = user.UserID.ToString();
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtConfirmPassword.Text = user.Password;
            chbIsActive.Checked = user.IsActive ? true : false;
        }
        #endregion
    }
}

