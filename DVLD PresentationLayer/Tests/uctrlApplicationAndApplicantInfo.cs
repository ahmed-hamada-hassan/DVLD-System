using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class uctrlApplicationAndApplicantInfo : UserControl
    {
        public event EventHandler OnClickViewPersonInfo;
        public event EventHandler OnClickShowLicenseInfo;

        private ClsLocalDrivingLicense _CurrentLocalDrivingLicenseApplicationInfo = null;

        public uctrlApplicationAndApplicantInfo()
        {
            InitializeComponent();
        }

        public void RecieveData(ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo)
        {
            _CurrentLocalDrivingLicenseApplicationInfo = CurrentLocalDrivingLicenseApplicationInfo;
            _DisplayData();
        }

        public void RefreshDrivingLicenseApplicationInfo(int PassedTest)
        {
            lbPassedTestsResult.Text = $"{PassedTest.ToString()}/3";
        }

        public void RefreshApplicationBasicInfo(string ApplicantName)
        {
            lbApplicantResult.Text = ApplicantName;
        }

        private void _DisplayData()
        {
            lbLDLAPPIDResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
            lbLicenseClassResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.DrivingClassTitle;
            lbPassedTestsResult.Text = $"{_CurrentLocalDrivingLicenseApplicationInfo.PassedTestCount.ToString()}/3";
            lbApplicationIDResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.ApplicationID.ToString();
            lbStatusResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.Status;
            lbFeesResult.Text = string.Format("{0:C2}", _CurrentLocalDrivingLicenseApplicationInfo.PaidFees);
            lbTypeResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.ApplicationTypeTitle;
            lbApplicantResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.FullName;
            lbDateResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.ApplicationDate.ToString("dd/MMM/yyyy hh:mm:ss tt");
            lbStatusDateResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.LastStatusDate.ToString("dd/MMM/yyyy hh:mm:ss tt");
            lbCreatedByResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.CreatedByUserID.ToString();
        }

        private void llbViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnClickViewPersonInfo?.Invoke(this, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnClickShowLicenseInfo?.Invoke(this, EventArgs.Empty);
        }
    }
}
