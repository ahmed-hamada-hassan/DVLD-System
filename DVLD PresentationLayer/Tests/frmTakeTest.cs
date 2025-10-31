using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_BusinessLayer.Test_Appointment;
using DVLD_BusinessLayer.Tests;
using DVLD_BusinessLayer.TestTypes;
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
using static DVLD_PresentationLayer.Tests.frmScheduleTest;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmTakeTest : Form
    {
        #region Fields
        public enum EnTakeTestType { Vision = 1, Writting = 2, Road = 3 }

        private EnTakeTestType _TakeTestType;
        private ClsLocalDrivingLicense _CurrentLocalDrivingLicenseApplicationInfo = null;
        private ClsTestAppointment _CurrentTestAppointmentInfo = null;
        private ClsTestsBL _TestsBL = new ClsTestsBL();
        private ClsTestTypesBusinessLayer _TestTypesBL = new ClsTestTypesBusinessLayer();
        #endregion

        #region Constructor
        public frmTakeTest(ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo, ClsTestAppointment CurrentTestAppointmentInfo,
                           EnTakeTestType TakeTestType)
        {
            InitializeComponent();
            _CurrentLocalDrivingLicenseApplicationInfo = CurrentLocalDrivingLicenseApplicationInfo;
            _CurrentTestAppointmentInfo = CurrentTestAppointmentInfo;
            _TakeTestType = TakeTestType;
            _ConfigureFormAccordingToTestType();
        }
        private async void frmTakeTest_Load(object sender, EventArgs e)
        {
            await _DisplayData();
        }
        #endregion

        #region Private Methods
        private void _ConfigureFormAccordingToTestType()
        {
            switch (_TakeTestType)
            {
                case EnTakeTestType.Vision:
                    this.Text = "Take Vision Test";
                    gbTakeTest.Text = "Vision Test";
                    pbTestImage.Image = Resources.eye_scan;
                    lbTestName.Text = "Take Vision Test";
                    break;
                case EnTakeTestType.Writting:
                    this.Text = "Take Writting Test";
                    gbTakeTest.Text = "Writting Test";
                    pbTestImage.Image = Resources.write;
                    lbTestName.Text = "Take Writting Test";
                    break;
                case EnTakeTestType.Road:
                    this.Text = "Take Road Test";
                    gbTakeTest.Text = "Road Test";
                    pbTestImage.Image = Resources.driving_test;
                    lbTestName.Text = "Take Road Test";
                    break;
            }
        }
        private async Task _DisplayData()
        {
            var TrialsCount = await _TestsBL.CountTakeTestTrialsAsync(_CurrentTestAppointmentInfo.LocalDrivingLicenseApplicationID, 
                _CurrentTestAppointmentInfo.TestTypeID);
            var TestTypeInfo = await _TestTypesBL.GetTestTypeByIDAsync((int)_TakeTestType);

            lbLDLAPPIDResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
            lbLicenseClassResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.DrivingClassTitle;
            lbNameResult.Text = _CurrentLocalDrivingLicenseApplicationInfo.FullName;
            lbTrialsResult.Text = TrialsCount.ToString();
            lbDateResult.Text = _CurrentTestAppointmentInfo.AppointmentDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lbFeesResult.Text = string.Format("{0:C2}", TestTypeInfo.TestTypeFees);
        }
        private ClsTest _GetTestInfo()
        {
            return new ClsTest
            {
                TestAppointmentID = _CurrentTestAppointmentInfo.TestAppointmentID,
                TestResult = rbPass.Checked == true ? true : false,
                Notes = string.IsNullOrEmpty(txtNotes.Text.Trim()) ? null : txtNotes.Text.Trim(),
                CreatedByUserID = Program.CurrentUser.UserID
            };
        }
        private async Task<bool> _SaveTestInfo()
        {
            string MessageQuestion = _TakeTestType == EnTakeTestType.Vision ? "Are you sure you want to take Vision Test?" :
                                        _TakeTestType == EnTakeTestType.Writting ? "Are you sure you want to take Writting Test?" :
                                        "Are you sure you want to take Road Test?";
            string CaptionQuestion = _TakeTestType == EnTakeTestType.Vision ? "Take Vision Test" : 
                                        _TakeTestType == EnTakeTestType.Writting ? "Take Writting Test" :
                                        "Take Road Test";
            string MessageSuccessfully = _TakeTestType == EnTakeTestType.Vision ? "Vision Test Taken Successfully!" :
                                        _TakeTestType == EnTakeTestType.Writting ? "Writting Test Taken Successfully!" :
                                        "Road Test Taken Successfully!";
            string CaptionSuccessfully = _TakeTestType == EnTakeTestType.Vision ? "Vision Test Taken" :
                                        _TakeTestType == EnTakeTestType.Writting ? "Writting Test Taken" :
                                        "Road Test Taken";
            string MessageFailed = _TakeTestType == EnTakeTestType.Vision ? "Failed to Take Vision Test!" :
                                        _TakeTestType == EnTakeTestType.Writting ? "Failed to Take Writting Test!" :
                                        "Failed to Take Road Test!";
            string CaptionFailed = _TakeTestType == EnTakeTestType.Vision ? "Vision Test Failed" :
                                        _TakeTestType == EnTakeTestType.Writting ? "Writting Test Failed" :
                                        "Road Test Failed";

            var Result = MessageBox.Show(MessageQuestion, CaptionQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                var TestInfo = _GetTestInfo();
                if (await _TestsBL.AddNewTestAsync(TestInfo))
                {
                    MessageBox.Show($"{MessageSuccessfully} with Test ID = {TestInfo.TestID}", 
                        CaptionSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(MessageFailed, CaptionFailed, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region Form's Event Handlers
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(await _SaveTestInfo())
            {
                if(this.Owner is frmAppointmentTest ParentForm)
                {
                    await ParentForm.PassedTestsCounter();
                    await ParentForm.RefreshAppointmentsDataGridView();
                    this.Close();
                }
                return;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
