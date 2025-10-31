using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccessLayer
{
    public class ClsLicenseDataAccess
    {
        public async Task<SqlDataReader> GetLicenseInfoByApplicationIDAsync(int ApplicationID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID});
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetAllLicenseInfoByDriverIDAsync(int DriverID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"SELECT * FROM Licenses WHERE DriverID = @DriverID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@DriverID", SqlDbType.Int) { Value = DriverID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetLicenseInfoByPersonIDAsync(int PersonID, int LicenseClassID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select L.*
                             From Licenses L 
                             INNER JOIN Applications APP 
                                  ON L.ApplicationID = APP.ApplicationID 
                             WHERE APP.ApplicantPersonID = @PersonID
                             AND L.LicenseClass = @LicenseClassID";

            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
            Command.Parameters.Add(new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = LicenseClassID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetActiveLicenseByNationalNumberAsync(string NationalNumber)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseInfo_View Where NationalNo = @NationalNumber And IsActive = 1";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@NationalNumber", SqlDbType.NVarChar, 20) { Value = NationalNumber });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetLicenseInfoByLicenseIDAsync(int LicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseInfo_View Where LicenseID = @LicenseID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetAllAboutLicenseByDriverIDAsync(int DriverID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseInfo_View Where DriverID = @DriverID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@DriverID", SqlDbType.Int) { Value = DriverID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetAllAboutLicenseByLicenseIDAsync(int LicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseInfo_View Where LicenseID = @LicenseID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetAllAboutLicenseByPersonIDAsync(int PersonID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseInfo_View Where PersonID = @PersonID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<bool> IsActiveOrdinaryLicenseByIDAsync(int LicenseID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                var Query = @"Select IIF(Exists(Select 1 From Licenses Where LicenseID = @LicenseID And LicenseClass = 3 And IsActive = 1), 1, 0) 
                                   As IsOrdinary";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });
                    await Connection.OpenAsync();
                    return Convert.ToBoolean(await Command.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> IsActiveLicenseByIDAsync(int LicenseID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                var Query = @"Select IIF(Exists(Select 1 From Licenses Where LicenseID = @LicenseID And IsActive = 1), 1, 0) 
                                   As IsActive";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });
                    await Connection.OpenAsync();
                    return Convert.ToBoolean(await Command.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> DeActiveLicenseByIDAsync(int LicenseID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                var Query = @"Update Licenses Set IsActive = 0 Where LicenseID = @LicenseID";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });
                    await Connection.OpenAsync();
                    return Convert.ToInt32(await Command.ExecuteNonQueryAsync()) > 0;
                }
            }
        }
        public async Task<int> AddNewLicenseAsync(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
                                                  string Notes, decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,
                                                   IssueReason, CreatedByUserID)
                             VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive,
                                     @IssueReason, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID });
                    Command.Parameters.Add(new SqlParameter("@DriverID", SqlDbType.Int) { Value = DriverID });
                    Command.Parameters.Add(new SqlParameter("@LicenseClass", SqlDbType.Int) { Value = LicenseClass });
                    Command.Parameters.Add(new SqlParameter("@IssueDate", SqlDbType.DateTime) { Value = IssueDate });
                    Command.Parameters.Add(new SqlParameter("@ExpirationDate", SqlDbType.DateTime) { Value = ExpirationDate });
                    Command.Parameters.Add(new SqlParameter("@Notes", SqlDbType.NVarChar, 500) {Value = (object)Notes ?? DBNull.Value});
                    Command.Parameters.Add(new SqlParameter("@PaidFees", SqlDbType.SmallMoney) { Value = PaidFees });
                    Command.Parameters.Add(new SqlParameter("@IsActive", SqlDbType.Bit) { Value = IsActive });
                    Command.Parameters.Add(new SqlParameter("@IssueReason", SqlDbType.Int) { Value = IssueReason });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });

                    await Connection.OpenAsync();

                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> FindIfHasActiveLicenseByPersonIDAsync(int PersonID, int LicenseClassID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"SELECT 
                                 CASE 
                                     WHEN EXISTS (
                                         SELECT 1 
                                         FROM Licenses L  
                                         INNER JOIN Applications APP  
                                             ON L.ApplicationID = APP.ApplicationID  
                                         WHERE APP.ApplicantPersonID = @PersonID
                                         AND L.IsActive = 1 AND L.LicenseClass = @LicenseClassID
                                     )
                                     THEN CAST(1 AS BIT)
                                     ELSE CAST(0 AS BIT)
                                 END AS HasLicense;";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    Command.Parameters.Add(new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = LicenseClassID });
                    await Connection.OpenAsync();
                    int count = Convert.ToInt32(await Command.ExecuteScalarAsync());
                    return count > 0;
                }
            }
        }
    }
}
