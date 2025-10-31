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
    public partial class frmDetainedLicense : Form
    {
        #region Fields
        private readonly ClsDetainedLicensesBL _DetainedLicensesBL = new ClsDetainedLicensesBL();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        #endregion

        #region Constructors
        public frmDetainedLicense()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private async void frmDetainedLicense_Load(object sender, EventArgs e)
        {
            uctrlLicenseInfoBySearch1.LicenseInfoSearched += async(LicenseInfo) =>
            {
                if (LicenseInfo == null)
                {
                    groupBox1.Enabled = false;
                    return;
                }

                bool IsActive = await _CheckIfThisIsActiveOrNot(LicenseInfo.LicenseID);
                bool IsDetained = await _CheckIfThisIsDetainedOrNot(LicenseInfo.LicenseID);

                if (IsDetained)
                {
                    MessageBox.Show("Selected license is already detained, choose another license.", "Not Allowed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupBox1.Enabled = false;
                    return;
                }

                if (!IsActive)
                {
                    MessageBox.Show("Selected license isn't active, choose An Active license.", "Not Allowed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupBox1.Enabled = false;
                    return;
                }
                groupBox1.Enabled = true;   
                llbShowLicenseHistory.Enabled = true;
                btnDetain.Enabled = true;
                _DisplayDetainInfo();
            };
        }
        #endregion

        #region Private Methods
        private async Task<bool> _CheckIfThisIsDetainedOrNot(int licenseID)
        {
            return await _DetainedLicensesBL.CheckIfLicenseIsDetainedAsync(licenseID);
        }
        private async Task<bool> _CheckIfThisIsActiveOrNot(int LicenseID)
        {
            return await _LicenseBL.IsActiveLicenseByIDAsync(LicenseID);
        }
        private void _DisplayDetainInfo()
        {
            lbLicenseIDResult.Text = uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID.ToString();
            lbDetainDateResult.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lbCreatedByResult.Text = Program.CurrentUser.UserName;
        }
        private ClsDetainLicense _GetDetainLicenseInfo()
        {
            return new ClsDetainLicense
            {
                LicenseID = uctrlLicenseInfoBySearch1.LicenseInfo.LicenseID,
                DetainDate = DateTime.Now,
                CreatedByUserID = Program.CurrentUser.UserID,
                FineFees = Convert.ToDecimal(txtFineFeesResult.Text)
            };
        }
        private async Task<(bool IsDetained, int DetainID)> _DetainLicenseAsync()
        {
            var DetainLicenseInfo = _GetDetainLicenseInfo();
            bool IsDetained = await _DetainedLicensesBL.AddNewDetainedLicenseAsync(DetainLicenseInfo);
            return (IsDetained, DetainLicenseInfo.DetainID);
        }
        private void _ClearDetainInfo()
        {
            lbLicenseIDResult.Text = "[???]";
            lbDetainDateResult.Text = "[???]";
            lbCreatedByResult.Text = "[???]";
            lbDetainIDResult.Text = "[???]";
            txtFineFeesResult.Clear();
            llbShowLicenseHistory.Enabled = false;
            llbShowNewLicense.Enabled = false;
        }
        private bool _CheckFineFeesTextBox()
        {
            if(!decimal.TryParse(txtFineFeesResult.Text, out decimal fineFees))
                return false;
            return true;
        }
        #endregion

        #region From's Event Handlers
        private async void uctrlLicenseInfoBySearch1_OnSearchClicked(object sender, EventArgs e)
        {
            _ClearDetainInfo();
            await uctrlLicenseInfoBySearch1.DoSearch();
        }
        private void frmDetainedLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ClearDetainInfo();
                uctrlLicenseInfoBySearch1.uctrlLicenseInfoBySearch_KeyDown(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private async void btnDetain_Click(object sender, EventArgs e)
        {
            if (!_CheckFineFeesTextBox())
            { 
                MessageBox.Show("Please enter a valid fine fees amount.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(
                "Are you sure you want to detain this driving license?",
                "Confirm Detain License",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var DetainResult = await _DetainLicenseAsync();

                if (!DetainResult.IsDetained)
                {
                    MessageBox.Show("License detain failed",
                        "Detain Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lbDetainIDResult.Text = DetainResult.DetainID.ToString();
                llbShowNewLicense.Enabled = true;
                groupBox1.Enabled = false;

                MessageBox.Show(
                    $"License detained successfully!\nDetain ID: {DetainResult.DetainID}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while detaining the license:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDetain.Enabled = false;
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
        private void txtFineFeesResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFineFeesResult, "Please enter digits only.");
                return;
            }
            errorProvider1.SetError(txtFineFeesResult, string.Empty);
        }
        #endregion
    }
}
