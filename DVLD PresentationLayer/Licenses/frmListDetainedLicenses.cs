using DVLD_BusinessLayer;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.License_BL.Detained_License_BL;
using DVLD_PresentationLayer.People;
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
    public partial class frmListDetainedLicenses : Form
    {
        #region Fields
        private readonly ClsDetainedLicensesBL _DetainedLicenseBL = new ClsDetainedLicensesBL();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private readonly Dictionary<int, string> _CbFilterByOptions = new Dictionary<int, string>()
        { {0,"None" }, {1,"LicenseID" } ,{2,"DetainID" }, {3,"IsReleased" }, {4,"NationalNo" }, {5,"FullName" } };
        #endregion

        #region Constructors
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }
        private async void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _PopulateComboBoxFilterBy();
        }
        #endregion

        #region Private Methods
        private void _ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (dataGridView1.Columns.Contains("DetainID"))
                dataGridView1.Columns["DetainID"].HeaderText = "Detain ID";
            if (dataGridView1.Columns.Contains("LicenseID"))
                dataGridView1.Columns["LicenseID"].HeaderText = "License ID";
            if (dataGridView1.Columns.Contains("DetainDate"))
                dataGridView1.Columns["DetainDate"].HeaderText = "Detain Date";
            if (dataGridView1.Columns.Contains("IsReleased"))
                dataGridView1.Columns["IsReleased"].HeaderText = "Is Released";
            if (dataGridView1.Columns.Contains("FineFees"))
                dataGridView1.Columns["FineFees"].HeaderText = "Fine Fees";
            if (dataGridView1.Columns.Contains("ReleaseDate"))
                dataGridView1.Columns["ReleaseDate"].HeaderText = "Release Date";
            if (dataGridView1.Columns.Contains("NationalNo"))
                dataGridView1.Columns["NationalNo"].HeaderText = "National No.";
            if (dataGridView1.Columns.Contains("FullName"))
                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
            if (dataGridView1.Columns.Contains("ReleaseApplicationID"))
                dataGridView1.Columns["ReleaseApplicationID"].HeaderText = "Release Application ID";
        }
        private void _PopulateComboBoxFilterBy()
        {
            cbFilterBy.Items.AddRange(new string[] { "Select Filter", "Licenses ID", "Detain ID", "IsRelease", "National No.","Full Name" });
            cbFilterBy.SelectedIndex = 0;
            txtSearched.Visible = false;
        }
        private void _PopulateComboBoxIsReleased()
        {
            cbIsReleased.Items.Clear();
            cbIsReleased.Items.AddRange(new string[] { "Select Filter", "Released", "UnReleased" });
            cbIsReleased.SelectedIndex = 0;
        }
        private async Task _PopulateDataGridViewWithData()
        {
            dataGridView1.DataSource = null;
            var DetainedLicenses = await _DetainedLicenseBL.GetAllDetainedLicensesAsync();
            dataGridView1.DataSource = DetainedLicenses;
            lbRecordsResult.Text = DetainedLicenses.Count.ToString();
            _ConfigureDataGridView();
        }
        #endregion

        #region Public Method
        public async Task RefreshDetainedLicensesDataGridView()
        {
            await _PopulateDataGridViewWithData();
        }
        #endregion

        #region Form's Event Handlers
        private void btnRelease_Click(object sender, EventArgs e)
        {
            using (var ReleaseDetainedLicense = new frmReleaseDetainedLicense())
            {
                ReleaseDetainedLicense.Owner = this;
                ReleaseDetainedLicense.ShowDialog();
            }
        }
        private async void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
            {
                txtSearched.Visible = false;
                cbIsReleased.Visible = false;
                await _PopulateDataGridViewWithData();
                return;
            }
            else
            {
                if (cbFilterBy.SelectedIndex == 3)
                {
                    txtSearched.Visible = false;
                    cbIsReleased.Visible = true;
                    _PopulateComboBoxIsReleased();
                    return;
                }

                txtSearched.Visible = true;
                txtSearched.Clear();
                
            }
        }
        private async void txtSearched_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearched.Text))
            {
                dataGridView1.DataSource = null;
                var DetainedLicenses = await _DetainedLicenseBL.
                    FilterDetainedLicensesAccordingByAsync(_CbFilterByOptions[Convert.ToByte(cbFilterBy.SelectedIndex)], txtSearched.Text.Trim());
                dataGridView1.DataSource = DetainedLicenses;
                _ConfigureDataGridView();
                lbRecordsResult.Text = DetainedLicenses.Count.ToString();
                return;
            }
            await _PopulateDataGridViewWithData();
        }
        private async void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbIsReleased.SelectedIndex)
            {
                case 0:
                    await _PopulateDataGridViewWithData();
                    break;
                case 1:
                    dataGridView1.DataSource = null;
                    var DetainedLicensesReleased = await 
                        _DetainedLicenseBL.FilterDetainedLicensesAccordingByReleaseStatusAsync(true);
                    dataGridView1.DataSource= DetainedLicensesReleased;
                    _ConfigureDataGridView();
                    lbRecordsResult.Text = DetainedLicensesReleased.Count.ToString();
                    break;
                case 2:
                    dataGridView1.DataSource = null;
                    var DetainedLicensesUnReleased = await 
                        _DetainedLicenseBL.FilterDetainedLicensesAccordingByReleaseStatusAsync(false);
                    dataGridView1.DataSource= DetainedLicensesUnReleased;
                    _ConfigureDataGridView();
                    lbRecordsResult.Text = DetainedLicensesUnReleased.Count.ToString();
                    break;
                default:
                    break;
            }
        }
        private void txtSearched_KeyPress(object sender, KeyPressEventArgs e)
        {
            string SelectedFilter = cbFilterBy.SelectedItem.ToString();

            if(SelectedFilter == "Licenses ID" || SelectedFilter == "Detain ID" || SelectedFilter == "National No.")
            {
                if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
            if(SelectedFilter == "Full Name")
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
        private void btnDetain_Click(object sender, EventArgs e)
        {
            using (var DetainLicense = new frmDetainedLicense())
            {
                DetainLicense.Owner = this;
                DetainLicense.ShowDialog();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int LicenseID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                var LicenseInfo = await _LicenseBL.GetLicenseInfoByLicenseIDAsync(LicenseID);

                using (var ShowLicenseInfo = new frmShowLicenseInfo(LicenseInfo))
                {
                    ShowLicenseInfo.ShowDialog();
                }
            }
        }
        private async void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int LicenseID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                var LicenseInfo = await _LicenseBL.GetLicenseInfoByLicenseIDAsync(LicenseID);

                using (var ShowPersonLicenseHistory = new frmShowLicenseHistory(LicenseInfo))
                {
                    ShowPersonLicenseHistory.ShowDialog();
                }
            }
        }
        private async void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var NationalNo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                var PersonInfo = await  _PeopleBL.GetPersonByNationalNoAsync(NationalNo);
                using (var ShowPersonDetails = new frmShowPersonDetails(PersonInfo.PersonID))
                {
                    ShowPersonDetails.Owner = this;
                    ShowPersonDetails.ShowDialog();
                }
            }
        }
        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int LicenseID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                using (var ReleaseDetainedLicense = new frmReleaseDetainedLicense(LicenseID))
                {
                    ReleaseDetainedLicense.Owner = this;
                    ReleaseDetainedLicense.ShowDialog();
                }
            }
        }
        #endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool isReleased = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["IsReleased"].Value);
                releaseDetainedLicenseToolStripMenuItem.Enabled = !isReleased;
            }
        }
    }
}
