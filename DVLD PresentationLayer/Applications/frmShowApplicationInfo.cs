using DVLD_BusinessLayer;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.Local_Driveing_License_Applications;
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
    public partial class frmShowApplicationInfo : Form
    {
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private ClsLocalDrivingLicense _CurrentLocalDrivingLicenseApplicationInfo = null;

        public frmShowApplicationInfo(ClsLocalDrivingLicense CurrentApplicationInfo)
        {
            InitializeComponent();
            _CurrentLocalDrivingLicenseApplicationInfo = CurrentApplicationInfo;
            uctrlApplicationAndApplicantInfo1.RecieveData(CurrentApplicationInfo);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void uctrlApplicationAndApplicantInfo1_OnClickViewPersonInfo(object sender, EventArgs e)
        {
            using (var ShowPersonInfo = new frmShowPersonDetails(_CurrentLocalDrivingLicenseApplicationInfo.PersonID))
            {
                ShowPersonInfo.ShowDialog();
            }
            var FullName = await _PeopleBL.GetPersonFullNameByIDAsync(_CurrentLocalDrivingLicenseApplicationInfo.PersonID);
            uctrlApplicationAndApplicantInfo1.RefreshApplicationBasicInfo(FullName);
        }
        private async void uctrlApplicationAndApplicantInfo1_OnClickShowLicenseInfo(object sender, EventArgs e)
        {
            var LicenseInfo = await _LicenseBL.GetActiveLicenseByNationalNumberAsync(_CurrentLocalDrivingLicenseApplicationInfo.NationalNo);
            if (LicenseInfo != null)
            {
                using (var ShowLicenseDatails = new frmShowLicenseInfo(LicenseInfo))
                {
                    ShowLicenseDatails.ShowDialog();
                }
                return;
            }
            else
            {
                MessageBox.Show("This person doesn't have license yet", "No License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
