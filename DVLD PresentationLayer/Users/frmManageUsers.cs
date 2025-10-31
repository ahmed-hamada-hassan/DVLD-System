using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.UserBL;
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
    public partial class frmManageUsers : Form
    {
        private readonly ClsUserBusinessLayer _userBL = new ClsUserBusinessLayer();
        private readonly Dictionary<byte, string> _Columns = new Dictionary<byte, string>()
        {
            { 1 , "UserID" },
            { 2 , "PersonID" },
            { 3 , "FullName" },
            { 4 , "UserName" },
            { 5 , "IsActive" }
        };
        public frmManageUsers()
        {
            InitializeComponent();

        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _PopulateFilterByComboBox();
        }

        #region Private Methods
        private void _ConfigureUserGridColumns()
        {
            dgvManageUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (dgvManageUsers.Columns.Contains("UserID"))
                dgvManageUsers.Columns["UserID"].HeaderText = "User ID";
            if (dgvManageUsers.Columns.Contains("PersonID"))
                dgvManageUsers.Columns["PersonID"].HeaderText = "Person ID";
            if (dgvManageUsers.Columns.Contains("FullName"))
                dgvManageUsers.Columns["FullName"].HeaderText = "Full Name";
            if (dgvManageUsers.Columns.Contains("UserName"))
                dgvManageUsers.Columns["UserName"].HeaderText = "User Name";
            if (dgvManageUsers.Columns.Contains("IsActive"))
                dgvManageUsers.Columns["IsActive"].HeaderText = "Is Active";
        }

        private async Task _CountRecordsAsync()
        {
            var Records = await _userBL.CountUserAsync();

            lbRecordsResult.Text = Records.ToString();
        }

        private void _PopulateFilterByComboBox()
        {
            cbFilterByUsers.Items.AddRange(new string[] { "None", "User ID", "Person ID", "Full Name", "User Name", "Is Active" });
            cbFilterByUsers.SelectedIndex = 0;
            txtSearch.Visible = false;
        }

        private void _PopulateIsActiveComboBox()
        {
            cbIsActiveChoices.Items.AddRange(new string[] { "All", "Yes", "No" });
            cbIsActiveChoices.SelectedIndex = 0;
        }

        private async Task _PopulateDataGridViewWithUsers()
        {
            dgvManageUsers.DataSource = null;
            var Users = await _userBL.GetUsersAsync();
            dgvManageUsers.DataSource = Users;
            _ConfigureUserGridColumns();
            lbRecordsResult.Text = Users.Count.ToString();
        }

        
        #endregion

        #region Private Event Hadelers
        private async void cbFilterByUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByUsers.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                cbIsActiveChoices.Visible = false;
                await _PopulateDataGridViewWithUsers();
                return;
            }
            if( cbFilterByUsers.SelectedIndex == 5)
            {
                txtSearch.Visible = false;
                cbIsActiveChoices.Visible = true;
                _PopulateIsActiveComboBox();
                return;
            }
            txtSearch.Clear();
            cbIsActiveChoices.Visible = false;
            txtSearch.Visible = true;

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string SelectedFilter = cbFilterByUsers.SelectedItem.ToString();

            if(SelectedFilter == "User ID" || SelectedFilter == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "Please enter digits only .");
                }
                else
                {
                    errorProvider1.SetError(txtSearch, string.Empty);
                }
            }
            else if (SelectedFilter == "Full Name")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "Please enter letters and spaces only");
                }
                else
                {
                    errorProvider1.SetError(txtSearch, string.Empty);
                }
            }
            else if (SelectedFilter == "User Name")
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "User Name can only contain letters, digits, '.' or '_'.");
                }
                else
                {
                    errorProvider1.SetError(txtSearch, string.Empty);
                }
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var Users = await _userBL.FilterUsersOrderByAsync(_Columns[(byte)cbFilterByUsers.SelectedIndex], txtSearch.Text.Trim());
            if (Users != null)
            {
                dgvManageUsers.DataSource = null;
                dgvManageUsers.DataSource = Users;
                lbRecordsResult.Text = Users.Count.ToString();
                return;
            }
        }

        private async void cbIsActiveChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbIsActiveChoices.SelectedIndex)
            {
                case 0:
                    await _PopulateDataGridViewWithUsers();
                    break;
                case 1:
                    dgvManageUsers.DataSource = null;
                    var ActiveUsers = await _userBL.FilterUsersOrderByActiveStatusAsync(1);
                    dgvManageUsers.DataSource = ActiveUsers;
                    lbRecordsResult.Text = ActiveUsers.Count.ToString();
                    break;
                case 2:
                    dgvManageUsers.DataSource = null;
                    var UnActiveUsers = await _userBL.FilterUsersOrderByActiveStatusAsync(0);
                    dgvManageUsers.DataSource = UnActiveUsers;
                    lbRecordsResult.Text = UnActiveUsers.Count.ToString();
                    break;
                default:
                    break;
            }
        }

        private  void btnAddNewUsers_Click(object sender, EventArgs e)
        {
            using (frmAddNewUser addNewUser = new frmAddNewUser())
            {
                addNewUser.Owner = this;
                addNewUser.SavedUser += async (NewUser) =>
                {
                    await _PopulateDataGridViewWithUsers();
                    await _CountRecordsAsync();
                };
                addNewUser.ShowDialog(this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageUsers.SelectedRows.Count > 0)
            {
                int UserID = (int)dgvManageUsers.SelectedRows[0].Cells[0].Value;
                ClsUser UserToUpdate = await _userBL.GetUserInfoByUserIDAsync(UserID);
                using (frmAddNewUser editNewUser = new frmAddNewUser(UserToUpdate))
                {
                    editNewUser.Owner = this;

                    editNewUser.UpdatedUser += async (UpdatedUser) =>
                    {
                        bool result = await _userBL.UpdateUserInfoAsync(UpdatedUser);

                        if (result)
                        {
                            await UpdateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };

                    editNewUser.ShowDialog();
                }
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddNewUser addNewUser = new frmAddNewUser())
            {
                addNewUser.Owner = this;
                addNewUser.SavedUser += async (NewUser) =>
                {
                    await _PopulateDataGridViewWithUsers();
                    await _CountRecordsAsync();
                };
                addNewUser.ShowDialog(this);
            }
        }

        private void showDetaislToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageUsers.SelectedRows.Count > 0)
            {
                int UserID = (int)dgvManageUsers.SelectedRows[0].Cells[0].Value;
                int PersonID = (int)dgvManageUsers.SelectedRows[0].Cells[1].Value;
                using (frmShowUserInfo ShowUserInfo = new frmShowUserInfo(PersonID, UserID))
                {
                    ShowUserInfo.ShowDialog();
                }
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageUsers.Rows.Count > 0)
            {
                int UserID = (int)dgvManageUsers.SelectedRows[0].Cells[0].Value;

                DialogResult result = MessageBox.Show($"Are you sure want to delete user with User ID = {UserID}", "Delete User", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (await _userBL.DeleteUserAsync(UserID))
                    {
                        MessageBox.Show("User deleted successfully", "Confirm Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await UpdateDataGridView();
                    }
                    else
                        MessageBox.Show("User deleted failed", "Delete User Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("User deleted canceled", "Delete User Canceled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public async Task UpdateDataGridView()
        {
            await _PopulateDataGridViewWithUsers();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageUsers.SelectedRows.Count > 0)
            {
                int UserID = (int)dgvManageUsers.SelectedRows[0].Cells[0].Value;
                int PersonID = (int)dgvManageUsers.SelectedRows[0].Cells[1].Value;
                using (frmChangePassword ShowUserInfo = new frmChangePassword(UserID, PersonID))
                {
                    ShowUserInfo.ShowDialog();
                }
            }
        }
    }
}
