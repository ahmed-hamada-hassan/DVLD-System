using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Applications_BL;
using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.Drivers_BL;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.License_Classes_BL;
using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_PresentationLayer.Applications;
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

namespace DVLD_PresentationLayer.Licenses
{
    public partial class frmIssueDrivingLicense : Form
    {
        #region Constants
        private const int NEW_LOCAL_LICENSE_APPLICATION_TYPE_ID = 1;
        #endregion

        #region Fields
        private ClsLocalDrivingLicense _CurrentLocalDrivingLicenseApplicationInfo = null;
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private readonly ClsDriversBL _DriversBL = new ClsDriversBL();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly ClsApplicationTypesBusinessLayer _APPTypesBL = new ClsApplicationTypesBusinessLayer();
        private readonly ClsLicenseClassesBusinessLayer _LicenseClassesBL = new ClsLicenseClassesBusinessLayer();
        private readonly ClsApplicationsBL _APPBL = new ClsApplicationsBL();
        #endregion

        #region Constructors
        public frmIssueDrivingLicense(ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo)
        {
            InitializeComponent();
            _CurrentLocalDrivingLicenseApplicationInfo = CurrentLocalDrivingLicenseApplicationInfo;
            uctrlApplicationAndApplicantInfo1.RecieveData(_CurrentLocalDrivingLicenseApplicationInfo);
        }
        #endregion

        #region Form's Event Handlers
        private async void uctrlApplicationAndApplicantInfo1_OnClickViewPersonInfo(object sender, EventArgs e)
        {
            using (var ShowPersonInfo = new frmShowPersonDetails(_CurrentLocalDrivingLicenseApplicationInfo.PersonID))
            {
                ShowPersonInfo.ShowDialog();
            }
            var FullName = await _PeopleBL.GetPersonFullNameByIDAsync(_CurrentLocalDrivingLicenseApplicationInfo.PersonID);
            uctrlApplicationAndApplicantInfo1.RefreshApplicationBasicInfo(FullName);
        }
        private async void btnIssue_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Are you sure you want to issue license?", "Confirm Issue", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    await _IssueLicense();
                    await _APPBL.CompleteApplicationAsync(_CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID);
                    if (this.Owner is frmManageLocalDrivingLicenseApplications ParentForm)
                        await ParentForm.RefreshLocalDrivingLicenseGridViewAndRecords();
                    this.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Issue Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Private Methods
        private async Task<ClsDriver> _GetDriverInfo()
        {
            ClsDriver DriverInfo = await _DriversBL.GetDriverInfoByPersonIDAsync(_CurrentLocalDrivingLicenseApplicationInfo.PersonID);
            if (DriverInfo == null)
            {
                DriverInfo = new ClsDriver
                {
                    PersonID = _CurrentLocalDrivingLicenseApplicationInfo.PersonID,
                    CreatedByUserID = Program.CurrentUser.UserID,
                    CreationDate = DateTime.Now
                };

                bool isAdded = await _DriversBL.AddNewDriverAsync(DriverInfo);
                if (!isAdded)
                {
                    throw new InvalidOperationException("Failed to create driver record. Please try again.");
                }
            }
            return DriverInfo;
        }
        private async Task<ClsLicense> _GetLicenseInfo()
        {
            var DriverInfo = await _GetDriverInfo();
            var ApplicationTypes = await _APPTypesBL.GetApplicationTypeByIDAsync(NEW_LOCAL_LICENSE_APPLICATION_TYPE_ID);
            var LicenseClassInfo = await _LicenseClassesBL.
                GetLicenseClassesWithIDAsync(_CurrentLocalDrivingLicenseApplicationInfo.LicenseClassID);
            var IssueDate = DateTime.Now;
            var ExpirationDate = IssueDate.AddYears(LicenseClassInfo.DefaultValidityLength);
            
            return new ClsLicense
            {
                ApplicationID = _CurrentLocalDrivingLicenseApplicationInfo.ApplicationID,
                DriverID = DriverInfo.DriverID,
                LicenseClassID = _CurrentLocalDrivingLicenseApplicationInfo.LicenseClassID,
                IssueDate = IssueDate,
                ExpirationDate = ExpirationDate,
                Notes = string.IsNullOrEmpty(txtNotes.Text.Trim()) ? null : txtNotes.Text.Trim(),
                PaidFees = _CurrentLocalDrivingLicenseApplicationInfo.PaidFees,
                IsActive = true,
                IssueReason = ApplicationTypes.ApplicationID,
                CreatedByUserID = Program.CurrentUser.UserID,
            };
        }
        private async Task _IssueLicense()
        {
            var LicenseInfo = await _GetLicenseInfo();
            var Success = await _LicenseBL.AddNewLicenseAsync(LicenseInfo);
            if (Success)
            {
                MessageBox.Show($"License issued successfully with License ID = {LicenseInfo.LicenseID}", "Successfull Issue",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                throw new InvalidOperationException("License issue failed. Please try again.");
            }
        }
        #endregion
    }
}
