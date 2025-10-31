using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsDriversDataAccess
    {
        public async Task<SqlDataReader> GetDriverInfoByPersonIDAsync(int PersonID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From Drivers Where PersonID = @PersonID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value =  PersonID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<int> AddNewDriverAsync(int PersonID, int CreatedByUserID, DateTime CreationDate)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedDate)
                             SELECT SCOPE_IDENTITY();";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = CreatedByUserID });
                    Command.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = CreationDate });

                    await Connection.OpenAsync();
                    return (int)await Command.ExecuteScalarAsync();
                }
            }

        }
        public async Task<SqlDataReader> GetDriversAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From DriversInfo_View";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterDriversAccordingByAsync(string FilterBy, string FilterValue)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From DriversInfo_View Where " + FilterBy + " LIKE @FilterValue";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar) { Value = FilterValue + "%" });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
