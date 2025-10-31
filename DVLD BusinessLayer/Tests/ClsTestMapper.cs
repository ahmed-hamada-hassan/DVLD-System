using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Tests
{
    public class ClsTestMapper
    {
        public static ClsTest MapToClsTest(SqlDataReader Reader)
        {
            int TestID = Reader.GetOrdinal("TestID");
            int TestAppointmentID = Reader.GetOrdinal("TestAppointmentID");
            int TestResult = Reader.GetOrdinal("TestResult");
            int Notes = Reader.GetOrdinal("Notes");
            int CreatedByUserID = Reader.GetOrdinal("CreatedByUserID");

            return new ClsTest
            {
                TestID = Reader.GetInt32(TestID),
                TestAppointmentID = Reader.GetInt32(TestAppointmentID),
                TestResult = Reader.GetBoolean(TestResult),
                Notes = Reader.GetString(Notes),
                CreatedByUserID = Reader.GetInt32(CreatedByUserID)
            };
        }
    }
}
