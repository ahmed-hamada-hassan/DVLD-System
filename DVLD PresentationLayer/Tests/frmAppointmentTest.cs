using DVLD_BusinessLayer;
using DVLD_BusinessLayer.License_BL;
using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_BusinessLayer.Test_Appointment;
using DVLD_BusinessLayer.Tests;
using DVLD_PresentationLayer.Applications;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.People;
using DVLD_PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmAppointmentTest : Form
    {
        #region Fields
        public enum EnAppointmentType { Vision = 1, Writting = 2, Road = 3 }

        private EnAppointmentType _AppointmentTestType;
        private ClsLocalDrivingLicense _CurrentLocalDrivingLicenseApplicationInfo = null;
        private ClsUtilityTests _UtilityTests = new ClsUtilityTests();
        private ClsTestAppointmentsBL _TestAppointmentBL = new ClsTestAppointmentsBL();
        private ClsPeopleBusinessLayer _PeopleBL = new ClsPeopleBusinessLayer();
        private ClsTestsBL _TestsBL = new ClsTestsBL();
        private ClsLicensesBL _LicenseBL = new ClsLicensesBL();
        #endregion

        #region Constructors
        public frmAppointmentTest(ClsLocalDrivingLicense CurrentLocalDrivingLicenseApplicationInfo, EnAppointmentType AppointmentTestType)
        {
            InitializeComponent();
            _CurrentLocalDrivingLicenseApplicationInfo = CurrentLocalDrivingLicenseApplicationInfo;
            _AppointmentTestType = AppointmentTestType;
            _ConfigureFormAccordingToAppointmentType();
            uctrlApplicationAndApplicantInfo1.RecieveData(_CurrentLocalDrivingLicenseApplicationInfo);
        }
        private async void frmAppointmentTest_Load(object sender, EventArgs e)
        {
            await _FillDataGridViewAccordingToAppointmentType();
        }
        #endregion

        #region Private Methods
        private void _ConfigureFormAccordingToAppointmentType()
        {
            this.Text = _AppointmentTestType == EnAppointmentType.Vision ? "Vision Test Appointment" :
                        _AppointmentTestType == EnAppointmentType.Writting ? "Writting Test Appointment" : "Road Test Appointment";
            lbScheduleTestName.Text = _AppointmentTestType == EnAppointmentType.Vision ? "Vision Test Appointment" :
                        _AppointmentTestType == EnAppointmentType.Writting ? "Writting Test Appointment" : "Road Test Appointment";
            pbTestImage.Image = _AppointmentTestType == EnAppointmentType.Vision ? Resources.eye_scan :
                        _AppointmentTestType == EnAppointmentType.Writting ? Resources.write : Resources.driving_test;
        }
        private void _ConfigureHeaderTextForDataGridView(DataGridView DGV, string OriginalHeaderText, string HeaderTextYouWant)
        {
            if (DGV.Columns.Contains(OriginalHeaderText))
                DGV.Columns[OriginalHeaderText].HeaderText = HeaderTextYouWant;
        }
        private async Task _FillDataGridViewWithInfoAndCountRecords()
        {
            dataGridView1.DataSource =  await _UtilityTests.
               ConfigureListToViewInDataGridView(_CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID, (int)_AppointmentTestType);
            lbRecordsResult.Text = dataGridView1.Rows.Count.ToString();
        }
        private async Task _FillDataGridViewAccordingToAppointmentType()
        {
            switch (_AppointmentTestType)
            { 
                case EnAppointmentType.Vision:
                    await _FillDataGridViewWithInfoAndCountRecords();
                    _ConfigureAppointmentsDataGridView();
                    break;
                case EnAppointmentType.Writting:
                    await _FillDataGridViewWithInfoAndCountRecords();
                    _ConfigureAppointmentsDataGridView();
                    break;
                case EnAppointmentType.Road:
                    await _FillDataGridViewWithInfoAndCountRecords();
                    _ConfigureAppointmentsDataGridView();
                    break;
            }

        }
        private void _ConfigureAppointmentsDataGridView()
        {
            _ConfigureHeaderTextForDataGridView(dataGridView1, "TestAppointmetnID", "Appointment ID");
            _ConfigureHeaderTextForDataGridView(dataGridView1, "AppointmetnDate", "Appointmetn Date");
            _ConfigureHeaderTextForDataGridView(dataGridView1, "PaidFees", "Paid Fees");
            _ConfigureHeaderTextForDataGridView(dataGridView1, "IsLocked", "Is Locked");
        }
        private async Task<(bool, string)> CheckIfHasAnActiveAppointmentOrPassedTest()
        {
            string Message = _AppointmentTestType == EnAppointmentType.Vision ? "You have already passed the vision test with ID =" :
                             _AppointmentTestType == EnAppointmentType.Writting ? "You have already passed the writting test with ID =" :
                             "You have already passed the road test with ID =";
            var HasAnActiveAppointmentOrPassedTest = await _UtilityTests.CheckIfHasAnActiveAppointmentOrPassedTest(
                                                        _CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID,
                                                        (int)_AppointmentTestType, Message);
            return HasAnActiveAppointmentOrPassedTest;
        }
        #endregion

        #region Public Methods
        public async Task RefreshAppointmentsDataGridView()
        {
            await _FillDataGridViewAccordingToAppointmentType();
            _ConfigureAppointmentsDataGridView();
        }
        public async Task PassedTestsCounter()
        {
            var PassedTestsCount = await _TestsBL.CountPassedTestsAsync(_CurrentLocalDrivingLicenseApplicationInfo.LocalDrivingLicenseApplicationID);
            uctrlApplicationAndApplicantInfo1.RefreshDrivingLicenseApplicationInfo(PassedTestsCount);
        }
        #endregion

        #region Form's Event Handlers
        private async void uctrlApplicationAndApplicantInfo1_OnClickViewPersonInfo(object sender, EventArgs e)
        {
            using (var ShowPersonInfo = new frmShowPersonDetails(_CurrentLocalDrivingLicenseApplicationInfo.PersonID))
            {
                ShowPersonInfo.ShowDialog();
            }
            var FullName = await _PeopleBL.GetPersonFullNameByIDAsync(_CurrentLocalDrivingLicenseApplicationInfo.PersonID);
            uctrlApplicationAndApplicantInfo1.RefreshApplicationBasicInfo(FullName);
        }
        private async void uctrlApplicationAndApplicantInfo1_OnClickShowLicenseInfo(object sender, EventArgs e)
        {
            var LicenseInfo = await _LicenseBL.GetActiveLicenseByNationalNumberAsync(_CurrentLocalDrivingLicenseApplicationInfo.NationalNo);
            if (LicenseInfo != null)
            {
                using (var ShowLicenseDatails = new frmShowLicenseInfo(LicenseInfo))
                {
                    ShowLicenseDatails.ShowDialog();
                }
                return;
            }
            else
            {
                MessageBox.Show("This person doesn't have license yet", "No License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private async void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var CheckResult = await CheckIfHasAnActiveAppointmentOrPassedTest();
            if (CheckResult.Item1)
            {
                MessageBox.Show(CheckResult.Item2, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var ScheduleTestForm = new frmScheduleTest(_CurrentLocalDrivingLicenseApplicationInfo,
                                                                 _AppointmentTestType == EnAppointmentType.Vision ?
                                                                 frmScheduleTest.EnScheduleTestType.Vision :
                                                                 _AppointmentTestType == EnAppointmentType.Writting ?
                                                                 frmScheduleTest.EnScheduleTestType.Writting :
                                                                 frmScheduleTest.EnScheduleTestType.Road))
            {
                ScheduleTestForm.Owner = this;
                ScheduleTestForm.ShowDialog();
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            bool IsLocked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[3].Value);
            var AppointmentDate = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[1].Value);
            editToolStripMenuItem.Enabled = !IsLocked;
            takeTestToolStripMenuItem.Enabled = (DateTime.Compare(AppointmentDate, DateTime.Now) <= 0 && !IsLocked);
        }
        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int TestAppointmentID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var TestAppointmentInfo = await _TestAppointmentBL.GetTestAppointmentByTestAppointmentIDAsync((int)_AppointmentTestType,
                                                                                  TestAppointmentID);

                using (var EditScheduleTestForm = new frmScheduleTest(_CurrentLocalDrivingLicenseApplicationInfo, TestAppointmentInfo,
                                                                     _AppointmentTestType == EnAppointmentType.Vision ?
                                                                     frmScheduleTest.EnScheduleTestType.EditVision :
                                                                     _AppointmentTestType == EnAppointmentType.Writting ?
                                                                     frmScheduleTest.EnScheduleTestType.EditWritting :
                                                                     frmScheduleTest.EnScheduleTestType.EditRoad))
                {
                    EditScheduleTestForm.Owner = this;
                    EditScheduleTestForm.ShowDialog();
                }
            }
        }
        private async void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int TestAppointmentID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var TestAppointmentInfo = await _TestAppointmentBL.GetTestAppointmentByTestAppointmentIDAsync((int)_AppointmentTestType,
                                                                                  TestAppointmentID);

                using (var TakeTest = new frmTakeTest(_CurrentLocalDrivingLicenseApplicationInfo, TestAppointmentInfo,
                                               _AppointmentTestType == EnAppointmentType.Vision ? frmTakeTest.EnTakeTestType.Vision :
                                               _AppointmentTestType == EnAppointmentType.Writting ? frmTakeTest.EnTakeTestType.Writting :
                                               frmTakeTest.EnTakeTestType.Road))
                {
                    TakeTest.Owner = this;
                    TakeTest.ShowDialog();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void frmAppointmentTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is frmManageLocalDrivingLicenseApplications ParentForm)
            {
                await ParentForm.RefreshLocalDrivingLicenseGridViewAndRecords();
                this.Close();
                return;
            }
        }
        #endregion
    }
}
