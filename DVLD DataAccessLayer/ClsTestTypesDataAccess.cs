using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsTestTypesDataAccess
    {
        public async Task<SqlDataReader> GetAllTestTypesAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From TestTypes";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetTestTypeByIDAsync(int TestTypeID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From TestTypes Where TestTypeID = @TestTypeID";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            Command.Parameters.Add(new SqlParameter("@TestTypeID",SqlDbType.Int) { Value = TestTypeID });
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<int> CountAllTestTypesAsync()
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select Count(TestTypeID) From TestTypes";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();

                    return await Command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task<bool> UpdateTestTypeAsync(int TestTypeID,string TestTypeTitle,string TestTypeDescription,decimal TestTypeFees)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update TestTypes
                                 Set TestTypeTitle = @TestTypeTitle ,
                                     TestTypeDescription = @TestTypeDescription ,
                                 	TestTypeFees = @TestTypeFees
                                 Where TestTypeID = @TestTypeID ";

                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();

                    Command.Parameters.Add(new SqlParameter("@TestTypeTitle",SqlDbType.NVarChar,100) { Value = TestTypeTitle });
                    Command.Parameters.Add(new SqlParameter("@TestTypeDescription",SqlDbType.NVarChar,500) { Value = TestTypeDescription });
                    Command.Parameters.Add(new SqlParameter("@TestTypeFees",SqlDbType.SmallMoney) { Value = TestTypeFees });
                    Command.Parameters.Add(new SqlParameter("@TestTypeID",SqlDbType.Int) { Value = TestTypeID });

                    return await Command.ExecuteNonQueryAsync() > 0;
                }
            }
        }
    }
}
