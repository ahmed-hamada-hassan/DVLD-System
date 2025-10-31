using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsApplicationsDataAccess
    {
        public async Task<int> AddNewApplicationAsync(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID,
                                                 byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, 
                                                           ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                               VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, 
                                       @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID); 
                               SELECT SCOPE_IDENTITY();";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@ApplicantPersonID", SqlDbType.Int) { Value = ApplicationPersonID });
                    Command.Parameters.Add(new SqlParameter("@ApplicationDate", SqlDbType.DateTime) { Value = ApplicationDate });
                    Command.Parameters.Add(new SqlParameter("@ApplicationTypeID", SqlDbType.Int) { Value = ApplicationTypeID });
                    Command.Parameters.Add(new SqlParameter("@ApplicationStatus", SqlDbType.TinyInt) { Value = ApplicationStatus });
                    Command.Parameters.Add(new SqlParameter("@LastStatusDate", SqlDbType.DateTime) { Value = LastStatusDate });
                    Command.Parameters.Add(new SqlParameter("@PaidFees", SqlDbType.SmallMoney) { Value = PaidFees });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });
                    await Connection.OpenAsync();
                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
        }

        public async Task<bool> IsThisPersonHasApplicationWithTheSameLicenseClass(int PersonID, int CurrentLicenseClass)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select 
                                 CASE 
                                 When Exists(Select 1 From LocalLicenseApplicationsWithStatus_View Where PersonID = @PersonID 
                                             AND LicenseClassID = @CurrentLicenseClass AND Status ='New')
                                 Then CAST (1 AS Bit)
                                 ELSE CAST (0 AS Bit)
                                 END AS IsExists";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    Command.Parameters.Add(new SqlParameter("@CurrentLicenseClass", SqlDbType.Int) { Value = CurrentLicenseClass });
                    await Connection.OpenAsync();

                    return Convert.ToBoolean(await Command.ExecuteScalarAsync());
                }
            }
        }

        public async Task<int> FindApplicationIDWithPersonID(int PersonID, int CurrentLicenseClassID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select ApplicationID From LocalLicenseApplicationsWithStatus_View Where PersonID = @PersonID AND 
                                 LicenseClassID = @CurrentLicenseClassID And Status = 'New'";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    Command.Parameters.Add(new SqlParameter("@CurrentLicenseClassID", SqlDbType.Int) { Value = CurrentLicenseClassID });
                    await Connection.OpenAsync();
                    var result = await Command.ExecuteScalarAsync();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public async Task<SqlDataReader> FindApplicationInfoWithLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);

            string Query = @"Select * From Applications
                             Where
                             ApplicationID 
                             IN (Select ApplicationID From LocalDrivingLicenseApplications Where 
                                 LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)";

            var Command = new SqlCommand(Query, Connection);

            Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
            { Value = LocalDrivingLicenseApplicationID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            
        }

        public async Task<int> FindLicenseClassIDByApplicationIDAsync(int ApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select L.LicenseClassID 
                                 From LocalDrivingLicenseApplications L 
                                 INNER JOIN Applications A ON L.ApplicationID = A.ApplicationID
                                 Where A.ApplicationID = @ApplicationID";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID });
                    await Connection.OpenAsync();

                    var result = await Command.ExecuteScalarAsync();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public async Task<bool> CancelApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update Applications
                                        Set ApplicationStatus = 2,
                                            LastStatusDate = GETDATE()
                                        Where ApplicationID = (Select ApplicationID From AllAboutLocalDrivingLicenseApplication 
                                                               Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });
                    await Connection.OpenAsync();
                    int rowsAffected = await Command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }

        public async Task<bool> CompleteApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update Applications
                                        Set ApplicationStatus = 3,
                                            LastStatusDate = GETDATE()
                                        Where ApplicationID = (Select ApplicationID From AllAboutLocalDrivingLicenseApplication 
                                                               Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });
                    await Connection.OpenAsync();
                    int rowsAffected = await Command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }

        public async Task<bool> DeleteApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"BEGIN TRY
                                 BEGIN TRANSACTION;
                                 
                                 DECLARE @ApplicationID INT
                                 
                                 SELECT @ApplicationID = L.ApplicationID
                                 FROM LocalDrivingLicenseApplications L
                                 WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                 
                                 IF @ApplicationID IS NOT NULL 
                                 BEGIN 
                                 
                                 DELETE FROM LocalDrivingLicenseApplications
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                 
                                 DELETE FROM Applications
                                 WHERE ApplicationID = @ApplicationID
                                 
                                 END
                                 
                                 COMMIT TRANSACTION
                                 END TRY
                                 
                                 BEGIN CATCH 
                                 IF @@TRANCOUNT > 0
                                 ROLLBACK TRANSACTION;
                                 THROW
                                 END CATCH;";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });

                    try
                    {
                        await Connection.OpenAsync();
                        return await Command.ExecuteNonQueryAsync() > 0;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                            return false;

                        throw;
                    }
                }
            }
        }

        public async Task<bool> DeleteApplicationPermanentlyAsync(int LocalDrivingLicenseApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"BEGIN TRY
                                 BEGIN TRANSACTION;
                                 
                                 DECLARE @ApplicationID INT
                                 
                                 SELECT @ApplicationID = L.ApplicationID
                                 FROM LocalDrivingLicenseApplications L
                                 WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                 
                                 IF @ApplicationID IS NOT NULL 
                                 BEGIN 
                                 
                                 DELETE FROM Tests 
                                 WHERE TestAppointmentID IN (Select TA.TestAppointmentID
                                                             FROM TestAppointments TA 
                                 							INNER JOIN Tests TS 
                                 							     ON TS.TestAppointmentID = TA.TestAppointmentID
                                 	                        WHERE TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                                 
                                 DELETE FROM TestAppointments
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                 
                                 DELETE FROM LocalDrivingLicenseApplications
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                 
                                 
                                 DELETE FROM Applications
                                 WHERE ApplicationID = @ApplicationID
                                 
                                 END
                                 
                                 COMMIT TRANSACTION
                                 END TRY
                                 
                                 BEGIN CATCH 
                                 IF @@TRANCOUNT > 0
                                 ROLLBACK TRANSACTION;
                                 THROW
                                 END CATCH;";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int)
                    { Value = LocalDrivingLicenseApplicationID });

                    try
                    {
                        await Connection.OpenAsync();
                        return await Command.ExecuteNonQueryAsync() > 0;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                            return false;

                        throw;
                    }
                }
            }
        }

        public async Task<bool> UpdateApplicationStatusAsync(int ApplicantPersonID, int CreatedByUserID,int ApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update Applications
                                 Set LastStatusDate = GETDATE(),
                                     CreatedByUserID = @CreatedByUserID,
                                     ApplicantPersonID = @ApplicantPersonID
                                 Where ApplicationID = @ApplicationID";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID });
                    Command.Parameters.Add(new SqlParameter("@ApplicantPersonID", SqlDbType.Int) { Value = ApplicantPersonID });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });
                    await Connection.OpenAsync();
                    int rowsAffected = await Command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }
    }
}