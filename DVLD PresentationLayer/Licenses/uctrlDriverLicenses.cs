using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Drivers_BL;
using DVLD_BusinessLayer.License_BL;
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
    public partial class uctrlDriverLicenses : UserControl
    {
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly ClsInternationalLicensesBL _InternationalLicensesBL = new ClsInternationalLicensesBL();

        public uctrlDriverLicenses()
        {
            InitializeComponent();
        }
        public async Task DisplayDriverLicensesInfo(ClsLicenseAndDriverInfo CurrentDriverAndHisLicenseInfo)
        {
            await _PopulateLocalDrivingLicensesDataGridView(CurrentDriverAndHisLicenseInfo);
            await _PopulateInternationalDrivingLicensesDataGridView(CurrentDriverAndHisLicenseInfo);
        }
        private void _ConfigureLocalDataGridView()
        {
            if (dgvLocal.Columns.Contains("LicenseID"))
                dgvLocal.Columns["LicenseID"].HeaderText = "License ID";

            if (dgvLocal.Columns.Contains("ApplicationID"))
                dgvLocal.Columns["ApplicationID"].HeaderText = "Application ID";

            if (dgvLocal.Columns.Contains("ClassName"))
                dgvLocal.Columns["ClassName"].HeaderText = "Class Name";

            if (dgvLocal.Columns.Contains("IssueDate"))
                dgvLocal.Columns["IssueDate"].HeaderText = "Issue Date";

            if (dgvLocal.Columns.Contains("ExpirationDate"))
                dgvLocal.Columns["ExpirationDate"].HeaderText = "Expiration Date";

            if (dgvLocal.Columns.Contains("IsActive"))
                dgvLocal.Columns["IsActive"].HeaderText = "Is Active";
        }
        private void _ConfigureInternationslDataGridView()
        {
            if(dgvInternational.Columns.Contains("InternationalLicenseID"))
                dgvInternational.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";

            if(dgvInternational.Columns.Contains("ApplicantionID"))
                dgvInternational.Columns["ApplicantionID"].HeaderText = "Applicantion ID";

            if(dgvInternational.Columns.Contains("IssuedUsingLocalLicenseID"))
                dgvInternational.Columns["IssuedUsingLocalLicenseID"].HeaderText = "Local License ID";

            if(dgvInternational.Columns.Contains("IssueDate"))
                dgvInternational.Columns["IssueDate"].HeaderText = "Issue Date";

            if(dgvInternational.Columns.Contains("ExpirationDate"))
                dgvInternational.Columns["ExpirationDate"].HeaderText = "Expiration Date";

            if(dgvInternational.Columns.Contains("IsActive"))
                dgvInternational.Columns["IsActive"].HeaderText = "Is Active";
        }
        private async Task _PopulateLocalDrivingLicensesDataGridView(ClsLicenseAndDriverInfo DriverAndHisLicensesInfo)
        {
            var LocalLicenses = await _LicenseBL.GetAllLicensesByDriverIDAsync(DriverAndHisLicensesInfo.DriverID);
            var LocalLicensesForView = LocalLicenses.Select(License => new 
            { 
                License.LicenseID,
                License.ApplicationID,
                License.ClassName,
                License.IssueDate,
                License.ExpirationDate,
                License.IsActive
            }).ToList();

            dgvLocal.DataSource = LocalLicensesForView;
            _ConfigureLocalDataGridView();
            lbRecordsLocalResult.Text = LocalLicenses.Count.ToString();
        }
        private async Task _PopulateInternationalDrivingLicensesDataGridView(ClsLicenseAndDriverInfo DriverAndHisLicensesInfo)
        {
            var InternationalLicenses = await _InternationalLicensesBL.
                GetAllInternationalLicenseByDriverIDAsync(DriverAndHisLicensesInfo.DriverID);
            if (InternationalLicenses == null) return;
            var InternationalLicensesForView = InternationalLicenses.Select(License => new 
            { 
                License.InternationalLicenseID,
                License.ApplicantionID,
                License.IssuedUsingLocalLicenseID,
                License.IssueDate,
                License.ExpirationDate,
                License.IsActive
            }).ToList();

            dgvInternational.DataSource = InternationalLicensesForView;
            _ConfigureInternationslDataGridView();
            lbRecordsInternationalResult.Text = InternationalLicenses.Count.ToString();
        }
        private async void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cms.SourceControl == dgvLocal)
            {
                if (dgvLocal.SelectedRows.Count == 0) return;
                var SelectedLicenseID = Convert.ToInt32(dgvLocal.SelectedRows[0].Cells[0].Value);
                var LicenseInfo = await _LicenseBL.GetLicenseInfoByLicenseIDAsync(SelectedLicenseID);
                using (var frm = new frmShowLicenseInfo(LicenseInfo))
                {
                    frm.ShowDialog();
                }
            }
            else if(cms.SourceControl == dgvInternational)
            {
                if (dgvInternational.SelectedRows.Count == 0) return;
                var SelectedInternationalLicenseID = Convert.ToInt32(dgvInternational.SelectedRows[0].Cells[0].Value);
                var InternationalLicenseInfo = await _InternationalLicensesBL.
                    GetInternationalLicenseInfoByInternationalLicenseIDAsync(SelectedInternationalLicenseID);
                using (var frm = new frmShowDriverInternationalLicenseInfo(InternationalLicenseInfo))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
