using DVLD_BusinessLayer.Drivers_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Drivers
{
    public partial class frmManageDrivers : Form
    {
        #region Fields
        private readonly ClsDriversBL _DriversBL = new ClsDriversBL();
        private Dictionary<int, string> _cbFilterByOptions = new Dictionary<int, string>()
        {
            {1, "DriverID" },
            {2, "PersonID" },
            {3, "NationalNo" },
            {4, "FullName" }
        };
        #endregion

        #region Constructors
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _PopulateComboBoxFilterBy();
        }
        #endregion

        #region Private Methods
        private void _ConfigureDriversDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (dataGridView1.Columns.Contains("DriverID"))
                dataGridView1.Columns["DriverID"].HeaderText = "Driver ID";
            if (dataGridView1.Columns.Contains("PersonID"))
                dataGridView1.Columns["PersonID"].HeaderText = "Person ID";
            if (dataGridView1.Columns.Contains("NationalNo"))
                dataGridView1.Columns["NationalNo"].HeaderText = "National No.";
            if (dataGridView1.Columns.Contains("FullName"))
                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
            if (dataGridView1.Columns.Contains("CreatedDate"))
                dataGridView1.Columns["CreatedDate"].HeaderText = "Created Date";
            if (dataGridView1.Columns.Contains("ActiveLicenses"))
                dataGridView1.Columns["ActiveLicenses"].HeaderText = "Active Licenses";
        }
        private async Task _PopulateDriversDataGridView()
        {
            dataGridView1.DataSource = null;
            var Drivers = await _DriversBL.GetDriversAsync();
            dataGridView1.DataSource = Drivers;
            _ConfigureDriversDataGridView();
            lbRecordsResult.Text = Drivers.Count.ToString();
        }
        private void _PopulateComboBoxFilterBy()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(new[] { "Select Filter", "Driver ID", "Person ID", "National No.", "Full Name" });
            cbFilterBy.SelectedIndex = 0;
        }
        #endregion

        #region Form's Event Handlers
        private async void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                txtSearched.Visible = false;
                await _PopulateDriversDataGridView();
                return;
            }
            txtSearched.Clear();
            txtSearched.Visible = true;
        }
        private async void txtSearched_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearched.Text))
            {
                dataGridView1.DataSource = null;
                var Drivers = await _DriversBL.
                    FilterDriversAccordingByAsync(_cbFilterByOptions[cbFilterBy.SelectedIndex], txtSearched.Text);
                dataGridView1.DataSource = Drivers;
                _ConfigureDriversDataGridView();
                lbRecordsResult.Text = Drivers.Count.ToString();
                return;
            }
            await _PopulateDriversDataGridView();
        }
        private void txtSearched_KeyPress(object sender, KeyPressEventArgs e)
        {
            var SelectedFilter = cbFilterBy.SelectedItem.ToString();
            if (SelectedFilter == "Driver ID" || SelectedFilter == "Person ID" || SelectedFilter == "National No.")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearched, "Please enter digits only.");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtSearched, string.Empty);
                    return;
                }
            }
            if (SelectedFilter == "Full Name")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearched, "Please enter digits only.");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtSearched, string.Empty);
                    return;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
