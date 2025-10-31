using DVLD_BusinessLayer;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.License_BL.International_License_BL;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmManageInternationalLicenseApplications : Form
    {

        #region Fields
        private readonly ClsInternationalLicensesBL _InternationalLicensesBL = new ClsInternationalLicensesBL();
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private readonly ClsLicensesBL _LicensesBL = new ClsLicensesBL();
        private readonly Dictionary<byte, string> _CbFilterByOptions = new Dictionary<byte, string>()
        { { 0 , "None" }, { 1, "InternationalLicenseID" }, {2,"DriverID" }, {3, "ApplicationID" },{4,"IssuedUsingLocalLicenseID" }, {5,"Status"} };
        #endregion

        #region Constructors
        public frmManageInternationalLicenseApplications()
        {
            InitializeComponent();
        }
        private void frmManageInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            _PopulateComboBoxFilterBy();
        }
        #endregion

        #region Private Methods
        private void _ConfigureListInternationalLicenseApplicationsDataGridView()
        {
            if (dgvInternationalLicenses.Columns.Contains("InternationalLicenseID"))
                dgvInternationalLicenses.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
            if (dgvInternationalLicenses.Columns.Contains("ApplicantionID"))
                dgvInternationalLicenses.Columns["ApplicantionID"].HeaderText = "Application ID";
            if (dgvInternationalLicenses.Columns.Contains("DriverID"))
                dgvInternationalLicenses.Columns["DriverID"].HeaderText = "Driver ID";
            if (dgvInternationalLicenses.Columns.Contains("IssuedUsingLocalLicenseID"))
                dgvInternationalLicenses.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
            if (dgvInternationalLicenses.Columns.Contains("IssueDate"))
                dgvInternationalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
            if (dgvInternationalLicenses.Columns.Contains("ExpirationDate"))
                dgvInternationalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            if (dgvInternationalLicenses.Columns.Contains("IsActive"))
                dgvInternationalLicenses.Columns["IsActive"].HeaderText = "Is Active";
        }
        private List<object> _CostmizeListToViewIt(List<ClsInternationalLicense> InternationalLicenses)
        {
            if (InternationalLicenses == null || InternationalLicenses.Count == 0) return null;

            return InternationalLicenses.Select(X => new
            {
                X.InternationalLicenseID,
                X.ApplicantionID,
                X.DriverID,
                X.IssuedUsingLocalLicenseID,
                X.IssueDate,
                X.ExpirationDate,
                X.IsActive
            }).ToList<object>();
        }
        private async Task _PopulateListInternationalLicenseApplicationsDataGridView()
        {
            var InternationalLicenses = await _InternationalLicensesBL.GetAllInternationalLicensesAsync();
            dgvInternationalLicenses.DataSource = _CostmizeListToViewIt(InternationalLicenses);
            _ConfigureListInternationalLicenseApplicationsDataGridView();
            lbRecordsResult.Text = InternationalLicenses.Count.ToString();
        }
        private void _PopulateComboBoxFilterBy()
        {
            cbFilterBy.Items.AddRange(new string[] { "None", "Int.License ID", "Driver ID", "APP.ID", "L.License ID", "Status" });
            cbFilterBy.SelectedIndex = 0;
            txtFilterBySearch.Visible = false;
            cbActive.Visible = false;
        }
        private void _PopulateComboBoxActive()
        {
            cbActive.Items.Clear();
            cbActive.Items.AddRange(new string[] { "None", "Active", "UnActive" });
            cbActive.SelectedIndex = 0;
        }
        private void _SetErrors(Control CTRL, string Message)
        {
            errorProvider1.SetError(CTRL, Message);
        }
        private void _DeleteErrors(Control CTRL)
        {
            errorProvider1.SetError(CTRL, string.Empty);
        }
        #endregion

        #region Form's Event Handlers
        private async void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                cbActive.Visible = false;
                txtFilterBySearch.Visible = false;
                await _PopulateListInternationalLicenseApplicationsDataGridView();
                return;
            }
            else
            {
                if (cbFilterBy.SelectedIndex == 5)
                {
                    cbActive.Visible = true;
                    txtFilterBySearch.Visible = false;
                    _PopulateComboBoxActive();
                    return;
                }
                else
                {
                    cbActive.Visible = false;
                    txtFilterBySearch.Visible = true;
                    return;
                }
            }
        }
        private void txtFilterBySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string SelectedFilter = cbFilterBy.SelectedItem.ToString();

            if (SelectedFilter == "Int.License ID" || SelectedFilter == "Driver ID" || SelectedFilter == "APP.ID" || SelectedFilter == "L.License ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    _SetErrors(txtFilterBySearch, "Please enter digits only.");
                    return;
                }
                else
                {
                    _DeleteErrors(txtFilterBySearch);
                    return;
                }
            }
        }
        private async void txtFilterBySearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilterBySearch.Text))
            {
                var InternationalLicenses = await _InternationalLicensesBL.
                    FilterInternationalLicensesAccordingByAsync(_CbFilterByOptions[(byte)cbFilterBy.SelectedIndex], txtFilterBySearch.Text);
                dgvInternationalLicenses.DataSource = _CostmizeListToViewIt(InternationalLicenses);
                _ConfigureListInternationalLicenseApplicationsDataGridView();
                lbRecordsResult.Text = InternationalLicenses.Count.ToString();
                return;
            }
            await _PopulateListInternationalLicenseApplicationsDataGridView();
        }
        private async void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActive.SelectedIndex == 1)
            {
                var InternationalLicenses = await _InternationalLicensesBL.FilterInternationalLicensesByActiveStatusAsync(true);
                dgvInternationalLicenses.DataSource = _CostmizeListToViewIt(InternationalLicenses);
                _ConfigureListInternationalLicenseApplicationsDataGridView();
                lbRecordsResult.Text = InternationalLicenses.Count.ToString();
                return;
            }
            else if (cbActive.SelectedIndex == 2)
            {
                var InternationalLicenses = await _InternationalLicensesBL.FilterInternationalLicensesByActiveStatusAsync(false);
                dgvInternationalLicenses.DataSource = _CostmizeListToViewIt(InternationalLicenses);
                _ConfigureListInternationalLicenseApplicationsDataGridView();
                lbRecordsResult.Text = InternationalLicenses.Count.ToString();
                return;
            }
            else
            {
                await _PopulateListInternationalLicenseApplicationsDataGridView();
                return;
            }
        }
        private async void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.SelectedRows.Count > 0)
            {
                int DriverID = Convert.ToInt32(dgvInternationalLicenses.SelectedRows[0].Cells[2].Value);
                var Person = await _PeopleBL.GetPersonInfoByDriverIDAsync(DriverID);
                using (var ShowPersonDetails = new frmShowPersonDetails(Person.PersonID))
                {
                    ShowPersonDetails.Owner = this;
                    ShowPersonDetails.ShowDialog();
                }
            }
        }
        private async void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.SelectedRows.Count > 0)
            {
                int InternationalLicenseID = Convert.ToInt32(dgvInternationalLicenses.SelectedRows[0].Cells[0].Value);
                var InternationalLicenseInfo = await _InternationalLicensesBL.GetInternationalLicenseInfoByInternationalLicenseIDAsync(InternationalLicenseID);
                using (var ShowInternationalLicenseInfo = new frmShowDriverInternationalLicenseInfo(InternationalLicenseInfo))
                {
                    ShowInternationalLicenseInfo.ShowDialog();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.SelectedRows.Count > 0)
            {

                var DriverID = Convert.ToInt32(dgvInternationalLicenses.SelectedRows[0].Cells[2].Value);
                var LicenseHistory = await _LicensesBL.GetLicensesByDriverIDAsync(DriverID);
                using (var ShowLicenseHistory = new frmShowLicenseHistory(LicenseHistory))
                {
                    ShowLicenseHistory.ShowDialog();
                }
            }
        }
        #endregion

        private void btnAddNewInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            using (var NewInternationalLicenseApplicationForm = new frmNewInternationalLicenseApplication())
            {
                NewInternationalLicenseApplicationForm.Owner = this;
                NewInternationalLicenseApplicationForm.ShowDialog();
            }
        }

        public async Task RefreshInternationalLicensesListAsync()
        {
            await _PopulateListInternationalLicenseApplicationsDataGridView();
        }
    }
}
