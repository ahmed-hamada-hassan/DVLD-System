using DVLD_BusinessLayer.TestTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Test_Types
{
    public partial class frmManageTestTypes : Form
    {
        private ClsTestTypesBusinessLayer _TestTypeBL = new ClsTestTypesBusinessLayer();
        public frmManageTestTypes()
        {
            
            InitializeComponent();
        }
        private void _ConfigureDataGridViewTestTypes()
        {
            if (dgvManageTestType.Columns.Contains("TestTypeID"))
                dgvManageTestType.Columns["TestTypeID"].HeaderText = "Test Type ID";
            if (dgvManageTestType.Columns.Contains("TestTypeTitle"))
                dgvManageTestType.Columns["TestTypeTitle"].HeaderText = "Test Type Title";
            if (dgvManageTestType.Columns.Contains("TestTypeDescription"))
                dgvManageTestType.Columns["TestTypeDescription"].HeaderText = "Test Type Description";
            if (dgvManageTestType.Columns.Contains("TestTypeFees"))
                dgvManageTestType.Columns["TestTypeFees"].HeaderText = "Test Type Fees";

        }
        public async Task PopulateDataGridViewTestTypes()
        {
            var TestTypes = await _TestTypeBL.GetAllTestTypeAsync();
            dgvManageTestType.DataSource = TestTypes;
            lbRecordsResult.Text = TestTypes.Count.ToString();
        }

        private async void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            await PopulateDataGridViewTestTypes();
            _ConfigureDataGridViewTestTypes();
        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvManageTestType.Rows.Count > 0)
            {
                int TestTypeID = (int)dgvManageTestType.SelectedRows[0].Cells[0].Value;
                using (var UpdateTestType = new frmUpdateTestType(TestTypeID))
                {
                    UpdateTestType.Owner = this;
                    UpdateTestType.ShowDialog();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
