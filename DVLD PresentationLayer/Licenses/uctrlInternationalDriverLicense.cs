using DVLD_BusinessLayer.License_BL.International_License_BL;
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
    public partial class uctrlInternationalDriverLicense : UserControl
    {
        public uctrlInternationalDriverLicense()
        {
            InitializeComponent();
        }

        public async Task DisplayInternationalLicenseInfo(ClsInternationalLicenseInfo InternationalLicenseInfo)
        {
            lbNameResult.Text = InternationalLicenseInfo.FullName;
            lbInternationalLicenseIDResult.Text = InternationalLicenseInfo.InternationalLicenseID.ToString();
            lbLicenseIDResult.Text = InternationalLicenseInfo.LocalLicenseID.ToString();
            lbNationalNoResult.Text = InternationalLicenseInfo.NationalNumber;
            lbGenderResult.Text = InternationalLicenseInfo.Gender.ToString();
            lbIssueDateResult.Text = InternationalLicenseInfo.IssueDate.ToString("dd/MMM/yyyy");
            lbApplicationIDResult.Text = InternationalLicenseInfo.ApplicationID.ToString();
            lbIsActiveResult.Text = InternationalLicenseInfo.IsActive ? "Yes" : "No";
            lbDateOfBirthResult.Text = InternationalLicenseInfo.DateOfBirth.ToString("dd/MMM/yyyy");
            lbDriverIDResult.Text = InternationalLicenseInfo.DriverID.ToString();
            lbExpirationDateResult.Text = InternationalLicenseInfo.ExpirationDate.ToString("dd/MMM/yyyy");
            pictureBox1.Image = !string.IsNullOrEmpty(InternationalLicenseInfo.ImagePath) ?
                await ClsImageServices.LoadImageAsync(InternationalLicenseInfo.ImagePath) :
                InternationalLicenseInfo.Gender == 'M' ? Resources.male : Resources.feminism;
        }
    }
}
