using DVLD_BusinessLayer.License_BL;
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
    public partial class frmShowLicenseInfo : Form
    {

        public frmShowLicenseInfo(ClsLicenseAndDriverInfo DriverLicenseInfo)
        {
            InitializeComponent();
            uctrlLicenseInfo1.DisplayData(DriverLicenseInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
