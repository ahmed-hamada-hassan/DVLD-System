using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsLicenseClassesDataAccess
    {
        public async Task<SqlDataReader> GetLicenseClassesAsync()
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseClasses";
            var command = new SqlCommand(Query, connection);
            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetLicenseClassesWithIDAsync(int LicenseClassID)
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            var command = new SqlCommand(Query, connection);
            command.Parameters.Add(new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = LicenseClassID });
            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetLicenseClassesWithNameAsync(string ClassName)
        {
            var connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From LicenseClasses Where ClassName = @ClassName";
            var command = new SqlCommand(Query, connection);
            command.Parameters.Add(new SqlParameter("@ClassName", SqlDbType.NVarChar,50) { Value = ClassName });
            await connection.OpenAsync();
            return await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
