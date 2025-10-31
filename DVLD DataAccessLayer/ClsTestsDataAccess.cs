using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsTestsDataAccess
    {
         public async Task<int> CountTakeTestTrialsAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
         {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select Count(*) AS Trials
                                 From Tests TS INNER JOIN TestAppointments TA
                                 ON TS.TestAppointmentID = TA.TestAppointmentID
                                 WHERE TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TA.TestTypeID = @TestTypeID";

                using (var Command = new SqlCommand(Query,Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) 
                    { Value = LocalDrivingLicenseApplicationID });
                    Command.Parameters.Add(new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = TestTypeID });

                    await Connection.OpenAsync();

                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
         }
        public async Task<int> AddNewTestAsync(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                 VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)
                                 Update TestAppointments 
                                 Set IsLocked = 1
                                 Where TestAppointmentID = @TestAppointmentID
                                 SELECT SCOPE_IDENTITY();";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@TestAppointmentID", SqlDbType.Int) { Value = TestAppointmentID });
                    Command.Parameters.Add(new SqlParameter("@TestResult", SqlDbType.Bit) { Value = TestResult });
                    Command.Parameters.Add(new SqlParameter("@Notes", SqlDbType.NVarChar, 500) { Value = Notes ?? (object)DBNull.Value });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });
                    await Connection.OpenAsync();
                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> HasPassedTestAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select CASE 
                                        WHEN EXISTS (
	                                        Select 1 From TestAppointments TA
		                                    INNER JOIN Tests TS 
		                                         ON TA.TestAppointmentID = TS.TestAppointmentID
		                                 	Where TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
		                                 	AND TS.TestResult = 1 AND TA.TestTypeID = @TestTypeID
		                                 	)
	                                    THEN CAST (1 AS BIT)
	                                    ELSE CAST (0 AS BIT)
	                                    END AS Result;";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });
                    Command.Parameters.Add(new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = TestTypeID });

                    await Connection.OpenAsync();

                    return (bool)await Command.ExecuteScalarAsync();
                }
            }
        }
        public async Task<SqlDataReader> GetTestByAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);

            string Query = @"Select Ts.* 
                             From Tests TS 
                             INNER JOIN TestAppointments TA
                                  ON Ts.TestAppointmentID = TA.TestAppointmentID
                             Where TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                                   AND TS.TestResult = 1 AND TA.TestTypeID = @TestTypeID";

            var Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
            { Value = LocalDrivingLicenseApplicationID });
            Command.Parameters.Add(new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = TestTypeID });

            await Connection.OpenAsync();

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<int> CountPassedTestsAsync(int LocalDrivingLicenseApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select Count(*) AS PassedTests 
                                 From Tests TS 
                                 INNER JOIN TestAppointments TA
                                      ON Ts.TestAppointmentID = TA.TestAppointmentID
                                 Where TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                                       AND TS.TestResult = 1";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });
                    await Connection.OpenAsync();
                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> TakeThisTestBefore(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            using (var connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string query = @"SELECT 
                                       CASE WHEN EXISTS (
                                           SELECT 1 
                                           FROM TestAppointments TAS 
                                           INNER JOIN Tests TS ON TAS.TestAppointmentID = TS.TestAppointmentID 
                                           WHERE TAS.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                                           AND TS.TestResult IN (0,1) AND TAS.TestTypeID = @TestTypeID)
                                       THEN CAST(1 AS BIT)
                                       ELSE CAST(0 AS BIT)
                                       END AS HasFailedTest"; ;
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });
                    command.Parameters.Add(new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = TestTypeID });
                    await connection.OpenAsync();
                    return (bool)await command.ExecuteScalarAsync();
                }
            }
        }
    }
}
