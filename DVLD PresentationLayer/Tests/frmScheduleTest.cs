using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer.ApplicationsBL;
using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_BusinessLayer.Test_Appointment;
using DVLD_BusinessLayer.TestTypes;
using DVLD_PresentationLayer.Properties;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmScheduleTest : Form
    {
        #region Constants
        private const int RETAKE_TEST_APPLICATION_TYPE_ID = 7;
        #endregion

        #region Fields
        public enum EnScheduleTestType { Vision = 1, Writting = 2, Road = 3, EditVision = 4, EditWritting = 5, EditRoad = 6 }

        private EnScheduleTestType _ScheduleTestType;
        private ClsLocalDrivingLicense _CurrentLocalDrivingLicenseApplicationInfo = null;
        private ClsTestAppointment _CurrentTestAppointmentInfo = null;
        private ClsTestAppointmentsBL _TestAppointmentBL = new ClsTestAppointmentsBL();
        private ClsTestTypesBusinessLayer _TestTypesBL = new ClsTestTypesBusinessLayer();
        private ClsApplicationTypesBusinessLayer _ApplicationTypesBL = new ClsApplicationTypesBusinessLayer();
        
        // Store fees to avoid parsing
        private decimal _testFees = 0;
        private decimal _retakeFees = 0;
        #endregion

        #region Constructors
        public frmScheduleTest(ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo,EnScheduleTestType ScheduleTestType)
        {
            InitializeComponent();
            _CurrentLocalDrivingLicenseApplicationInfo = CurrentLocalDrivingLicenseApplicationInfo;
            _ScheduleTestType = ScheduleTestType;
            _ConfigureFormAccordingToAppointmentType();
        }
        public frmScheduleTest(ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo, ClsTestAppointment CurrentTestAppointmentInfo,
                               EnScheduleTestType ScheduleTestType) : this(CurrentLocalDrivingLicenseApplicationInfo, ScheduleTestType)
        {
            _CurrentTestAppointmentInfo = CurrentTestAppointmentInfo;
        }
        private async void frmScheduleTest_Load(object sender, EventArgs e)
        {
            await _ConfigureRetakeTestInfoGroupBox();

            if ((int)_ScheduleTestType <= 3)
            {
                await _DisplayDataNewMode();
                return;
            }
            else
            {
                await _DisplayDataEditMode();
                return;
            }
        }
        #endregion

        #region Private Methods
        private void _ConfigureFormAccordingToAppointmentType()
        {
            switch(_ScheduleTestType)
            {
                case EnScheduleTestType.Vision:
                    this.Text = "Schedule Vision Test";
                    gbScheduleTest.Text = "Vision Test";
                    groupBox1.Enabled = false;
                    lbScheduleTestName.Text = "Schedule Vision Test";
                    pbTestImage.Image = Resources.eye_scan;
                    break;
                case EnScheduleTestType.Writting:
                    this.Text = "Schedule Writting Test";
                    gbScheduleTest.Text = "Writting Test";
                    groupBox1.Enabled = false;
                    lbScheduleTestName.Text = "Schedule Writting Test";
                    pbTestImage.Image = Resources.write;
                    break;
                case EnScheduleTestType.Road:
                    this.Text = "Schedule Road Test";
                    gbScheduleTest.Text = "Road Test";
                    groupBox1.Enabled = false;
                    lbScheduleTestName.Text = "Schedule Road Test";
                    pbTestImage.Image = Resources.driving_test;
                    break;
                case EnScheduleTestType.EditVision:
                    this.Text = "Edit Schedule Vision Test";
                    gbScheduleTest.Text = "Edit Vision Test";
                    lbScheduleTestName.Text = "Edit Schedule Vision Test";
                    pbTestImage.Image = Resources.eye_scan;
                    break;
                case EnScheduleTestType.EditWritting:
                    this.Text = "Edit Schedule Writting Test";
                    gbScheduleTest.Text = "Edit Writting Test";
                    lbScheduleTestName.Text = "Edit Schedule Writting Test";
                    pbTestImage.Image = Resources.write;
                    break;
                case EnScheduleTestType.EditRoad:
                    this.Text = "Edit Schedule Road Test";
                    gbScheduleTest.Text = "Edit Road Test";
                    lbScheduleTestName.Text = "Edit Schedule Road Test";
                    pbTestImage.Image = Resources.driving_test;
                    break;
            }
        }
        private async Task _DisplayDataNewMode()
        {
            var Trials = await _TestAppointmentBL.
                GetAppointmentTrialCountAsync(_CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID, (int)_ScheduleTestType);
            var TestTypeInfo = await _TestTypesBL.GetTestTypeByIDAsync((int)_ScheduleTestType);

            _testFees = TestTypeInfo.TestTypeFees;

            lbLDLAPPIDResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
            lbLicenseClassResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.DrivingClassTitle;
            lbNameResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.FullName;
            lbTrialsResult.Text = Trials.ToString();
            lbFeesResult.Text = _testFees.ToString("C2");
            lbTotalFeesResult.Text = (_testFees + _retakeFees).ToString("C2");
        }
        private async Task _DisplayDataEditMode()
        {
            var Trials = await _TestAppointmentBL.
                GetAppointmentTrialCountAsync(_CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID, (int)_ScheduleTestType);
            var TestTypeInfo = await _TestTypesBL.GetTestTypeByIDAsync((int)_ScheduleTestType - 3);

            _testFees = TestTypeInfo.TestTypeFees;

            lbLDLAPPIDResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
            lbLicenseClassResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.DrivingClassTitle;
            lbNameResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.FullName;
            lbTrialsResult.Text = Trials.ToString();
            dateTimePicker1.Value = _CurrentTestAppointmentInfo.AppointmentDate;
            lbFeesResult.Text = _testFees.ToString("C2");
            lbRetakeAPPFeesResult.Text = _retakeFees.ToString("C2");
            lbTotalFeesResult.Text = (_testFees + _retakeFees).ToString("C2");
        }
        private async Task _ConfigureRetakeTestInfoGroupBox()
        {
            var Trials = await _TestAppointmentBL.GetAppointmentTrialCountAsync
                (_CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID, (int)_ScheduleTestType);
            var ApplicationTypeInfo = await _ApplicationTypesBL.GetApplicationTypeByIDAsync(RETAKE_TEST_APPLICATION_TYPE_ID);

            _retakeFees = Trials > 0 ? ApplicationTypeInfo.ApplicationFees : 0;

            groupBox1.Enabled = Trials > 0;
            lbRetakeAPPFeesResult.Text = _retakeFees.ToString("C2");
        }
        private ClsTestAppointment _GetTestAppointmentInfoToSave()
        {
            return new ClsTestAppointment
            {
                TestAppointmentID = _CurrentTestAppointmentInfo != null ? _CurrentTestAppointmentInfo.TestAppointmentID : -1,
                TestTypeID = (int)_ScheduleTestType <= 3 ? (int)_ScheduleTestType : (int)_ScheduleTestType - 3,
                LocalDrivingLicenseApplicationID = _CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID,
                AppointmentDate = dateTimePicker1.Value,
                PaidFees = _testFees + _retakeFees,
                CreatedByUserID = Program.CurrentUser.UserID,
                IsLocked = false
            };
        }
        private async Task<(ClsTestAppointment, bool)> _SaveOrUpdateTestAppointmentInfoAccordingScheduleTestType()
        {
            var TestAppointmentInfo = _GetTestAppointmentInfoToSave();
            var IsSuccessed = (int)_ScheduleTestType <= 3 ? await _TestAppointmentBL.AddNewTestAppointmentAsync(TestAppointmentInfo) :
                                                            await _TestAppointmentBL.UpdateTestAppointmentDateAsync(
                                                                  TestAppointmentInfo.TestAppointmentID, TestAppointmentInfo.AppointmentDate,
                                                                  TestAppointmentInfo.CreatedByUserID);
            return (TestAppointmentInfo, IsSuccessed);
        }
        private async Task _ConfigureSaveAndUpdateAccordingToScheduleTestType()
        {
            string QuestionMessagToConfirm = (int)_ScheduleTestType <= 3 ? "Are you sure you want to add this schedule test?" :
                                                                           "Are you sure you want to update this schedule test?";
            string CaptionMessageToConfirm = (int)_ScheduleTestType <= 3 ? "Confirm Add" : "Confirm Update";
            string MessageAfterSaveOrUpdateSuccessfully = (int)_ScheduleTestType <= 3 ? "Schedule test added successfully with Test Appointment ID =" :
                                                                                        "Schedule test updated successfully with Test Appointment ID =";
            string CaptionAfterSaveOrUpdateSuccessfully = (int)_ScheduleTestType <= 3 ? "Add Successfully" : "Update Successfully";
            string MessageAfterSaveOrUpdateFailed = (int)_ScheduleTestType <= 3 ? "Schedule test added failed, Try again!!" :
                                                                                  "Schedule test updated failed, Try again!!";
            string CaptionAfterSaveOrUpdateFailed = (int)_ScheduleTestType <= 3 ? "Add Failed" : "Update Failed";

            var Result = MessageBox.Show(QuestionMessagToConfirm,CaptionMessageToConfirm,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                var SaveOrUpdateInfo = await _SaveOrUpdateTestAppointmentInfoAccordingScheduleTestType();
                if(SaveOrUpdateInfo.Item2)
                {
                    MessageBox.Show($"{MessageAfterSaveOrUpdateSuccessfully} {SaveOrUpdateInfo.Item1.TestAppointmentID}",
                                    CaptionAfterSaveOrUpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show($"{MessageAfterSaveOrUpdateFailed}", CaptionAfterSaveOrUpdateFailed, MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return;
                }
            }
        }
        #endregion

        #region Form's Event Handlers
        private async void btnSave_Click(object sender, EventArgs e)
        {
            await _ConfigureSaveAndUpdateAccordingToScheduleTestType();
            if (this.Owner is frmAppointmentTest ParentForm)
                await ParentForm.RefreshAppointmentsDataGridView();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
