using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsCountryDataAccess
    {
        public async Task<SqlDataReader> GetAllCountriesAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From Countries";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            
        }
        public async Task<string> GetCountryNameByIDAsync(int CountryID)
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = "Select CountryName From Countries Where CountryID = @CountryID";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CountryID", CountryID);
                    await Connection.OpenAsync();
                    object result = await Command.ExecuteScalarAsync();
                    return result?.ToString() ?? string.Empty;
                }
            }
            
        }
    }
}
