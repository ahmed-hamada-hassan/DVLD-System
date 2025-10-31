using DVLD_BusinessLayer;
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
    public partial class frmShowLicenseHistory : Form
    {
        private ClsLicenseAndDriverInfo _CurrentLicenseInfo = null;
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        public frmShowLicenseHistory(ClsLicenseAndDriverInfo LicenseInfo)
        {
            InitializeComponent();
            _CurrentLicenseInfo = LicenseInfo;
        }

        private async void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            await uctrlDriverLicenses1.DisplayDriverLicensesInfo(_CurrentLicenseInfo);
            var Person = await _PeopleBL.GetPersonByIDAsync(_CurrentLicenseInfo.PersonID);
            await uCtrlShowPersonInfo1.LoadPersonInfo(Person);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
