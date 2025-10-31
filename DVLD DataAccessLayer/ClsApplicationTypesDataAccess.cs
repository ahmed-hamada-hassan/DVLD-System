using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsApplicationTypesDataAccess
    {
        public async Task<SqlDataReader> GetApplicationTypesAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From ApplicationTypes";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<int> CountApplicationTypesAsync()
        {
            using (SqlConnection Connection  = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select Count(ApplicationTypeID) From ApplicationTypes";
                using(SqlCommand command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    return (int) await command.ExecuteScalarAsync();
                }
            }
        }
        public async Task<SqlDataReader> GetApplicationTypeByIDAsync(int ApplicationTypeID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From ApplicationTypes Where ApplicationTypeID = @ApplicationTypeID";
            var Command = new SqlCommand(Query,Connection);
            await Connection.OpenAsync();
            Command.Parameters.Add(new SqlParameter("@ApplicationTypeID", SqlDbType.Int) { Value = ApplicationTypeID });
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<bool> UpdateApplicationTypeInfoAsync(string ApplicationTypeTitle,decimal ApplicationFees , int ApplicationTypeID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update ApplicationTypes
                                 Set ApplicationTypeTitle = @ApplicationTypeTitle,
                                     ApplicationFees = @ApplicationFees
                                 where ApplicationTypeID = @ApplicationTypeID ";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@ApplicationTypeTitle",SqlDbType.NVarChar,150) { Value = ApplicationTypeTitle });
                    Command.Parameters.Add(new SqlParameter("@ApplicationFees",SqlDbType.SmallMoney) { Value = ApplicationFees });
                    Command.Parameters.Add(new SqlParameter("@ApplicationTypeID",SqlDbType.Int) { Value = ApplicationTypeID });

                    return await Command.ExecuteNonQueryAsync() > 0;
                }
            }
        }
        public async Task<decimal> GetApplicationFeesByIDAsync(int ApplicationTypeID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select ApplicationFees From ApplicationTypes Where ApplicationTypeID = @ApplicationTypeID";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@ApplicationTypeID",SqlDbType.Int) { Value = ApplicationTypeID });

                    return (decimal) await Command.ExecuteScalarAsync();
                }
            }
        }
    }
}
