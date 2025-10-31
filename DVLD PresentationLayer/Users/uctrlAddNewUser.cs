using DVLD_BusinessLayer;
using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.Services;
using DVLD_BusinessLayer.UserBL;
using DVLD_PresentationLayer.People;
using DVLD_PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class uctrlAddNewUser : UserControl
    {
        #region Fields , Properties , Events
        private readonly ClsPeopleBusinessLayer _PeopleBl = new ClsPeopleBusinessLayer();
        private ClsPerson _CurrentPerson;

        [Browsable(false)]
        public ClsPerson CurrentPerson
        {
            get => _CurrentPerson;
            private set => _CurrentPerson = value;
        }
        public event Action<ClsPerson> PersonChanged;
        #endregion

        #region Constructor
        public uctrlAddNewUser()
        {
            InitializeComponent();
            _PopulateFilterComboBox();
        }
        #endregion

        #region Events Handlers
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string SelectedFilter = cbFilterBy.SelectedItem.ToString();
            if (SelectedFilter == "National No" || SelectedFilter == "Person ID")
            {
                bool isValidChar = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);
                e.Handled = !isValidChar;
                errorProvider1.SetError(txtSearch, isValidChar ? string.Empty : "Please enter only digits.");
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var Person = await _SearchPersonAsync();
            if (Person == null)
            {
                MessageBox.Show("No person found with the provided information.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            await uctrlShowPersonInfo.LoadPersonInfo(CurrentPerson);
            PersonChanged?.Invoke(CurrentPerson);
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = cbFilterBy.SelectedIndex != 0;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frmAddPerson = new frmAddAndEditPerson())
            {
                frmAddPerson.ShowDialog();
                
                if (frmAddPerson.CurrentPerson != null)
                {
                    this.CurrentPerson = frmAddPerson.CurrentPerson;
                    await uctrlShowPersonInfo.LoadPersonInfo(CurrentPerson);
                    cbFilterBy.SelectedIndex = 1;
                    txtSearch.Text = CurrentPerson.PersonID.ToString();
                    PersonChanged?.Invoke(CurrentPerson);
                }
            }
        }
        #endregion

        #region Private Methods
        private void _PopulateFilterComboBox()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(new[] { "Select Filter", "Person ID", "National No" });
            cbFilterBy.SelectedIndex = 0;
        }
        private async Task<ClsPerson> _SearchPersonAsync()
        {
            if (cbFilterBy.SelectedIndex == 1 && int.TryParse(txtSearch.Text, out int PersonID))
                return CurrentPerson = await _PeopleBl.GetPersonByIDAsync(PersonID);
            if (cbFilterBy.SelectedIndex == 2)
                return CurrentPerson = await _PeopleBl.GetPersonByNationalNoAsync(txtSearch.Text.Trim());
            return null;
        }
        #endregion

        #region Public Methods
        public async Task LoadPersonInfoAsync(ClsPerson Person)
        {
            if (Person == null) return;
            await uctrlShowPersonInfo.LoadPersonInfo(Person);
            txtSearch.Text = Person.PersonID.ToString();
            cbFilterBy.SelectedIndex = 1;
            gpFilterBy.Enabled = false;
            CurrentPerson = Person;
        }
        public void Reset()
        {
            uctrlShowPersonInfo.ClearPersonInfo();
            txtSearch.Clear();
            CurrentPerson = null;
        }
        #endregion

        
    }
}
