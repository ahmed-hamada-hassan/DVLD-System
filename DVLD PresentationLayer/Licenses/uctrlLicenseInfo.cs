using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.Services;
using DVLD_PresentationLayer.Properties;
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
    public partial class uctrlLicenseInfo : UserControl
    {
        public uctrlLicenseInfo()
        {
            InitializeComponent();
        }

        public async void DisplayData(ClsLicenseAndDriverInfo DriverLicenseInfo)
        {
            lbClassResult.Text = DriverLicenseInfo.ClassName;
            lbNameResult.Text = DriverLicenseInfo.FullName;
            lbLicenseIDResult.Text = DriverLicenseInfo.LicenseID.ToString();
            lbNationalNoResult.Text = DriverLicenseInfo.NationalNo;
            lbGenderResult.Text = DriverLicenseInfo.Gender == 'M' ? "Male" : "Female";
            lbIssueDateResult.Text = DriverLicenseInfo.IssueDate.ToString("dd/MMM/yyyy");
            lbIssueReasonResult.Text = DriverLicenseInfo.IssueReason;
            lbNotesResult.Text = String.IsNullOrEmpty(DriverLicenseInfo.Notes) ? "No Notes" : DriverLicenseInfo.Notes;
            lbIsActiveResult.Text = DriverLicenseInfo.IsActive == true ? "Yes" : "No";
            lbDateOfBirthResult.Text = DriverLicenseInfo.DateOfBirth.ToString("dd/MMM/yyyy");
            lbDriverIDResult.Text = DriverLicenseInfo.DriverID.ToString();
            lbExpirationDateResult.Text = DriverLicenseInfo.ExpirationDate.ToString("dd/MMM/yyyy");
            lbIsDetainedResult.Text = DriverLicenseInfo.IsDetained;
            pictureBox1.Image = string.IsNullOrEmpty(DriverLicenseInfo.ImagePath) ?
                DriverLicenseInfo.Gender == 'M' ? Resources.male : Resources.feminism :
                await ClsImageServices.LoadImageAsync(DriverLicenseInfo.ImagePath);
        }
    }
}
