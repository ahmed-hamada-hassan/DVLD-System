using DVLD_BusinessLayer.License_BL.International_License_BL;
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
    public partial class frmShowDriverInternationalLicenseInfo : Form
    {
        private readonly ClsInternationalLicenseInfo _InternationalLicenseInfo = null;
        public frmShowDriverInternationalLicenseInfo(ClsInternationalLicenseInfo InternationalLicenseInfo)
        {
            InitializeComponent();
            _InternationalLicenseInfo = InternationalLicenseInfo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frmShowDriverInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            await uctrlInternationalDriverLicense1.DisplayInternationalLicenseInfo(_InternationalLicenseInfo);
        }
    }
}
