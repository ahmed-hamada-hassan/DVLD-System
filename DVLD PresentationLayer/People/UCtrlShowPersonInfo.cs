using DVLD_BusinessLayer;
using DVLD_BusinessLayer.CountriesBL;
using DVLD_BusinessLayer.PoepleBL;
using DVLD_PresentationLayer.Properties;
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
    public partial class UCtrlShowPersonInfo : UserControl
    {
        public ClsPerson CurrentPerson { get; private set; }

        private readonly ClsCountriesBusinessLayer _CountriesBL = new ClsCountriesBusinessLayer();
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private Dictionary<int, string> _countriesCache;

        public UCtrlShowPersonInfo()
        {
            InitializeComponent();
        }

        private async Task LoadCountriesCacheAsync()
        {
            var countries = await _CountriesBL.GetAllCountriesAsync();
            _countriesCache = countries.ToDictionary(c => c.CountryID, c => c.CountryName);
        }

        public async Task LoadPersonInfo(ClsPerson person)
        {
            CurrentPerson = person;
            
            // Ensure the countries cache is loaded before using it
            if (_countriesCache == null)
            {
                await LoadCountriesCacheAsync();
            }
            
            lbPersonIDValue.Text = person.PersonID.ToString();
            lbNameValue.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            lbNationalNoValue.Text = person.NationalNo;
            if (person.Gendor == 'M') lbGendorValue.Text = "Male"; else lbGendorValue.Text = "Female";
            lbEmailValue.Text = person.Email;
            lbAddressValue.Text = person.Address;
            lbDateOfBirthOfValue.Text = person.DateOfBirth.ToShortDateString();
            lbPhoneValue.Text = person.Phone;
            lbCountryValue.Text = _countriesCache.ContainsKey(person.NationalityCountryID)
                                  ? _countriesCache[person.NationalityCountryID]
                                  : "Unknown";
            if (!string.IsNullOrEmpty(person.ImagePath) && System.IO.File.Exists(person.ImagePath))
            {
                using (var img = Image.FromFile(person.ImagePath))
                    pictureBox1.Image = new Bitmap(img);
            }
            else
            {
                if (CurrentPerson.Gendor == 'M')
                    pictureBox1.Image = Resources.male;
                else
                    pictureBox1.Image = Resources.feminism;
            }
        }

        private async void llbEditPersonInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentPerson == null)
            {
                MessageBox.Show("No person is loaded to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PersonID = CurrentPerson.PersonID;

            var Person = await _PeopleBL.GetPersonByIDAsync(PersonID);

            frmAddAndEditPerson frmAddAndEdit = new frmAddAndEditPerson(Person);
            frmAddAndEdit.UpdatedPerson += async ( updatedPerson) => { await LoadPersonInfo(updatedPerson); };
            frmAddAndEdit.ShowDialog();
        }

        private async void UCtrlShowPersonInfo_Load(object sender, EventArgs e)
        {
            await LoadCountriesCacheAsync();
        }

        public void ClearPersonInfo()
        {
            CurrentPerson = null;

            lbPersonIDValue.Text = "???";
            lbNameValue.Text = "???";
            lbNationalNoValue.Text = "???";
            lbGendorValue.Text = "???";
            lbEmailValue.Text = "???";
            lbAddressValue.Text = "???";
            lbDateOfBirthOfValue.Text = "???";
            lbPhoneValue.Text = "???";
            lbCountryValue.Text = "???";

            pictureBox1.Image = null;
        }

        
    }
}
