using DVLD_BusinessLayer.Applications_BL;
using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.License_Classes_BL;
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
    public partial class frmRenewDrivingLicense : Form
    {
        #region Feilds
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly ClsApplicationTypesBusinessLayer _APPTypesBL = new ClsApplicationTypesBusinessLayer();
        private readonly ClsLicenseClassesBusinessLayer _LicenseClassesBL = new ClsLicenseClassesBusinessLayer();
        #endregion

        #region Constructors
        public frmRenewDrivingLicense()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private async void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            uctrlLicenseInfoBySearch1.LicenseInfoSearched += async (LicenseInfo) =>
            {
                if (LicenseInfo == null)
                {
                    btnRenew.Enabled = false;
                    return;
                }

                bool IsExpiration = await _CheckIfLicenseExpirationOrNot();
                if (!IsExpiration)
                {
                    MessageBox.Show("The provided local license isn't eligible. Cannot renew license.",
                        "Invalid Local License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRenew.Enabled = false;
                    llbShowLicenseHistory.Enabled = false;
                    return;
                }
                btnRenew.Enabled = true;
                llbShowLicenseHistory.Enabled = true;

                await _DisplayStaticData();
            };
        }
        #endregion

        #region Private Methods
        private async Task _DisplayStaticData()
        {
            var ApplicationTypeInfo = await _APPTypesBL.GetApplicationTypeByIDAsync(2);
            var ClassTypeInfo = await _LicenseClassesBL.GetLicenseClassesWithNameAsync(uctrlLicenseInfoBySearch1.LicenseInfo.ClassName);
            lbApplicatioDateResult.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lbIssueDateResult.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lbApplicationFeesResult.Text = ApplicationTypeInfo.ApplicationFees.ToString("C2");
            lbLicenseFeesResult.Text = ClassTypeInfo.ClassFees.ToString("C2");
            lbOldLicenseIDResult.Text = uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID.ToString();
            lbExpirationDateResult.Text = uctrlLicenseInfoBySearch1.LicenseInfo.ExpirationDate.ToString("dd/MMM/yyyy");
            lbCreatedByResult.Text = Program.CurrentUser.UserName;
            lbTotalFeesResult.Text = (ApplicationTypeInfo.ApplicationFees + ClassTypeInfo.ClassFees).ToString("C2");
        }
        private async Task<bool> _CheckIfLicenseExpirationOrNot()
        {
            if(uctrlLicenseInfoBySearch1.LicenseInfo.IsActive && 
                DateTime.Compare(DateTime.Now, uctrlLicenseInfoBySearch1.LicenseInfo.ExpirationDate) > 0)
                return true;
            return false;
        }
        private void _ClearApplicationNewLicenseInfo()
        {
            lbApplicatioDateResult.Text = "[???]";
            lbIssueDateResult.Text = "[???]";
            lbApplicationFeesResult.Text = "[???]";
            lbLicenseFeesResult.Text = "[???]";
            lbOldLicenseIDResult.Text = "[???]";
            lbExpirationDateResult.Text = "[???]";
            lbCreatedByResult.Text = "[???]";
            lbTotalFeesResult.Text = "[???]";

            if (lbRenewedLicenseIDResult != null)
                lbRenewedLicenseIDResult.Text = "[???]";
            if (lbRLApplicationIDResult != null)
                lbRLApplicationIDResult.Text = "[???]";

            btnRenew.Enabled = false;
            llbShowLicenseHistory.Enabled = false;
            llbShowNewLicense.Enabled = false;
        }
        private async Task<int> _AddNewApplication()
        {
            var NewApplication = _GetApplicationInfo();
            var IsAdded = await new ClsApplicationsBL().AddNewApplicationAsync(NewApplication);
            return NewApplication.ApplicationID;
        }
        private ClsApplication _GetApplicationInfo()
        {
            return new ClsApplication
            {
                ApplicationPersonID = uctrlLicenseInfoBySearch1.LicenseInfo.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = 2, 
                ApplicationStatus = 3,
                LastStatusDate = DateTime.Now,
                PaidFees = Convert.ToDecimal(lbTotalFeesResult.Text.TrimStart('$')),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<(bool IsRenewed, int ApplicationID, int NewLicenseID)> _RenewLicense()
        {
            var ApplicationID = await _AddNewApplication();
            var NewLicenseInfo = await _GetLicenseInfo(ApplicationID);
            var IsAdded = await _LicenseBL.AddNewLicenseAsync(NewLicenseInfo);
            return (IsAdded,ApplicationID,NewLicenseInfo.LicenseID);
        }
        private async Task<ClsLicense> _GetLicenseInfo(int ApplicationID)
        {
            var ClassTypeInfo = await _LicenseClassesBL.GetLicenseClassesWithNameAsync(uctrlLicenseInfoBySearch1.LicenseInfo.ClassName);
            return new ClsLicense
            {
                ApplicationID = ApplicationID,
                DriverID = uctrlLicenseInfoBySearch1.LicenseInfo.DriverID,
                LicenseClassID = ClassTypeInfo.LicenseClassID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(ClassTypeInfo.DefaultValidityLength),
                Notes = string.IsNullOrEmpty(txtNotes.Text.Trim())? null: txtNotes.Text.Trim(),
                PaidFees = ClassTypeInfo.ClassFees,
                IsActive = true,
                IssueReason = 2,
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<bool> _DeActiveOldLicense()
        { 
            return await _LicenseBL.DeActiveLicenseByIDAsync(uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID);
        }
        #endregion

        #region From's Events Handlers
        private void frmRenewDrivingLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ClearApplicationNewLicenseInfo();
                uctrlLicenseInfoBySearch1.uctrlLicenseInfoBySearch_KeyDown(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private async void uctrlLicenseInfoBySearch1_OnSearchClicked(object sender, EventArgs e)
        {
            _ClearApplicationNewLicenseInfo();
            await uctrlLicenseInfoBySearch1.DoSearch();
        }
        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var ShowLicenseHistoryForm = new frmShowLicenseHistory(uctrlLicenseInfoBySearch1.LicenseInfo))
            {
                ShowLicenseHistoryForm.ShowDialog();
            }
        }
        private async void llbShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewLicenseInfo = await _LicenseBL.GetLicenseInfoByLicenseIDAsync(Convert.ToInt32(lbRenewedLicenseIDResult.Text));

            using ( var ShowNewLicenseInfo = new frmShowLicenseInfo(NewLicenseInfo))
            {
                ShowNewLicenseInfo.ShowDialog();
            }
        }
        private async void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to renew this driving license?",
                "Confirm Renew License",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var renewResult = await _RenewLicense();

                if (!renewResult.IsRenewed)
                {
                    MessageBox.Show("License renewal failed",
                        "Renewal Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var deactivated = await _DeActiveOldLicense();
                if (!deactivated)
                {
                    MessageBox.Show("Old license deactivation failed",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                lbRLApplicationIDResult.Text = renewResult.ApplicationID.ToString();
                lbRenewedLicenseIDResult.Text = renewResult.NewLicenseID.ToString();
                llbShowNewLicense.Enabled = true;

                MessageBox.Show(
                    $"License renewed successfully!\nNew License ID: {renewResult.NewLicenseID}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while renewing the license:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRenew.Enabled = false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
