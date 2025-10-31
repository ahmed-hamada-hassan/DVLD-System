using DVLD_BusinessLayer.Test_Appointment;
using DVLD_BusinessLayer.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_PresentationLayer.Tests
{
    public class ClsUtilityTests
    {
        private ClsTestAppointmentsBL _TestAppointmentBL = new ClsTestAppointmentsBL();
        private ClsTestsBL _TestsBL = new ClsTestsBL();

        public async Task<(bool, string)> CheckIfHasAnActiveAppointmentOrPassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID, string Message)
        {
            if(await _TestsBL.HasPassedTestAsync(LocalDrivingLicenseApplicationID,TestTypeID))
            {
                var TestInfo = await _TestsBL.GetTestByAsync(LocalDrivingLicenseApplicationID, TestTypeID);
                return (true, $"{Message} {TestInfo.TestID}");
            }
            if(await _TestAppointmentBL.HasActiveAppointmentAsync(TestTypeID, LocalDrivingLicenseApplicationID))
            {
                var TestAppointmentInfo = await _TestAppointmentBL.GetUnLockedTestAppointmentAsync(TestTypeID, LocalDrivingLicenseApplicationID);
                return (true, $"Has an active appointment test with ID = {TestAppointmentInfo.TestAppointmentID}");
            }
            return (false, string.Empty);
        }
        public async Task<List<object>> ConfigureListToViewInDataGridView(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            var Appointments = await _TestAppointmentBL.GetAllAppointmentsAsync(LocalDrivingLicenseApplicationID, TestTypeID);
            if (Appointments.Count == 0)
                return null;
            return Appointments.Select(x => new
            {
                x.TestAppointmentID,
                AppointmentDate = x.AppointmentDate.ToString("MM/dd/yyyy hh:mm:ss tt"),
                x.PaidFees,
                x.IsLocked
            }).ToList<object>();

            
        }
    }
}
