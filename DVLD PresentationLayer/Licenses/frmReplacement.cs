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
    public partial class frmReplacement : Form
    {
        #region Fields
        enum EnReplacementMode 
        { 
            Lost = 3,       // Replacement for lost license
            Damaged = 4     // Replacement for damaged license
        };

        private EnReplacementMode _ReplacementMode = EnReplacementMode.Damaged;
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly ClsApplicationTypesBusinessLayer _APPType = new ClsApplicationTypesBusinessLayer();
        private readonly ClsLicenseClassesBusinessLayer _LicenseClassesBL = new ClsLicenseClassesBusinessLayer();
        #endregion

        #region Constructors
        public frmReplacement()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private async void frmReplacement_Load(object sender, EventArgs e)
        {
            uctrlLicenseInfoBySearch1.LicenseInfoSearched += async (LicenseInfo) =>
            {
                if(LicenseInfo == null) { btnIssueReplacement.Enabled = false; return; }

                bool IsActive = await _CheckIfthisActiveOrNot(LicenseInfo.LicenseID);
                if(!IsActive)
                {
                    MessageBox.Show("Selected license isn't active, choose an active license.","Not Allowed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssueReplacement.Enabled = false;
                    return;
                }

                btnIssueReplacement.Enabled = true;
                llbShowLicenseHistory.Enabled = true;

                await _DisplayApplicationInfoData();
            };
        }
        #endregion

        #region Private Methods
        private async Task _DisplayApplicationInfoData()
        {
            var ApplicationTypeInfo = await _APPType.GetApplicationTypeByIDAsync(Convert.ToInt32(_ReplacementMode));

            lbApplicatioDateResult.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lbOldLicenseIDResult.Text = uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID.ToString();
            lbApplicationFeesResult.Text = ApplicationTypeInfo.ApplicationFees.ToString("C3");
            lbCreatedByResult.Text = Program.CurrentUser.UserName;
        }
        private void _ConfigureForm()
        {
            Text = _ReplacementMode == EnReplacementMode.Damaged ? "Replacement For Damaged License" : "Replacement For Lost License";
            label1.Text = _ReplacementMode == EnReplacementMode.Damaged ? "Replacement For Damaged License" : "Replacement For Lost License";
        }
        private async Task<bool> _CheckIfthisActiveOrNot(int LicenseID)
        {
            return await _LicenseBL.IsActiveLicenseByIDAsync(LicenseID);
        }
        private void _ClearApplicationInfoData()
        {
            lbRLApplicationIDResult.Text = "[???]";
            lbReplacedLicenseIDResult.Text = "[???]";
            lbApplicatioDateResult.Text = "[???]";
            lbOldLicenseIDResult.Text = "[???]";
            lbApplicationFeesResult.Text = "[???]";
            lbCreatedByResult.Text = "[???]";
        }
        private ClsApplication _GetApplicationInfo()
        {
            return new ClsApplication
            {
                ApplicationPersonID = uctrlLicenseInfoBySearch1.LicenseInfo.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = Convert.ToInt32(_ReplacementMode),
                ApplicationStatus = 3,
                LastStatusDate = DateTime.Now,
                PaidFees = Convert.ToDecimal(lbApplicationFeesResult.Text.TrimStart('$')),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<int> _AddNewApplication()
        {
            var NewApplicationInfo = _GetApplicationInfo();
            var IsAdded = await new ClsApplicationsBL().AddNewApplicationAsync(NewApplicationInfo);
            return NewApplicationInfo.ApplicationID;
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
                Notes = null,
                PaidFees = ClassTypeInfo.ClassFees,
                IsActive = true,
                IssueReason = Convert.ToInt32(_ReplacementMode),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<(bool IsReplaced, int ApplicationID, int NewLicenseID)> _ReplacementLicense()
        {
            var ApplicationID = await _AddNewApplication();
            var NewLicenseInfo = await _GetLicenseInfo(ApplicationID);
            var IsAdded = await _LicenseBL.AddNewLicenseAsync(NewLicenseInfo);
            return (IsAdded, ApplicationID, NewLicenseInfo.LicenseID);
        }
        private async Task<bool> _DeActiveOldLicense()
        {
            return await _LicenseBL.DeActiveLicenseByIDAsync(uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID);
        }
        #endregion

        #region Form's Event Handlers
        private async void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            _ReplacementMode = rbDamagedLicense.Checked ? EnReplacementMode.Damaged : EnReplacementMode.Lost;
            _ConfigureForm();
            if (uctrlLicenseInfoBySearch1.LicenseInfo != null)
                await _DisplayApplicationInfoData();
        }
        private async void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            _ReplacementMode = rbDamagedLicense.Checked ? EnReplacementMode.Damaged : EnReplacementMode.Lost;
            _ConfigureForm();
            if (uctrlLicenseInfoBySearch1.LicenseInfo != null)
                await _DisplayApplicationInfoData();
        }
        private async void uctrlLicenseInfoBySearch1_OnSearchClicked(object sender, EventArgs e)
        {
            _ClearApplicationInfoData();
            await uctrlLicenseInfoBySearch1.DoSearch();
        }
        private void frmReplacement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ClearApplicationInfoData();
                uctrlLicenseInfoBySearch1.uctrlLicenseInfoBySearch_KeyDown(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
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
            var NewLicenseInfo = await _LicenseBL.GetLicenseInfoByLicenseIDAsync(Convert.ToInt32(lbReplacedLicenseIDResult.Text));

            using (var ShowNewLicenseInfo = new frmShowLicenseInfo(NewLicenseInfo))
            {
                ShowNewLicenseInfo.ShowDialog();
            }
        }
        private async void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Are you sure you want to replace this driving license?",
               "Confirm License Replacement",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
                return;

            btnIssueReplacement.Enabled = false;

            try
            {
                var replacementResult = await _ReplacementLicense();

                if (!replacementResult.IsReplaced)
                {
                    MessageBox.Show("License replacement failed",
                        "Replacement Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var deactivated = await _DeActiveOldLicense();
                if (!deactivated)
                {
                    MessageBox.Show("Old license deactivation failed",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                lbRLApplicationIDResult.Text = replacementResult.ApplicationID.ToString();
                lbReplacedLicenseIDResult.Text = replacementResult.NewLicenseID.ToString();
                llbShowNewLicense.Enabled = true;

                MessageBox.Show(
                    $"License replaced successfully!\nNew License ID: {replacementResult.NewLicenseID}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while replacing the license:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnIssueReplacement.Enabled = false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
