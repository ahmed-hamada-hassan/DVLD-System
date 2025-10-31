using DVLD_BusinessLayer.Applications_BL;
using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.License_BL.Detained_License_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses
{
    public partial class frmReleaseDetainedLicense : Form
    {
        #region Feilds
        private readonly ClsDetainedLicensesBL _DetainedLicensesBL = new ClsDetainedLicensesBL();
        private readonly ClsApplicationTypesBusinessLayer _APPTypesBL = new ClsApplicationTypesBusinessLayer();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly ClsApplicationsBL _ApplicationsBL = new ClsApplicationsBL();
        private ClsDetainLicense _CurrentDetainLicenseInfo;
        private int? _ProvidLicenseID;
        #endregion

        #region Constructors
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        public frmReleaseDetainedLicense(int LicenseID) : this()
        {
            KeyPreview = true;
            _ProvidLicenseID = LicenseID;
        }
        private async void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            uctrlLicenseInfoBySearch1.LicenseInfoSearched += async (LicenseInfo) =>
            {
                if (LicenseInfo == null)
                {
                    groupBox1.Enabled = false;
                    return;
                }

                var IsActive = await _CheckIfThisActiveOrNot(LicenseInfo.LicenseID);
                var IsDetained = await _CheckIfthisDetainedOrNot(LicenseInfo.LicenseID);

                if (!IsActive)
                {
                    MessageBox.Show("Selected license isn't active, choose An Active license.", "Not Allowed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupBox1.Enabled = false;
                    return;
                }
                if (!IsDetained)
                {
                    MessageBox.Show("Selected license isn't detained, choose another license.", "Not Allowed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupBox1.Enabled = false;
                    return;
                }

                groupBox1.Enabled = true;
                btnRelease.Enabled = true;
                llbShowLicenseHistory.Enabled = true;
                await _DisplayDetainInfo();
            };

            if (_ProvidLicenseID.HasValue)
            {
                await uctrlLicenseInfoBySearch1.LoadLicenseInfoByID(_ProvidLicenseID.Value);
                return;
            }
        }
        #endregion

        #region Private Methods
        private async Task<bool> _CheckIfthisDetainedOrNot(int licenseID)
        {
            return await _DetainedLicensesBL.CheckIfLicenseIsDetainedAsync(licenseID);
        }
        private async Task<bool> _CheckIfThisActiveOrNot(int LicenseID)
        {
            return await _LicenseBL.IsActiveLicenseByIDAsync(LicenseID);
        }
        private async Task _DisplayDetainInfo()
        {
            var DetainedLicenseInfo = uctrlLicenseInfoBySearch1.LicenseInfo != null ? await _DetainedLicensesBL.
                GetDetainLicenseInfoByLicenseIDAsync(uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID) : await _DetainedLicensesBL.
                GetDetainLicenseInfoByLicenseIDAsync(_ProvidLicenseID.Value);

            var ApplicationTypeInfo = await _APPTypesBL.
                GetApplicationTypeByIDAsync(5);
            lbDetainIDResult.Text = DetainedLicenseInfo.DetainID.ToString();
            lbLicenseIDResult.Text = DetainedLicenseInfo.LicenseID.ToString();
            lbDetainDateResult.Text = DetainedLicenseInfo.DetainDate.ToString("dd/MMM/yyyy");
            lbCreatedByResult.Text = Program.CurrentUser.UserName;
            lbApplicationFeesResult.Text = ApplicationTypeInfo.ApplicationFees.ToString("C3");
            lbFineFeesResult.Text = DetainedLicenseInfo.FineFees.ToString("C3");
            lbTotalFeesResult.Text = (ApplicationTypeInfo.ApplicationFees + DetainedLicenseInfo.FineFees).ToString("C3");

            _CurrentDetainLicenseInfo = DetainedLicenseInfo;
        }
        private void _ClearDetainInfo()
        {
            lbDetainIDResult.Text = "[???]";
            lbLicenseIDResult.Text = "[???]";
            lbDetainDateResult.Text = "[???]";
            lbCreatedByResult.Text = "[???]";
            lbApplicationFeesResult.Text = "[???]";
            lbFineFeesResult.Text = "[???]";
            lbTotalFeesResult.Text = "[???]";
            lbReleaseApplicationIDResult.Text = "[???]";
        }
        private ClsApplication _GetApplicationInfo()
        {
            return new ClsApplication
            {
                ApplicationPersonID = uctrlLicenseInfoBySearch1.LicenseInfo.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = 5,
                ApplicationStatus = 3,
                LastStatusDate = DateTime.Now,
                PaidFees = Convert.ToDecimal(lbTotalFeesResult.Text.TrimStart('$')),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<int> _AddNewApplication()
        {
            var NewApplication = _GetApplicationInfo();
            await _ApplicationsBL.AddNewApplicationAsync(NewApplication);
            return NewApplication.ApplicationID;
        }
        private async Task<(bool IsReleased, int ApplicationReleaseID)> _ReleaseDetainedLicense()
        {
            var ApplicationID = await _AddNewApplication();

            _CurrentDetainLicenseInfo.ReleaseDate = DateTime.Now;
            _CurrentDetainLicenseInfo.ReleaseApplicationID = ApplicationID;
            _CurrentDetainLicenseInfo.ReleasedByUserID = Program.CurrentUser.UserID;

            var IsReleased = await _DetainedLicensesBL.ReleaseDetainedLicenseAsync(_CurrentDetainLicenseInfo);
            return (IsReleased, ApplicationID);
        }
        #endregion

        #region Form's Events Handlers
        private void frmReleaseDetainedLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ClearDetainInfo();
                uctrlLicenseInfoBySearch1.uctrlLicenseInfoBySearch_KeyDown(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private async void uctrlLicenseInfoBySearch1_OnSearchClicked(object sender, EventArgs e)
        {
            _ClearDetainInfo();
            await uctrlLicenseInfoBySearch1.DoSearch();
        }
        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var ShowLicenseHistoryForm = new frmShowLicenseHistory(uctrlLicenseInfoBySearch1.LicenseInfo))
            {
                ShowLicenseHistoryForm.ShowDialog();
            }
        }
        private async void llbShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewLicenseInfo = await _LicenseBL.
                GetLicenseInfoByLicenseIDAsync(uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID);

            using (var ShowNewLicenseInfo = new frmShowLicenseInfo(NewLicenseInfo))
            {
                ShowNewLicenseInfo.ShowDialog();
            }
        }
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Owner is frmListDetainedLicenses ParentForm)
            {
                await ParentForm.RefreshDetainedLicensesDataGridView();
                Close();
                return;
            }
            Close();
        }
        private async void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to release this driving license?",
                "Confirm Release License",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var ReleaseResult = await _ReleaseDetainedLicense();

                if (!ReleaseResult.IsReleased)
                {
                    MessageBox.Show("License release failed",
                        "Released Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lbReleaseApplicationIDResult.Text = ReleaseResult.ApplicationReleaseID.ToString();
                llbShowLicense.Enabled = true;
                groupBox1.Enabled = false;

                MessageBox.Show(
                    $"License released successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while releasin the license:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRelease.Enabled = false;
            }
        }
        #endregion
    }
}
