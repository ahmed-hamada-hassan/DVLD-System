using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Test_Appointment
{
    public class ClsTestAppointmentMapper
    {
        public static ClsTestAppointment MapToClsTestAppointment (SqlDataReader Reader)
        {
            int TestAppointmentIDOrdinal = Reader.GetOrdinal("TestAppointmentID");
            int TestTypeIDOrdinal = Reader.GetOrdinal("TestTypeID");
            int LocalDrivingLicenseApplicationIDOrdinal = Reader.GetOrdinal("LocalDrivingLicenseApplicationID");
            int AppointmentDateOrdinal = Reader.GetOrdinal("AppointmentDate");
            int PaidFeesOrdinal = Reader.GetOrdinal("PaidFees");
            int CreatedByUserIDOrdinal = Reader.GetOrdinal("CreatedByUserID");
            int IsLockedOrdinal = Reader.GetOrdinal("IsLocked");

            return new ClsTestAppointment
            {
                TestAppointmentID = Reader.GetInt32(TestAppointmentIDOrdinal),
                TestTypeID = Reader.GetInt32(TestTypeIDOrdinal),
                LocalDrivingLicenseApplicationID = Reader.GetInt32(LocalDrivingLicenseApplicationIDOrdinal),
                AppointmentDate = Reader.GetDateTime(AppointmentDateOrdinal),
                PaidFees = Reader.GetDecimal(PaidFeesOrdinal),
                CreatedByUserID = Reader.GetInt32(CreatedByUserIDOrdinal),
                IsLocked = Reader.GetBoolean(IsLockedOrdinal)
            };
        }
    }
}
