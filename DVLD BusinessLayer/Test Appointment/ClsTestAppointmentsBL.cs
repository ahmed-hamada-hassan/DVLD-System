using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Test_Appointment
{
    public class ClsTestAppointmentsBL
    {
        private readonly ClsTestAppointmentsDataAccess _TestAppointmentDAL = new ClsTestAppointmentsDataAccess();

        public async Task<ClsTestAppointment> GetUnLockedTestAppointmentAsync(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            using(var Reader = await _TestAppointmentDAL.GetUnLockedTestAppointmentAsync(TestTypeID, LocalDrivingLicenseApplicationID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsTestAppointmentMapper.MapToClsTestAppointment(Reader);
                }
            }
            return null;
        }
        public async Task<ClsTestAppointment> GetLockedTestAppointmentAsync(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            using(var Reader = await _TestAppointmentDAL.GetLockedTestAppointmentAsync(TestTypeID, LocalDrivingLicenseApplicationID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsTestAppointmentMapper.MapToClsTestAppointment(Reader);
                }
            }
            return null;
        }
        public async Task<ClsTestAppointment> GetTestAppointmentByTestAppointmentIDAsync(int TestTypeID, int TestAppointmentID)
        {
            using(var Reader = await _TestAppointmentDAL.GetTestAppointmentByTestAppointmentIDAsync(TestTypeID, TestAppointmentID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsTestAppointmentMapper.MapToClsTestAppointment(Reader);
                }
            }
            return null;
        }
        public async Task<bool> AddNewTestAppointmentAsync(ClsTestAppointment TestAppointmentInfo)
        {
            TestAppointmentInfo.TestAppointmentID = await _TestAppointmentDAL.
                                                    AddNewTestAppointmentAsync(TestAppointmentInfo.TestTypeID,
                                                                               TestAppointmentInfo.LocalDrivingLicenseApplicationID,
                                                                               TestAppointmentInfo.AppointmentDate,
                                                                               TestAppointmentInfo.PaidFees, TestAppointmentInfo.CreatedByUserID,
                                                                               TestAppointmentInfo.IsLocked);
            return TestAppointmentInfo.TestAppointmentID != -1;
        }
        public async Task<bool> HasActiveAppointmentAsync(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return await _TestAppointmentDAL.HasActiveAppointmentAsync(TestTypeID, LocalDrivingLicenseApplicationID);
        }
        public async Task<List<ClsTestAppointment>> GetAllAppointmentsAsync(int LocalLicenseDrivingID, int TestTypeID)
        {
            var AllAppointments = new List<ClsTestAppointment>();
            using (var Reader = await _TestAppointmentDAL.GetAllAppointmentsAsync(LocalLicenseDrivingID,TestTypeID))
            {
                while(await Reader.ReadAsync())
                {
                    AllAppointments.Add(ClsTestAppointmentMapper.MapToClsTestAppointment(Reader));
                }
            }
            return AllAppointments;
        }
        public async Task<int> GetAppointmentTrialCountAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return await _TestAppointmentDAL.GetAppointmentTrialCountAsync(LocalDrivingLicenseApplicationID,TestTypeID);
        }
        public async Task<bool> UpdateTestAppointmentDateAsync(int TestAppointmentID, DateTime AppointmentDate, int CreatedByUserID)
        {
            return await _TestAppointmentDAL.UpdateTestAppointmentDateAsync(TestAppointmentID, AppointmentDate, CreatedByUserID);
        }
    }
}
