using DVLD_BusinessLayer.Applications_BL;
using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.License_BL.International_License_BL;
using DVLD_PresentationLayer.Applications;
using DVLD_PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licenses
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        #region Fields 
        private readonly ClsApplicationTypesBusinessLayer _APPTypesBL = new ClsApplicationTypesBusinessLayer();
        private readonly ClsInternationalLicensesBL _InternationalLicenseBL = new ClsInternationalLicensesBL();
        private readonly ClsApplicationsBL _ApplicationsBL = new ClsApplicationsBL();
        private ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private ClsInternationalLicense _NewInternationalLicense = null;
        #endregion

        #region Constructors
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
            
        }
        private async void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            uctrlLicenseInfoBySearch1.LicenseInfoSearched += async (LicenseInfo) =>
            {
                if(LicenseInfo == null)
                {
                    btnIssue.Enabled = false;
                    return;
                }

                bool IsOrdinaryLicense = await _CheckIfthisOrdinaryLicenseOrNot();
                if(!IsOrdinaryLicense)
                {
                    MessageBox.Show("The provided local license is not an active ordinary license. Cannot issue international license.",
                        "Invalid Local License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnIssue.Enabled = false;
                    llbShowLicenseHistory.Enabled = false;
                    return;
                }
                btnIssue.Enabled = true;
                llbShowLicenseHistory.Enabled = true;

                await _DisplayStaticData();
            };
        }
        #endregion

        #region From's Events Handlers
        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var ShowLicenseHistoryForm = new frmShowLicenseHistory(uctrlLicenseInfoBySearch1.LicenseInfo))
            {
                ShowLicenseHistoryForm.ShowDialog();
            }
        }
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnIssue_Click(object sender, EventArgs e)
        {
            if (await _CheckIfHasAnActiveInternationalLicense()) return;
            await _IssueInternationalLicense();
        }
        private async void llbShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var InternationalLicenseInfo = await
                _InternationalLicenseBL.GetInternationalLicenseInfoByInternationalLicenseIDAsync(_NewInternationalLicense.InternationalLicenseID);
            using (var ShowInternationalLicenseForm = new frmShowDriverInternationalLicenseInfo(InternationalLicenseInfo))
            {
                ShowInternationalLicenseForm.ShowDialog();
            }
        }
        private void frmNewInternationalLicenseApplication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uctrlLicenseInfoBySearch1.uctrlLicenseInfoBySearch_KeyDown(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }
        private async void frmNewInternationalLicenseApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is frmManageInternationalLicenseApplications parentForm)
                await parentForm.RefreshInternationalLicensesListAsync();
        }
        private async void uctrlLicenseInfoBySearch1_OnSearchClicked(object sender, EventArgs e)
        {
            _ClearApplicationInfo();
            await uctrlLicenseInfoBySearch1.DoSearch();
        }
        #endregion

        #region Private Methods
        private async Task _DisplayStaticData()
        {
            var ApplicationInfo = await _APPTypesBL.GetApplicationTypeByIDAsync(6);
            lbFeesResult.Text = string.Format("{0:C3}", ApplicationInfo.ApplicationFees);
            lbCreatedByResult.Text = Program.CurrentUser.UserName;
            lbApplicationDateResult.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lbLocalLicenseIDResult.Text = uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID.ToString();
            lbIssueDateResult.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lbExpirationDateResult.Text = DateTime.Now.AddYears(1).ToString("dd/MMM/yyyy");
        }
        private async Task<bool> _CheckIfHasAnActiveInternationalLicense()
        {
            var License = await
                _InternationalLicenseBL.GetInternationalLicenseByIssuedLocalLicenseIDAsync(uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID);
            if (License == null) return false;
            if (License.IsActive && (DateTime.Compare(License.ExpirationDate,DateTime.Now) > 0))
            {
                MessageBox.Show($"Person already have an active international license with ID = {License.InternationalLicenseID}"
                               , "Active International License Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private async Task<bool> _CheckIfthisOrdinaryLicenseOrNot()
        {
            return await _LicenseBL.IsActiveOrdinaryLicenseByIDAsync(uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID);
        }
        private async Task<int> _AddApplication()
        {
            var NewApplication = await _GetApplicationInfo();
            var IsAdded = await _ApplicationsBL.AddNewApplicationAsync(NewApplication);
            return (NewApplication.ApplicationID);
        }
        private async Task _IssueInternationalLicense()
        {
            var Result = MessageBox.Show("Are you sure you want to issue this international license?"
                                           , "Confirm Issue International License", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No) return ;

            var InternationalLicense = await _GetInternationalLicenseInfo();
            var IsIssued = await _InternationalLicenseBL.AddNewInternationalLicenseAsync(InternationalLicense);
            _NewInternationalLicense = InternationalLicense;
            if (IsIssued)
            {
                MessageBox.Show($"International License issued successfully with ID = {InternationalLicense.InternationalLicenseID}"
                               , "International License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIssue.Enabled = false;
                llbShowLicense.Enabled = true;
                lbInternationalLicenseApplicationIDResult.Text = InternationalLicense.ApplicantionID.ToString();
                lbInternationalLicenseIDResult.Text = InternationalLicense.InternationalLicenseID.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Failed to issue the international license. Please try again."
                               , "Issue International License Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private async Task<ClsInternationalLicense> _GetInternationalLicenseInfo()
        {
            var ApplicationID = await _AddApplication();
            return new ClsInternationalLicense
            {
                ApplicantionID = ApplicationID,
                DriverID = uctrlLicenseInfoBySearch1.LicenseInfo.DriverID,
                IssuedUsingLocalLicenseID = uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(1),
                IsActive = true,
                IsCreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<ClsApplication> _GetApplicationInfo()
        {
            return new ClsApplication
            {
                ApplicationPersonID = uctrlLicenseInfoBySearch1.LicenseInfo.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = 6, 
                ApplicationStatus = 1, 
                LastStatusDate = DateTime.Now,
                PaidFees = decimal.Parse(lbFeesResult.Text, System.Globalization.NumberStyles.Currency),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private void _ClearApplicationInfo()
        {
            lbFeesResult.Text = "[???]";
            lbCreatedByResult.Text = "[???]";
            lbApplicationDateResult.Text = "[???]";
            lbLocalLicenseIDResult.Text = "[???]";
            lbIssueDateResult.Text = "[???]";
            lbExpirationDateResult.Text = "[???]";
            lbInternationalLicenseApplicationIDResult.Text = "[???]";
            lbInternationalLicenseIDResult.Text = "[???]";
            
            btnIssue.Enabled = false;
            llbShowLicenseHistory.Enabled = false;
            llbShowLicense.Enabled = false;
            
            _NewInternationalLicense = null;
        }
        #endregion
    }
}

