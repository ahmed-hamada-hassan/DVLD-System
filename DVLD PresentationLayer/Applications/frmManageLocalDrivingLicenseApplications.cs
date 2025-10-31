using DVLD_BusinessLayer.Applications_BL;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_PresentationLayer.Application_Types;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.Tests;
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
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        #region Fields and Counstructors
        private readonly ClsLocalDrivingLicenseApplicationsBL _localDrivingLicenseApplicationsBL = new ClsLocalDrivingLicenseApplicationsBL();
        private readonly ClsApplicationsBL _AppBL = new ClsApplicationsBL();
        private readonly ClsLocalDrivingLicenseApplicationsBL _LDLAPPBL = new ClsLocalDrivingLicenseApplicationsBL();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly Dictionary<byte, string> _cbFilterByOptions = new Dictionary<byte, string>()
        {
            { 0 , "None" },
            { 1 , "LocalDrivingLicenseApplicationID" },
            { 2 , "NationalNo" },
            { 3 , "FullName" },
            { 4 , "Status" }
        };
        private readonly Dictionary<byte, string> _cbStatusOptions = new Dictionary<byte, string>()
        {
            { 0 , "None" },
            { 1 , "New" },
            { 2 , "Cancelled" },
            { 3 , "Completed" },
        };
        #endregion

        #region Constructor
        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private async void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _PopulateComboBoxFilterBY();
            _PopulateComboBoxStatus();
        }
        #endregion

        #region Form's Events
        private void btnAddNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            using (var AddNewLocalDrivingLicenseApplication = new frmNewLocalDrivingLicenseApplication())
            {
                AddNewLocalDrivingLicenseApplication.Owner = this;
                AddNewLocalDrivingLicenseApplication.ShowDialog();
            }
        }
        private async void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                cbStatus.Visible = false;
                txtFilterBySearch.Visible = false;
                await _PopulateLocalLicenseGridViewAndRecords();
                return;
            }
            else
            {
                txtFilterBySearch.Visible = (cbFilterBy.SelectedIndex != 0 && cbFilterBy.SelectedIndex != 4);
                if (cbFilterBy.SelectedIndex == 4)
                {
                    cbStatus.Visible = true;
                    cbStatus.SelectedIndex = 0;
                    return;
                }
            }
                return; 
        }
        private void txtFilterBySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string SelectedFilter = cbFilterBy.SelectedItem.ToString();
            if (SelectedFilter == "Full Name")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    _SetErrors(txtFilterBySearch, "Please enter letters and spaces only");
                    return;
                }
                else
                {
                    _DeleteErrors(txtFilterBySearch);
                    return;
                }
            }
            else if (SelectedFilter == "National No.")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    _SetErrors(txtFilterBySearch, "Please enter digits only.");
                    return;
                }

                // Check if the input would exceed 14 digits
                if (char.IsDigit(e.KeyChar) && txtFilterBySearch.Text.Length >= 14)
                {
                    e.Handled = true;
                    _SetErrors(txtFilterBySearch, "National No. cannot exceed 14 digits.");
                    return;
                }
                else
                {
                    _DeleteErrors(txtFilterBySearch);
                    return;
                }
            }
            else
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
            var LocalDrivingLicenseApplications =
                await _localDrivingLicenseApplicationsBL.FilterLocalDrivingLicenseAccordingByAsync(_cbFilterByOptions[(byte)cbFilterBy.SelectedIndex],
                txtFilterBySearch.Text);
            dgvLocalLicenses.DataSource = _ConfigureListToViewInDataGridView(LocalDrivingLicenseApplications);
            _ConfigureLocalLicenseGridView(dgvLocalLicenses);
            lbRecordsResult.Text = LocalDrivingLicenseApplications.Count.ToString();
        }
        private async void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Status = _cbStatusOptions[(byte)cbStatus.SelectedIndex];
            var LocalDrivingLicenseApplications = Status != "None" ?
                await _localDrivingLicenseApplicationsBL.FilterLocalDrivingLicenseAccordingByStatusAsync(Status) :
                await _localDrivingLicenseApplicationsBL.GetAllLocalDrivingLicenseApplicationsAsync();

            dgvLocalLicenses.DataSource = _ConfigureListToViewInDataGridView(LocalDrivingLicenseApplications);
            _ConfigureLocalLicenseGridView(dgvLocalLicenses);
            lbRecordsResult.Text = LocalDrivingLicenseApplications.Count.ToString();
        }
        private async void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                await _ConfirmCancelApplication(LDLAPPID);
            }
        }
        private async void deleteApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                string Status = dgvLocalLicenses.SelectedRows[0].Cells[6].Value.ToString();
                await _ConfirmDeleteApplication(LDLAPPID, Status);
            }
        }
        private void editApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                using (var EditApplicationInf = new frmNewLocalDrivingLicenseApplication(LDLAPPID))
                {
                    EditApplicationInf.Owner = this;
                    EditApplicationInf.ShowDialog();
                }
            }
        }
        private async void scheduleVisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo = await _LDLAPPBL.GetDrivingLicenseApplicationAsync(LDLAPPID);

                using (var VisionTestAppointment = new frmAppointmentTest(CurrentLocalDrivingLicenseApplicationInfo,
                                                                   frmAppointmentTest.EnAppointmentType.Vision))
                {
                    VisionTestAppointment.Owner = this;
                    VisionTestAppointment.ShowDialog();
                }
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                string Status = dgvLocalLicenses.SelectedRows[0].Cells[6].Value.ToString();
                int PassedTests = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[5].Value);

                scToolStripMenuItem.Enabled = (Status == "Cancelled" || Status == "Completed" || PassedTests == 3) ? false : true;
                cancelApplicationToolStripMenuItem.Enabled = (Status == "Cancelled" || Status == "Completed") ? false : true;
                deleteApplicaitonToolStripMenuItem.Enabled = Status == "Completed" ? false : true;
                editApplicationsToolStripMenuItem.Enabled = (Status == "Cancelled" || Status == "Completed" || PassedTests == 3) ? false : true;
                issueDrivingLicenseToolStripMenuItem.Enabled = (PassedTests == 3 && Status == "New") ? true : false;
                showLicenseToolStripMenuItem.Enabled = (Status == "Completed") ? true : false;

                scheduleVisionToolStripMenuItem.Enabled = PassedTests == 0 && (Status == "New") ? true : false;
                scheduleWrittingTestToolStripMenuItem.Enabled = PassedTests == 1 && (Status == "New") ? true : false;
                scheduleStreetTestToolStripMenuItem.Enabled = PassedTests == 2 && (Status == "New") ? true : false;

                editApplicationsToolStripMenuItem.Enabled = !(PassedTests > 2);

                return;
            }
        }
        private async void scheduleWrittingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo = await _LDLAPPBL.GetDrivingLicenseApplicationAsync(LDLAPPID);

                using (var WrittingTestAppointment = new frmAppointmentTest(CurrentLocalDrivingLicenseApplicationInfo,
                                                                   frmAppointmentTest.EnAppointmentType.Writting))
                {
                    WrittingTestAppointment.Owner = this;
                    WrittingTestAppointment.ShowDialog();
                }
            }
        }
        private async void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo = await _LDLAPPBL.GetDrivingLicenseApplicationAsync(LDLAPPID);

                using (var RoadTestAppointment = new frmAppointmentTest(CurrentLocalDrivingLicenseApplicationInfo,
                                                                   frmAppointmentTest.EnAppointmentType.Road))
                {
                    RoadTestAppointment.Owner = this;
                    RoadTestAppointment.ShowDialog();
                }
            }
        }
        private async void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo = await _LDLAPPBL.GetDrivingLicenseApplicationAsync(LDLAPPID);
                using (var IssueDrivingLicenseForm = new frmIssueDrivingLicense(CurrentLocalDrivingLicenseApplicationInfo))
                {
                    IssueDrivingLicenseForm.Owner = this;
                    IssueDrivingLicenseForm.ShowDialog();
                }
            }
        }
        private async void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                string NationalNumber = dgvLocalLicenses.SelectedRows[0].Cells[2].Value.ToString();
                var DriverLicenseInfo = await _LicenseBL.GetActiveLicenseByNationalNumberAsync(NationalNumber);
                using (var ShowLicenseInfo = new frmShowLicenseInfo(DriverLicenseInfo))
                {
                    ShowLicenseInfo.ShowDialog();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                int LDLAPPID = Convert.ToInt32(dgvLocalLicenses.SelectedRows[0].Cells[0].Value);
                ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo = await _LDLAPPBL.GetDrivingLicenseApplicationAsync(LDLAPPID);

                using (var ShowApplicationInfo = new frmShowApplicationInfo(CurrentLocalDrivingLicenseApplicationInfo))
                {
                    ShowApplicationInfo.Owner = this;
                    ShowApplicationInfo.ShowDialog();
                }
            }
        }
        private async void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.SelectedRows.Count > 0)
            {
                string NationalNumber = dgvLocalLicenses.SelectedRows[0].Cells[2].Value.ToString();
                var LicenseInfo = await _LicenseBL.GetActiveLicenseByNationalNumberAsync(NationalNumber);
                using (var ShowPersonLicenseHistory = new frmShowLicenseHistory(LicenseInfo))
                {
                    ShowPersonLicenseHistory.ShowDialog();
                }
            }
        }
        #endregion

        #region Private Methods
        private void _ConfigureLocalLicenseGridView(DataGridView dgvLocalLicenses)
        {
            if (dgvLocalLicenses.Columns.Contains("LocalDrivingLicenseApplicationID"))
                dgvLocalLicenses.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L.APP.ID";
            if (dgvLocalLicenses.Columns.Contains("DrivingClassTitle"))
                dgvLocalLicenses.Columns["DrivingClassTitle"].HeaderText = "Driving Class";
            if (dgvLocalLicenses.Columns.Contains("NationalNo"))
                dgvLocalLicenses.Columns["NationalNo"].HeaderText = "National No.";
            if (dgvLocalLicenses.Columns.Contains("FullName"))
                dgvLocalLicenses.Columns["FullName"].HeaderText = "Full Name";
            if (dgvLocalLicenses.Columns.Contains("ApplicationDate"))
                dgvLocalLicenses.Columns["ApplicationDate"].HeaderText = "Application Date";
            if (dgvLocalLicenses.Columns.Contains("PassedTestCount"))
                dgvLocalLicenses.Columns["PassedTestCount"].HeaderText = "Passed Tests";
            if (dgvLocalLicenses.Columns.Contains("Status"))
                dgvLocalLicenses.Columns["Status"].HeaderText = "Status";
        }
        private List<object> _ConfigureListToViewInDataGridView(List<ClsLocalDrivingLicense> List)
        {
            if (List == null || List.Count == 0) return null;

            return List.Select(x => new
            {
                x.LocalDrivingLicenseApplicationID,
                x.DrivingClassTitle,
                x.NationalNo,
                x.FullName,
                x.ApplicationDate,
                x.PassedTestCount,
                x.Status
            }).ToList<object>();

        }
        private async Task _PopulateLocalLicenseGridViewAndRecords()
        {
            var localDrivingLicenses = new List<ClsLocalDrivingLicense>();
            localDrivingLicenses = await _localDrivingLicenseApplicationsBL.GetAllLocalDrivingLicenseApplicationsAsync();
            dgvLocalLicenses.DataSource = _ConfigureListToViewInDataGridView(localDrivingLicenses);
            _ConfigureLocalLicenseGridView(dgvLocalLicenses);
            lbRecordsResult.Text = localDrivingLicenses.Count.ToString();
        }
        private void _PopulateComboBoxFilterBY()
        {
            cbFilterBy.Items.AddRange(new string[] { "None", "L.D.L.APP.ID", "National No.", "Full Name", "Status" });
            cbFilterBy.SelectedIndex = 0;
            txtFilterBySearch.Visible = false;
            cbStatus.Visible = false;
        }
        private void _PopulateComboBoxStatus()
        {
            cbStatus.Items.AddRange(new string[] { "None", "New", "Cancelled", "Completed"});
            cbStatus.SelectedIndex = 0;
        }
        private void _SetErrors(Control CTRL,string Message)
        {
            errorProvider1.SetError(CTRL, Message);
        }
        private void _DeleteErrors(Control CTRL)
        {
            errorProvider1.SetError(CTRL, string.Empty);
        }
        private async Task _ConfirmCancelApplication(int LocalDrivingLicenseApplicationID)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this application?",
                                     "Confirm Cancel!!",
                                     MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                bool IsCancelled = await _AppBL.CancelApplicationAsync(LocalDrivingLicenseApplicationID);
                if (IsCancelled)
                {
                    MessageBox.Show("The application has been cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshLocalDrivingLicenseGridViewAndRecords();
                }
                else
                {
                    MessageBox.Show("Failed to cancel the application. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task _ConfirmDeleteApplication(int LocalDrivingLicenseApplicationID,string Status)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this application?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                if(Status == "Cancelled")
                {
                    var IsDeletedPermanently = await _AppBL.DeleteApplicationPermanentlyAsync(LocalDrivingLicenseApplicationID);
                    if(IsDeletedPermanently)
                    {
                        MessageBox.Show("The application has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshLocalDrivingLicenseGridViewAndRecords();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                bool IsDeleted = await _AppBL.DeleteApplicationAsync(LocalDrivingLicenseApplicationID);
                if (IsDeleted)
                {
                    MessageBox.Show("The application has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshLocalDrivingLicenseGridViewAndRecords();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to delete the application because it has a test appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion

        #region Public Methods
        public async Task RefreshLocalDrivingLicenseGridViewAndRecords()
        {
            await _PopulateLocalLicenseGridViewAndRecords();
        }
        #endregion
    }
}
