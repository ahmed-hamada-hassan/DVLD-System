using DVLD_BusinessLayer;
using DVLD_BusinessLayer.CountriesBL;
using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.Services;
using DVLD_PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.People
{
    public partial class UCtrlAddAndEditPerson : UserControl
    {
        #region Private Fields
        private CancellationTokenSource _ctsNationalNo;
        private ClsPerson _Person;
        private string _ImageToDelete;
        public string ImageToDelete => _ImageToDelete;
        public string CurrentImagePath { get; private set; }
        #endregion

        public UCtrlAddAndEditPerson()
        {
            InitializeComponent();
            _Person = new ClsPerson();
        }

        #region Public Methods
        public ClsPerson GetPerson()
        {
            ClsPerson Person = new ClsPerson();

            Person.FirstName            = txtFirstName.Text;
            Person.SecondName           = txtSecondName.Text;
            Person.ThirdName            = txtThirdName.Text;
            Person.LastName             = txtLastName.Text;
            Person.NationalNo           = txtNationalNo.Text;
            Person.DateOfBirth          = dtpDateOfBirth.Value;
            Person.Gendor               = rbMale.Checked ? 'M' : 'F';
            Person.Phone                = txtPhone.Text;
            Person.Email                = txtEmail.Text;
            Person.NationalityCountryID = (int)cbCountry.SelectedValue;
            Person.Address              = txtAddress.Text;
            Person.ImagePath            = CurrentImagePath;

            return Person;
        }
        public async Task LoadPerson(ClsPerson Person)
        {
            _Person = Person;
            txtFirstName.Text = Person.FirstName;
            txtSecondName.Text = Person.SecondName;
            txtThirdName.Text = Person.ThirdName;
            txtLastName.Text = Person.LastName;

            txtNationalNo.Leave -= CheckNationalNoTextBoxForAddingLeaveAsync;
            txtNationalNo.Leave += CheckNationalNoTextBoxForEditingLeaveAsync;
            txtNationalNo.Text = Person.NationalNo;

            dtpDateOfBirth.Value = Person.DateOfBirth;
            rbMale.Checked = Person.Gendor == 'M' ? true : false;
            rbFemale.Checked = Person.Gendor == 'F' ? true : false;
            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email;
            cbCountry.SelectedValue = Person.NationalityCountryID;
            txtAddress.Text = Person.Address;

            CurrentImagePath = Person.ImagePath;
            if (CurrentImagePath != null)
                pictureBox1.Image = await ClsImageServices.LoadImageAsync(CurrentImagePath);
            else
                DefualtImage();
        }
        public async Task FillingCountriesInComboBoxAsync()
        {
            ClsCountriesBusinessLayer Countries = new ClsCountriesBusinessLayer();
            var countries = await Countries.GetAllCountriesAsync();
            
            
            cbCountry.DisplayMember             = "CountryName";
            cbCountry.ValueMember               = "CountryID";
            cbCountry.DataSource                = countries;

            cbCountry.SelectedValue = countries.First().CountryID;
        }
        public async Task<bool> IsDataValidToSaveItAsync()
        {
            bool IsValid = true;

            IsValid &= ClsPersonValidateServices.ValidateField(txtFirstName.Text, ClsPersonValidateServices.NamePattern
                , ClsPersonValidateServices.NameError, "First Name").IsValid;
            IsValid &= ClsPersonValidateServices.ValidateField(txtSecondName.Text, ClsPersonValidateServices.NamePattern
                , ClsPersonValidateServices.NameError, "Second Name").IsValid;
            IsValid &= ClsPersonValidateServices.ValidateField(txtThirdName.Text, ClsPersonValidateServices.NamePattern
                 , ClsPersonValidateServices.NameError, "Third Name").IsValid;
            IsValid &= ClsPersonValidateServices.ValidateField(txtLastName.Text, ClsPersonValidateServices.NamePattern
                , ClsPersonValidateServices.NameError, "Last Name").IsValid;

            var nationalValidationNotRepeated = await ClsPersonValidateServices.ValidateNationalNumber(txtNationalNo.Text
                                                             , _Person.PersonID);

            IsValid &= (ClsPersonValidateServices.ValidateField(txtNationalNo.Text, ClsPersonValidateServices.NationalNoPattern
                , ClsPersonValidateServices.NationalNoError, "National Number").IsValid && nationalValidationNotRepeated.IsValid);
            IsValid &= ClsPersonValidateServices.ValidateField(txtPhone.Text, ClsPersonValidateServices.PhonePattern
                , ClsPersonValidateServices.PhoneError, "Phone").IsValid;
            IsValid &= ClsPersonValidateServices.ValidateField(txtEmail.Text, ClsPersonValidateServices.EmailPattern
                , ClsPersonValidateServices.EmailError, "Email").IsValid;
            IsValid &= ClsPersonValidateServices.ValidateField(txtAddress.Text, ClsPersonValidateServices.AddressPattern
                , ClsPersonValidateServices.AddressError, "Address").IsValid;

            return IsValid;
        }
        public void LoadImage(string ImagePath)
        {
            if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                pictureBox1.Image?.Dispose();
                Task.Run(() =>
                {
                    using (var img = Image.FromFile(ImagePath))
                    {
                        var bmp = new Bitmap(img);
                        pictureBox1?.Invoke((Action)(() => pictureBox1.Image = bmp));
                    }
                });
                CurrentImagePath = ImagePath;
                llbRemove.Visible = true;
            }
            else
            {
                DefualtImage();
                llbRemove.Visible = false;
                CurrentImagePath = null;
            }
        }
        public async Task DefaultSettingsForUserControlAsync()
        {
            CurrentImagePath = null;
            rbMale.Checked = true;
            await FillingCountriesInComboBoxAsync();
            this.ResetText();
        }
        public void ShowUpPersonID(int PersonID)
        {
            lbNA.Text = PersonID.ToString();
        }
        public void ReturnImageToDeleteToNull()
        {
            _ImageToDelete = null;
        }
        #endregion

        #region Private Methods
        private void CheckTextBoxName(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text) &&
                    ClsPersonValidateServices.Validate(textBox.Text, ClsPersonValidateServices.NamePattern))
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    textBox.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(textBox, ClsPersonValidateServices.NameError);
                    textBox.BackColor = Color.LightPink;
                }
            }
        }
        private void EnglishCharactersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only English letters (A-Z, a-z), space, and control keys (Backspace, Delete, etc.)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }

            // Block non-English characters (characters outside ASCII range for English letters)
            if (char.IsLetter(e.KeyChar) && (e.KeyChar < 'A' || (e.KeyChar > 'Z' && e.KeyChar < 'a') || e.KeyChar > 'z'))
            {
                e.Handled = true;
            }
        }
        private async void CheckNationalNoTextBoxForAddingLeaveAsync(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                _ctsNationalNo?.Cancel();
                _ctsNationalNo?.Dispose();
                _ctsNationalNo = new CancellationTokenSource();
                var token = _ctsNationalNo.Token;
                try
                {
                    var validationNationalNo = await ClsPersonValidateServices.ValidateNationalNumber(txtNationalNo.Text);

                    if (token.IsCancellationRequested) return;
                    if (!string.IsNullOrWhiteSpace(textBox.Text) && validationNationalNo.IsValid)
                    {
                        errorProvider1.SetError(textBox, string.Empty);
                        textBox.BackColor = Color.White;
                    }
                    else
                    {
                        errorProvider1.SetError(textBox, validationNationalNo.ErrorMessage);
                        textBox.BackColor = Color.LightPink;
                    }
                }
                catch (OperationCanceledException)
                { }
            }
        }
        private async void CheckNationalNoTextBoxForEditingLeaveAsync(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                _ctsNationalNo?.Cancel();
                _ctsNationalNo?.Dispose();
                _ctsNationalNo = new CancellationTokenSource();
                var token = _ctsNationalNo.Token;
                var validateNationalNo = await ClsPersonValidateServices.ValidateNationalNumber(textBox.Text, _Person.PersonID);

                if (token.IsCancellationRequested) return;
                if (!string.IsNullOrWhiteSpace(textBox.Text) && validateNationalNo.IsValid)
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    textBox.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(textBox, validateNationalNo.ErrorMessage);
                    textBox.BackColor = Color.LightPink;
                }
            }
        }
        private void CheckPhoneTextBox(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text) &&
                    ClsPersonValidateServices.Validate(textBox.Text, ClsPersonValidateServices.PhonePattern))
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    textBox.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(textBox, ClsPersonValidateServices.PhoneError);
                    textBox.BackColor = Color.LightPink;
                }
            }
        }
        private void CheckEmailTextBox(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text) &&
                    ClsPersonValidateServices.Validate(textBox.Text, ClsPersonValidateServices.EmailPattern))
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    textBox.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(textBox, ClsPersonValidateServices.EmailError);
                    textBox.BackColor = Color.LightPink;
                }
            }
        }
        private void CheckAddressTextBox(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text) &&
                    ClsPersonValidateServices.Validate(textBox.Text, ClsPersonValidateServices.AddressPattern))
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    textBox.BackColor = Color.White;
                }
                else
                {
                    errorProvider1.SetError(textBox, ClsPersonValidateServices.AddressError);
                    textBox.BackColor = Color.LightPink;
                }
            }
        }
        private void DefualtImage()
        {
            if (string.IsNullOrEmpty(CurrentImagePath))
            {
                pictureBox1.Image = rbMale.Checked ? Resources.male : Resources.feminism;
            }
        }
        private async Task CleanUpPreviousImage(string ImagePath)
        {
            var CurrentImagePath = this.CurrentImagePath;
            if (string.IsNullOrEmpty(CurrentImagePath))
                return;
            if (CurrentImagePath != _Person.ImagePath && CurrentImagePath != ImagePath)
                await Task.Run(() => ClsImageServices.DeleteImageAsync(CurrentImagePath));
        }
        #endregion

        #region Event Handlers
        private async void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Choose an Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(!ClsImageServices.IsValidImageFile(openFileDialog1.FileName))
                {
                    MessageBox.Show("Please select a valid image file.", "Invalid File",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newImagePath = await ClsImageServices.SaveImageAsync(openFileDialog1.FileName);
                if(!string.IsNullOrEmpty(newImagePath))
                {
                    await CleanUpPreviousImage(newImagePath);

                    LoadImage(newImagePath);

                }
            }
        }
        private async void llbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = null;

                if (!string.IsNullOrEmpty(CurrentImagePath))
                {
                    if (CurrentImagePath != _Person.ImagePath)
                        await ClsImageServices.DeleteImageAsync(CurrentImagePath);
                    else
                    {
                        _ImageToDelete = CurrentImagePath;
                        _Person.ImagePath = null;
                    }

                    CurrentImagePath = null;
                }
                llbRemove.Visible = false;
                CurrentImagePath = null;
                DefualtImage();
            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentImagePath))
                pictureBox1.Image = Resources.male;
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentImagePath))
                pictureBox1.Image = Resources.feminism;
        }
        #endregion

    }
}