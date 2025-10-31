using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsLocalDrivingLicenseApplicationsDataAccess
    {
        public async Task<int> AddNewLocalDrivingLicenseApplicationAsync(int ApplicationID, int LicenseClassID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) 
                               VALUES (@ApplicationID, @LicenseClassID); 
                               SELECT SCOPE_IDENTITY();";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID });
                    Command.Parameters.Add(new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = LicenseClassID });
                    await Connection.OpenAsync();

                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
        }

        public async Task<int> FindLicenseClassIDByApplicationIDAsync(int ApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select LicenseClassID From LocalDrivingLicenseApplications Where ApplicationID = @ApplicationID";
                using (var Command = new SqlCommand(Query,Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = ApplicationID });
                    await Connection.OpenAsync();

                    return (int)await Command.ExecuteScalarAsync();
                }
            }
        }

        public async Task<SqlDataReader> GetAllLocalDrivingLicenseApplicationsAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From AllAboutLocalDrivingLicenseApplication";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }

        public async Task<SqlDataReader> FilterLocalDrivingLicenseAccordingByAsync(string Filter , string SearchedText)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = $@"Select * From AllAboutLocalDrivingLicenseApplication Where {Filter} Like @FilterValue + '%'";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar, 20) { Value = SearchedText });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }

        public async Task<SqlDataReader> FilterLocalDrivingLicenseAccordingByStatusAsync(string Status)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From AllAboutLocalDrivingLicenseApplication Where Status = @Status";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 10) { Value = Status });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }

        public async Task<SqlDataReader> GetDrivingLicenseApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From AllAboutLocalDrivingLicenseApplication 
                             Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            var Command = new SqlCommand(Query,Connection);
            Command.Parameters.Add(new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = LocalDrivingLicenseApplicationID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
