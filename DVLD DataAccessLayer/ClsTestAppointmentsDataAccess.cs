using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsTestAppointmentsDataAccess
    {
        public async Task<SqlDataReader> GetUnLockedTestAppointmentAsync(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);

                string query = @"SELECT * FROM TestAppointments 
                               WHERE TestTypeID = @TestTypeID 
                               AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
							   And IsLocked = 0";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetTestAppointmentByTestAppointmentIDAsync(int TestTypeID, int TestAppointmentID)
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);

                string query = @"Select * From TestAppointments
                                 Where TestAppointmentID = @TestAppointmentID
                                 And TestTypeID = @TestTypeID
                                 And IsLocked = 0";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }

        public async Task<int> AddNewTestAppointmentAsync(int testTypeId, int licenseApplicationId,
                                                          DateTime appointmentDate, decimal paidFees,
                                                          int createdByUserId, bool isLocked)
        {
            using (var connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string query = @"INSERT INTO TestAppointments 
                                (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, 
                                 CreatedByUserID, IsLocked)
                                VALUES 
                                (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, 
                                 @PaidFees, @CreatedByUserID, @IsLocked)
                                  SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", testTypeId);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", licenseApplicationId);
                    command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);
                    command.Parameters.AddWithValue("@IsLocked", isLocked);

                    await connection.OpenAsync();
                    return Convert.ToInt32(await command.ExecuteScalarAsync());
                }
            }
        }

        public async Task<bool> HasActiveAppointmentAsync(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            using (var connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string query = @"SELECT CASE
                                    WHEN EXISTS (
                                        SELECT 1 FROM TestAppointments 
                                        WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                                        AND TestTypeID = @TestTypeID AND IsLocked = 0
                                    )
                                    THEN CAST(1 AS BIT)
                                    ELSE CAST(0 AS BIT)
                                END AS Result";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    await connection.OpenAsync();
                    return (bool)await command.ExecuteScalarAsync();
                }
            }
        }

        public async Task<SqlDataReader> GetAllAppointmentsAsync(int LocalLicenseDrivingID, int TestTypeID)
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"Select * From TestAppointments Where LocalDrivingLicenseApplicationID = @LocalLicenseDrivingID 
                            AND TestTypeID = @TestTypeID";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@LocalLicenseDrivingID",SqlDbType.Int) { Value = LocalLicenseDrivingID });
            command.Parameters.Add(new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = TestTypeID });
            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }

        public async Task<int> GetAppointmentTrialCountAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            using (var connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string query = @"SELECT COUNT(*) FROM TestAppointments 
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                                 AND TestTypeID = @TestTypeID AND IsLocked = 1";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    await connection.OpenAsync();
                    return (int)await command.ExecuteScalarAsync();
                }
            }
        }

        public async Task<bool> UpdateTestAppointmentDateAsync(int TestAppointmentID, DateTime AppointmentDate, int CreatedByUserID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update TestAppointments
                                 Set AppointmentDate = @AppointmentDate,
								     CreatedByUserID = @CreatedByUserID
                                 Where TestAppointmentID = @TestAppointmentID";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@AppointmentDate", SqlDbType.DateTime) { Value = AppointmentDate });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });
                    Command.Parameters.Add(new SqlParameter("@TestAppointmentID", SqlDbType.Int)
                                           { Value = TestAppointmentID });

                    await Connection.OpenAsync();

                    return await Command.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<SqlDataReader> GetLockedTestAppointmentAsync(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);

            string query = @"SELECT * FROM TestAppointments 
                               WHERE TestTypeID = @TestTypeID 
                               AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
							   And IsLocked = 1";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}