using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.Applications_BL;
using DVLD_BusinessLayer.License_Classes_BL;
using DVLD_BusinessLayer.PoepleBL;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_PresentationLayer.Applications;
using DVLD_BusinessLayer.UserBL;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.People;

namespace DVLD_PresentationLayer.Application_Types
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {

        #region Fields , properties , Events , Delegates and Enums

        enum EnMode { NewApplication = 0, EditApplication = 1 }
        private EnMode _Mode = EnMode.NewApplication;

        private readonly ClsLicenseClassesBusinessLayer _LicenseClassBL = new ClsLicenseClassesBusinessLayer();
        private readonly ClsApplicationTypesBusinessLayer _AppBL = new ClsApplicationTypesBusinessLayer();
        private readonly ClsApplicationsBL _ApplicationsBL = new ClsApplicationsBL();
        private readonly ClsLocalDrivingLicenseApplicationsBL _LDLAppBL = new ClsLocalDrivingLicenseApplicationsBL();
        private readonly ClsUserBusinessLayer _UserBL = new ClsUserBusinessLayer();
        private readonly ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private readonly ClsLicensesBL _LicenseBL = new ClsLicensesBL();

        private ClsPerson _CurrentPersonForApplication = null;
        private ClsApplication _CurrentApplicationToEdit = null;
        private int _LDLAPPID;
        #endregion

        #region Constructors

        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = EnMode.NewApplication;
        }

        public frmNewLocalDrivingLicenseApplication(int LocalDrivingLicenseAppID) : this()
        {
            _Mode = EnMode.EditApplication;
            _LDLAPPID = LocalDrivingLicenseAppID;
        }

        private async void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            await Task.Yield();
            
            // Configure common form settings first
            await _ConfigureStaticSettingsOfForm();
            
            await _PopulateLicenseClassesAsync();

            if (_Mode == EnMode.NewApplication)
            {
                _ConfigureFormAccordingToMode();
                btnSave.Enabled = false;

                uctrlAddNewUser1.PersonChanged += (Person) =>
                {
                    btnSave.Enabled = Person != null;
                    _CurrentPersonForApplication = Person;
                };
            }
            else if (_Mode == EnMode.EditApplication)
            {
                _CurrentApplicationToEdit = await _ApplicationsBL.FindApplicationInfoWithLocalDrivingLicenseApplicationID(_LDLAPPID);
                _ConfigureFormAccordingToMode();
                await _FillFormToUpdate(_LDLAPPID);
            }
        }

        #endregion

        #region Private Methods
        private void _ConfigureFormAccordingToMode()
        {
            Text = _Mode == EnMode.NewApplication ? "New Local Driving License Application" :
                                                    "Edit Local Driving License Application";
            lbFormTitle.Text = _Mode == EnMode.NewApplication ? "New Local Driving License Application" :
                                                                "Edit Local Driving License Application";
            btnSave.Text = _Mode == EnMode.NewApplication ? "Save" : "Update";
            lbApplicationDateResult.Text = _Mode == EnMode.NewApplication ? DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") :
                                                                            _CurrentApplicationToEdit.ApplicationDate.ToString("dd/MM/yyyy HH:mm:ss tt");
                                                                            
        }
        
        private async Task _ConfigureStaticSettingsOfForm()
        {
            lbCreatedByResult.Text = Program.CurrentUser.UserName;
            decimal Fees = await _AppBL.GetApplicationFeesByIDAsync(1);
            lbApplicationFeesResult.Text = string.Format("${0:N2}", Fees);
        }

        private async Task _PopulateLicenseClassesAsync()
        {
            var LicenseClasses = await _LicenseClassBL.GetLicenseClassesAsync();
            cbLicenseClass.DataSource = LicenseClasses;
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.SelectedValue = 1;
        }

        private void _ShowErroMessageBox(string Message , string Caption)
        {
            MessageBox.Show(Message, Caption,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private ClsApplication _GetApplicationInfo()
        {
            // Parse the date using the same format as displayed in the label
            DateTime applicationDate;
            if (!DateTime.TryParseExact(lbApplicationDateResult.Text, "dd/MM/yyyy hh:mm:ss tt", 
                System.Globalization.CultureInfo.InvariantCulture, 
                System.Globalization.DateTimeStyles.None, out applicationDate))
            {
                // Fallback to current date if parsing fails
                applicationDate = DateTime.Now;
            }

            return new ClsApplication
            {
                ApplicationID = lbApplicationIDResult.Text == "[???]" ? -1 : Convert.ToInt32(lbApplicationIDResult.Text),
                ApplicationTypeID = 1,
                ApplicationDate =  applicationDate ,
                ApplicationPersonID = _CurrentPersonForApplication.PersonID,
                ApplicationStatus = 1,
                LastStatusDate = DateTime.Now,
                PaidFees = Convert.ToDecimal(lbApplicationFeesResult.Text.TrimStart('$')),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }

        private async Task _AddNewApplication()
        {
            var NewApp = _GetApplicationInfo();
            bool success = await _ApplicationsBL.AddNewApplicationAsync(NewApp);
            if(success)
            {
                MessageBox.Show($"New Application is added successfully with Application ID: {NewApp.ApplicationID}",
                                "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbApplicationIDResult.Text = NewApp.ApplicationID.ToString();


                await _LDLAppBL.AddNewLocalDrivingLicenseApplicationAsync(NewApp.ApplicationID,
                                                                (int)cbLicenseClass.SelectedValue);
            }
            else
                _ShowErroMessageBox("Failed to add new application. Please try again.", "Error");

        }

        private async Task _UpdateApplication()
        {
            var NewApp = _GetApplicationInfo();
            bool success = await _ApplicationsBL.UpdateApplicationStatusAsync(NewApp);
            if(success)
            {
                MessageBox.Show($"The Application with ID: {NewApp.ApplicationID} is updated successfully.",
                                "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                await _LDLAppBL.AddNewLocalDrivingLicenseApplicationAsync(NewApp.ApplicationID,
                                                                (int)cbLicenseClass.SelectedValue);
            }
            else
                _ShowErroMessageBox("Failed to update the application. Please try again.", "Error");

        }

        private async Task<(bool,string)> _CheckThatPersonHasTheSameClassAsync(int PersonID, int CurrentLicenseClassID)
        {
            if (await _ApplicationsBL.IsThisPersonHasApplicationWithTheSameLicenseClass(PersonID, CurrentLicenseClassID))
                return (true, $"Choose anthor license class, the selected person already have an active application for the selected with" +
                              $" ID= {await _ApplicationsBL.FindApplicationIDWithPersonID(_CurrentPersonForApplication.PersonID, (int)cbLicenseClass.SelectedValue)}");
            else
            {
                if(await _LicenseBL.FindIfHasActiveLicenseByPersonIDAsync(PersonID,CurrentLicenseClassID))
                {
                    var ActiveLicenseInfo = await _LicenseBL.GetLicenseInfoByPersonIDAsync(PersonID, CurrentLicenseClassID);
                    return (true, $"Choose anthor license class, the selected person already have an active license for the selected class with" +
                                  $" License ID= {ActiveLicenseInfo.LicenseID}");
                }
            }
            return (false,string.Empty);
        }

        private void _ResetForm()
        {
            try
            {
                uctrlAddNewUser1.Reset();
                
                cbLicenseClass.SelectedValue = 1;
                lbApplicationIDResult.Text = "[???]";
                lbApplicationDateResult.Text = DateTime.Now.ToString("dd/MM/yyyy");
                
                btnSave.Enabled = false;
                _Mode = EnMode.NewApplication;
                _CurrentPersonForApplication = null;
                
                tabControl1.SelectedTab = tbpPersonalInfo;
            }
            catch (Exception ex)
            {
                _ShowErroMessageBox($"Error resetting form: {ex.Message}", "Reset Error");
            }
        }

        private void _AddAnotherApplication()
        {
            DialogResult result = MessageBox.Show("Do you want to add another application?", "Add Another",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                _ResetForm();
            else
                Close();
        }

        private async Task _FillFormToUpdate(int LocalDrivingLicenseApplicationID)
        {
            if (_CurrentApplicationToEdit == null) return;
            ClsPerson CurrentPeroson = await _PeopleBL.GetPersonByIDAsync(_CurrentApplicationToEdit.ApplicationPersonID);
            await uctrlAddNewUser1.LoadPersonInfoAsync(CurrentPeroson);
            await _FillApplicationInfo();
            _CurrentPersonForApplication = uctrlAddNewUser1.CurrentPerson;
        }

        private async Task _FillApplicationInfo()
        {
            lbApplicationIDResult.Text = _CurrentApplicationToEdit.ApplicationID.ToString();
            cbLicenseClass.SelectedValue = await _ApplicationsBL.FindLicenseClassIDByApplicationIDAsync(_CurrentApplicationToEdit.ApplicationID);
            lbCreatedByResult.Text = (await _UserBL.GetUserInfoByUserIDAsync(_CurrentApplicationToEdit.CreatedByUserID)).UserName;
        }

        
        #endregion

        #region Form's Event Handlers

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if(this.Owner is frmManageLocalDrivingLicenseApplications parentForm)
                await parentForm.RefreshLocalDrivingLicenseGridViewAndRecords();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(uctrlAddNewUser1.CurrentPerson == null)
            {
                _ShowErroMessageBox("No person is selected. Select and try again!", "Invalid Person");
                return;
            }
            tabControl1.SelectedTab = tbpApplicationInfo;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (uctrlAddNewUser1.CurrentPerson == null)
            {
                _ShowErroMessageBox("No person is selected. Select and try again!", "Invalid Person");
                return;
            }

            string QuestionMessage = _Mode == EnMode.NewApplication ?
                "Are you sure you want to save this new application?" :
                "Are you sure you want to update this application?";

            string QuestionCaption = _Mode == EnMode.NewApplication ?
                "Confirm Save" : "Confirm Update";


            var Result = MessageBox.Show(QuestionMessage, QuestionCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                var ApplicationInfo = _GetApplicationInfo();
                var CheckResult = await _CheckThatPersonHasTheSameClassAsync(ApplicationInfo.ApplicationPersonID,
                                                                                         (int)cbLicenseClass.SelectedValue);
                if (!CheckResult.Item1)
                {
                    if(_Mode == EnMode.NewApplication)
                    {
                        await _AddNewApplication();
                        _AddAnotherApplication();
                        return;
                    }
                    if(_Mode == EnMode.EditApplication)
                    {
                        await _UpdateApplication();
                        return;
                    }
                }
                else
                {
                    _ShowErroMessageBox(CheckResult.Item2, "Duplicate License Class");
                    return;
                }
            }
            
            if(this.Owner is frmManageLocalDrivingLicenseApplications ParentForm)
            {
                await ParentForm.RefreshLocalDrivingLicenseGridViewAndRecords();
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_Mode == EnMode.NewApplication)
            {
                if (e.TabPage == tbpApplicationInfo)
                {
                    if (_CurrentPersonForApplication == null)
                    {
                        _ShowErroMessageBox("No person is selected. Select and try again!", "Invalid Person");
                        e.Cancel = true; // Prevent switching
                    }
                    // If valid, do nothing; tab will switch automatically
                }

            }
        }

        private async void frmNewLocalDrivingLicenseApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is frmManageLocalDrivingLicenseApplications parentForm)
                await parentForm.RefreshLocalDrivingLicenseGridViewAndRecords();
        }
        #endregion
    }
}
