using DVLD_BusinessLayer.Local_Driveing_License_Applications;
using DVLD_BusinessLayer.Test_Appointment;
using DVLD_BusinessLayer.Tests;
using DVLD_BusinessLayer.TestTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmRetakeTest : Form
    {
        private readonly ClsTestTypesBusinessLayer _TestTypesBL = new ClsTestTypesBusinessLayer();
        private readonly ClsTestAppointmentsBL _TestAppointmentsBL = new ClsTestAppointmentsBL();
        private readonly ClsTestsBL _TestBL = new ClsTestsBL();
        private readonly ClsLocalDrivingLicenseApplicationsBL _LocalDrivingLicenseApplicationsBL = new ClsLocalDrivingLicenseApplicationsBL();

        public frmRetakeTest()
        {
            InitializeComponent();
        }

        private async Task _PopulateTestTypes()
        {
            try
            {
                List<ClsTestType> testTypes = await _TestTypesBL.GetAllTestTypeAsync();
                comboBox1.DataSource = testTypes;
                comboBox1.DisplayMember = "TestTypeTitle";
                comboBox1.ValueMember = "TestTypeID";
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading test types: " + ex.Message);
            }
        }

        private async Task _RetakeTest()
        {
            try
            {
                int LocalLicenseID;
                if (!int.TryParse(txtID.Text.Trim(), out LocalLicenseID))
                {
                    MessageBox.Show("Please enter a valid numeric ID.");
                    return;
                }
                var TestTypeID = (int)comboBox1.SelectedValue;
                
                var HasTakenThisTestBefore = await _TestBL.TakeThisTestBefore(LocalLicenseID, TestTypeID);
                var IsPassed = await _TestBL.HasPassedTestAsync(LocalLicenseID, TestTypeID);

                
                if(HasTakenThisTestBefore)
                {
                    if (IsPassed)
                    {
                        MessageBox.Show("You have already passed this test.","Taken Before",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        var CurrentLocalDrivingLicenseApplicationInfo = 
                            await _LocalDrivingLicenseApplicationsBL.GetDrivingLicenseApplicationAsync(LocalLicenseID);
                        var CurrentTestAppointmentInfo = 
                            await _TestAppointmentsBL.GetLockedTestAppointmentAsync(TestTypeID, LocalLicenseID);
                        using (var TakeTest = new frmAppointmentTest(CurrentLocalDrivingLicenseApplicationInfo,
                            TestTypeID == 1 ? frmAppointmentTest.EnAppointmentType.Vision : 
                            TestTypeID == 2 ? frmAppointmentTest.EnAppointmentType.Writting : frmAppointmentTest.EnAppointmentType.Road))
                        {
                            TakeTest.ShowDialog();
                        }
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You have not taken this test before.","Never Taken Before",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking test history: " + ex.Message);
            }
        }
        
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmRetakeTest_Load(object sender, EventArgs e)
        {
            await _PopulateTestTypes();
        }

        private async void btnRetake_Click(object sender, EventArgs e)
        {
            await _RetakeTest();
        }
    }
}
