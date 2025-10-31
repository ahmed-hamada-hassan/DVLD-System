using DVLD_BusinessLayer;
using DVLD_BusinessLayer.CountriesBL;
using DVLD_BusinessLayer.PoepleBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class frmManagePeople : Form
    {
        #region Fields
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private readonly ClsCountriesBusinessLayer _CountriesBL = new ClsCountriesBusinessLayer();
        private readonly Dictionary<byte, string> _CbFilterByOptions = new Dictionary<byte, string>
        {
            { 0, "None" },
            { 1, "PersonID" },
            { 2, "NationalNo" },
            { 3, "FirstName" },
            { 4, "SecondName" },
            { 5, "ThirdName" },
            { 6, "LastName" },
            { 7, "Gendor" },
            { 8, "CountryName" },
            { 9, "Phone" },
        };
        private Dictionary<int, string> _countriesCache = new Dictionary<int, string>();
        #endregion

        #region Constructor
        public frmManagePeople()
        {
            InitializeComponent();
        }
        private async void frmManagePeople_Load(object sender, EventArgs e)
        {
            await _LoadCountriesCacheAsync();
            _PopulateFilterOptions();
        }
        #endregion

        #region Private Methods
        private void _PopulateFilterOptions()
        {
            cbFilterBy.Items.Clear();

            cbFilterBy.Items.AddRange(new string[] { "None", "Person ID" ,"National No", "First Name", "Second Name", "Third Name",
            "Last Name", "Gendor", "Country Name", "Phone"});
            cbFilterBy.SelectedIndex = 0;
        }
        private void _PopulateGenderTypeOptions()
        {
            cbGenderType.Items.Clear();
            cbGenderType.Items.AddRange(new string[] { "None", "Male", "Female" });
            cbGenderType.SelectedIndex = 0;
        }
        private void _ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if(dataGridView1.Columns.Contains("PersonID"))
                dataGridView1.Columns["PersonID"].HeaderText = "Person ID";
            if(dataGridView1.Columns.Contains("NationalNo"))
                dataGridView1.Columns["NationalNo"].HeaderText = "National No.";
            if(dataGridView1.Columns.Contains("FirstName"))
                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
            if(dataGridView1.Columns.Contains("SecondName"))
                dataGridView1.Columns["SecondName"].HeaderText = "Second Name";
            if(dataGridView1.Columns.Contains("ThirdName"))
                dataGridView1.Columns["ThirdName"].HeaderText = "Third Name";
            if(dataGridView1.Columns.Contains("LastName"))
                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
            if(dataGridView1.Columns.Contains("Phone"))
                dataGridView1.Columns["Phone"].HeaderText = "Phone";
            if (dataGridView1.Columns.Contains("Email"))
                dataGridView1.Columns["Email"].HeaderText = "Email";
            if (dataGridView1.Columns.Contains("CountryName"))
                dataGridView1.Columns["CountryName"].HeaderText = "Country Name";
            if (dataGridView1.Columns.Contains("Gender"))
                dataGridView1.Columns["Gender"].HeaderText = "Gender";
            if (dataGridView1.Columns.Contains("DateOfBirth"))
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            
        }
        private async Task _PopulatePeopleDataGridView()
        {
            dataGridView1.DataSource = null;
            var People = await _PeopleBL.GetPeopleAsync();
            dataGridView1.DataSource = People;
            _ConfigureDataGridView();
            lbRecordsResult.Text = People.Count.ToString();
        }
        private async Task _LoadCountriesCacheAsync()
        {
            var countries = await _CountriesBL.GetAllCountriesAsync();
            _countriesCache = countries.ToDictionary(c => c.CountryID,
                                                     c => c.CountryName);
        }
        #endregion

        #region Public Methods
        public async Task RefreshPeopleDataGridView()
        {
            await _PopulatePeopleDataGridView();
        }
        #endregion

        #region Form's Event Handlers
        private async void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                cbGenderType.Visible = false;
                await _PopulatePeopleDataGridView();
                return;
            }
            if(cbFilterBy.SelectedIndex == 7)
            {
                txtSearch.Visible = false;
                cbGenderType.Visible = true;
                _PopulateGenderTypeOptions();
                return;
            }
            txtSearch.Clear();
            txtSearch.Visible = true;
            cbGenderType.Visible = false;
        }
        private async void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            using (frmAddAndEditPerson frm = new frmAddAndEditPerson())
            {
                frm.Owner = this;
                frm.SavedPerson += async (newPerson) =>
                {
                    await _PeopleBL.AddNewPersonAsync(newPerson);
                };

                frm.ShowDialog();
            }
        }
        private async void cmsEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int PersonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                ClsPerson person = await _PeopleBL.GetPersonByIDAsync(PersonID);

                using (frmAddAndEditPerson form2 = new frmAddAndEditPerson(person))
                {
                    form2.Owner = this;
                    form2.UpdatedPerson += async (newUpdatedPerson) =>
                    {
                        await _PeopleBL.UpdatePersonInfoAsync(person);
                    };

                    form2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a person to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmsAddNewPerson_Click(object sender, EventArgs e)
        {
            using (frmAddAndEditPerson frm = new frmAddAndEditPerson())
            {
                frm.Owner = this;
                frm.SavedPerson += async (newPerson) =>
                {
                    await _PeopleBL.AddNewPersonAsync(newPerson);
                };

                frm.ShowDialog();
            }
        }
        private void btnCancelManagePeople_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void cmsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int PersonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this person?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool deleted = await _PeopleBL.DeletePersonAsync(PersonID);
                    if (deleted)
                    {
                        MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await _PopulatePeopleDataGridView();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Person wasn't deleted because it has data linked to it.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a person to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int PersonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                using (var ShowDetails = new frmShowPersonDetails(PersonID))
                {
                    ShowDetails.Owner = this;
                    ShowDetails.ShowDialog();
                }
                return;
            }
            else
            {
                MessageBox.Show("Please select a person to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string SelectedFilter = cbFilterBy.SelectedItem.ToString();

            if (SelectedFilter == "Person ID" || SelectedFilter == "National No" || SelectedFilter == "Phone")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "Please enter digits only.");
                }
                else
                {
                    errorProvider1.SetError(txtSearch, string.Empty);
                }
            }
            else if (SelectedFilter == "Gendor")
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
                if (!char.IsControl(e.KeyChar) && e.KeyChar != 'M' && e.KeyChar != 'F')
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "Please enter 'M' or 'F'");
                }
                else
                {
                    errorProvider1.SetError(txtSearch, string.Empty);
                }
            }
            else if (SelectedFilter == "First Name" || SelectedFilter == "Second Name" || SelectedFilter == "Third Name" 
                || SelectedFilter == "Last Name")
            {
                if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "Please enter letters only");
                }
                else
                {
                    errorProvider1.SetError (txtSearch, string.Empty);
                }
            }
            else if (SelectedFilter == "Nationality")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtSearch, "Please enter only letters");
                }
                else
                {
                    errorProvider1.SetError(txtSearch, string.Empty);
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dataGridView1.DataSource = null;
                var People = await _PeopleBL.FilterPeopleAccordingByAsync(_CbFilterByOptions[(byte)cbFilterBy.SelectedIndex],
                    txtSearch.Text.Trim());
                dataGridView1.DataSource = People;
                _ConfigureDataGridView();
                lbRecordsResult.Text = People.Count.ToString();
                return;
            }
            await _PopulatePeopleDataGridView();
        }
        private async void cbGenderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbGenderType.SelectedIndex)
            {
                case 0:
                    await _PopulatePeopleDataGridView();
                    break;
                case 1:
                    dataGridView1.DataSource = null;
                    var People = await _PeopleBL.FilterPeopleAccordingByGenderAsync('M');
                    dataGridView1.DataSource = People;
                    _ConfigureDataGridView();
                    lbRecordsResult.Text = People.Count.ToString();
                    break;
                case 2:
                    dataGridView1.DataSource = null;
                    var People1 = await _PeopleBL.FilterPeopleAccordingByGenderAsync('F');
                    dataGridView1.DataSource = People1;
                    _ConfigureDataGridView();
                    lbRecordsResult.Text = People1.Count.ToString();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
