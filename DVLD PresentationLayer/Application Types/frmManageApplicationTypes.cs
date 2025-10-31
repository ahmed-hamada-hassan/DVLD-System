using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_PresentationLayer.Application_Types;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmManageApplicationTypes : Form
    {
        ClsApplicationTypesBusinessLayer _AppBL = new ClsApplicationTypesBusinessLayer();
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }
        private async void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            await PopulateDataGridViewForApplicationTypes();
            _ConfigureApplicationTypesGridColumns();
            await _CountRecords();
        }

        private void _ConfigureApplicationTypesGridColumns()
        {
            if (dgvManageApplicationTypes.Columns.Contains("ApplicationTypeID"))
                dgvManageApplicationTypes.Columns["ApplicationTypeID"].HeaderText = "Application Type ID";
            if (dgvManageApplicationTypes.Columns.Contains("ApplicationTypeTitle"))
                dgvManageApplicationTypes.Columns["ApplicationTypeTitle"].HeaderText = "Application Type Title";
            if (dgvManageApplicationTypes.Columns.Contains("ApplicationFees"))
                dgvManageApplicationTypes.Columns["ApplicationFees"].HeaderText = "Application Fees";
        }
        public async Task PopulateDataGridViewForApplicationTypes()
        {
            dgvManageApplicationTypes.DataSource = await _AppBL.GetApplicationTypesAsync();
        }
        private async Task _CountRecords()
        {
            var Counter = await _AppBL.CountApplicationTypesAsync();
            lbRecordsResult.Text = Counter.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageApplicationTypes.Rows.Count > 0)
            {
                int AppID = (int)dgvManageApplicationTypes.SelectedRows[0].Cells[0].Value;
                using (var UpdateApplicationType = new frmUpdateApplicationType(AppID))
                {
                    UpdateApplicationType.Owner = this;
                    UpdateApplicationType.ShowDialog();
                }
            }

        }
    }
}
