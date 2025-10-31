using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsInternationalLicensesDataAccess
    {
        public async Task<int> AddNewInternationalLicenseAsync(int ApplicationID, int DriverID, int LocalLicenseID, DateTime IssueDate, 
                                                               DateTime ExpirationDate, int CreatedByUserID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Insert Into InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, 
                                 IsActive, CreatedByUserID) 
                                 Values (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, 1, @CreatedByUserID);
                                 Select SCOPE_IDENTITY();";
                var Command = new SqlCommand(Query, Connection);
                Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID });
                Command.Parameters.Add(new SqlParameter("@DriverID", SqlDbType.Int) { Value = DriverID });
                Command.Parameters.Add(new SqlParameter("@IssuedUsingLocalLicenseID", SqlDbType.Int) { Value = LocalLicenseID });
                Command.Parameters.Add(new SqlParameter("@IssueDate", SqlDbType.Date) { Value = IssueDate });
                Command.Parameters.Add(new SqlParameter("@ExpirationDate", SqlDbType.Date) { Value = ExpirationDate });
                Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });
                await Connection.OpenAsync();
                return Convert.ToInt32(await Command.ExecuteScalarAsync());
            }
        }
        public async Task<SqlDataReader> GetAllInternationalLicensesAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From InternationalLicenses";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetInternationalLicenseByIDAsync(int InternationalLicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetAllInternationalLicenseByDriverIDAsync(int DriverID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From InternationalLicenses Where DriverID = @DriverID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetInternationalLicenseByIssuedLocalLicenseIDAsync(int LocalLicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From InternationalLicenses Where IssuedUsingLocalLicenseID = @LocalLicenseID And IsActive = 1";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetAllInternationalLicenseByIssuedLocalLicenseIDAsync(int LocalLicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From InternationalLicenses Where IssuedUsingLocalLicenseID = @LocalLicenseID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterInternationalLicensesAccordingByAsync(string Filter, string SearchedText)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = $@"Select * From InternationalLicenses Where {Filter} Like @FilterValue + '%'";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar, 14) { Value = SearchedText });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterInternationalLicensesByActiveStatusAsync(bool IsActive)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From InternationalLicenses Where IsActive = @IsActive";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetInternationalLicenseInfoByInternationalLicenseIDAsync(int InternationalLicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From AllAboutInternationalDrivingLicense Where InternationalLicenseID = @InternationalLicenseID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@InternationalLicenseID", SqlDbType.Int) { Value = InternationalLicenseID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
