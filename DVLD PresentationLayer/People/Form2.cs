using DVLD_BusinessLayer;
using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DVLD_PresentationLayer.People
{
    public partial class frmAddAndEditPerson : Form
    {
        #region Fields
        enum EnFormMode { Add = 0, Edit };

        private ClsPeopleBusinessLayer _PeopleBl;
        public ClsPerson CurrentPerson { get; private set; }
        private EnFormMode _Mode;

        public event Action<ClsPerson> SavedPerson;
        public event Action<ClsPerson> UpdatedPerson;
        #endregion

        #region Form's Constructor
        public frmAddAndEditPerson()
        {
            InitializeComponent();

            _Mode = EnFormMode.Add;
        }
        public frmAddAndEditPerson(ClsPerson person) : this()
        {
            _Mode = EnFormMode.Edit;
            CurrentPerson = new ClsPerson();
            CurrentPerson = person;
            label1.Text = "Update Person";
            btnSave.Text = "Update";
        }
        private async void frmAddAndEditPerson_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.Yield();

                await uCtrl1.FillingCountriesInComboBoxAsync();

                UpdateFormTitle();

                if (_Mode == EnFormMode.Edit && CurrentPerson != null)
                {
                    
                    await uCtrl1.LoadPerson(CurrentPerson);
                    uCtrl1.ShowUpPersonID(CurrentPerson.PersonID);
                    uCtrl1.LoadImage(CurrentPerson.ImagePath);
                }
                else
                {
                    uCtrl1.LoadImage(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during form initialization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Form's Event Handlers
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (await uCtrl1.IsDataValidToSaveItAsync())
            {
                if (_Mode == EnFormMode.Add)
                {
                    DialogResult Result = MessageBox.Show("Are you sure from adding this person ?", "Add New Person", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (Result == DialogResult.Yes)
                    {
                        await AddNewPerson();
                        if(this.Owner is frmManagePeople ParentForm)
                            await ParentForm.RefreshPeopleDataGridView();
                        SavedPerson?.Invoke(CurrentPerson);
                    }
                }
                else
                {
                    DialogResult Result = MessageBox.Show("Are you sure from Updating this person ?", "Update Person", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (Result == DialogResult.Yes)
                    {
                        await UpdatePerson();
                        if (this.Owner is frmManagePeople ParentForm)
                            await ParentForm.RefreshPeopleDataGridView();
                        UpdatedPerson?.Invoke(CurrentPerson);
                    }
                }
            }
            else
                MessageBox.Show("Data isn't valid to save it complete your information", "Complete Your Data", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region PrivateMethods
        private void UpdateFormTitle ()
        {
            if (_Mode == EnFormMode.Add)
                Text = "Add New Person";
            else
                Text = "Edit Person";
        }
        private async Task ResetFormAsync()
        {
            await uCtrl1.DefaultSettingsForUserControlAsync();
        }
        private async Task AddNewPerson()
        {
            ClsPerson NewPerson = new ClsPerson();
            NewPerson = uCtrl1.GetPerson();
            _PeopleBl = new ClsPeopleBusinessLayer();
            var success = await _PeopleBl.AddNewPersonAsync(NewPerson);
            if (success)
            {
                MessageBox.Show($"Person added successfully with ID = {NewPerson.PersonID}", "Confirm Add New Person", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                uCtrl1.ShowUpPersonID(NewPerson.PersonID);
                CurrentPerson = NewPerson;

                if(!string.IsNullOrEmpty(uCtrl1.ImageToDelete))
                {
                    await ClsImageServices.RecycleImageAsync(uCtrl1.ImageToDelete);
                    uCtrl1.ReturnImageToDeleteToNull();
                }

                DialogResult R = MessageBox.Show("Do you need to add anthor person ?", "Asking For Adding Anthor Person", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                    await ResetFormAsync();
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("Person added faild", "Warning", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }
        private async Task UpdatePerson()
        {
            ClsPerson UpdatedPerson = uCtrl1.GetPerson();
            UpdatedPerson.PersonID = CurrentPerson.PersonID;
            _PeopleBl = new ClsPeopleBusinessLayer();
            var success = await _PeopleBl.UpdatePersonInfoAsync(UpdatedPerson);
            if (success)
            {
                MessageBox.Show("Person updated successfully", "Confirm Update Person", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                if (!string.IsNullOrEmpty(uCtrl1.ImageToDelete))
                {
                    await ClsImageServices.RecycleImageAsync(uCtrl1.ImageToDelete);
                    uCtrl1.ReturnImageToDeleteToNull();
                }

                CurrentPerson = UpdatedPerson;

                this.Close();
            }
        }
        #endregion
    }
}