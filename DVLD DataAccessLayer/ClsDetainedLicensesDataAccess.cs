using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsDetainedLicensesDataAccess
    {
        public async Task<int> AddNewDetainedLicenseAsync(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Insert Into DetainedLicenses
                                 (LicenseID, DetainDate, FineFees, CreatedByUserID)
                                 Values
                                 (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID);
                                 Select SCOPE_IDENTITY();";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@LicenseID", System.Data.SqlDbType.Int) { Value = LicenseID });
                    Command.Parameters.Add(new SqlParameter("@DetainDate", System.Data.SqlDbType.DateTime) { Value = DetainDate });
                    Command.Parameters.Add(new SqlParameter("@FineFees", System.Data.SqlDbType.Decimal) { Value = FineFees });
                    Command.Parameters.Add(new SqlParameter("@CreatedByUserID", System.Data.SqlDbType.Int) { Value = CreatedByUserID });
                    return Convert.ToInt32(await Command.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> CheckIfLicenseIsDetainedAsync(int LicenseID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select IIF(Exists(Select 1 From DetainedLicenses DL
                                 INNER JOIN Licenses L
				                      ON DL.LicenseID = L.LicenseID
				                 Where DL.LicenseID = @LicenseID And DL.IsReleased = 0 And L.IsActive = 1),1,0) As IsDetained";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@LicenseID", System.Data.SqlDbType.Int) { Value = LicenseID });
                    int Count = Convert.ToInt32(await Command.ExecuteScalarAsync());
                    return Count > 0;
                }
            }
        }
        public async Task<SqlDataReader> GetDetainLicenseInfoByLicenseIDAsync(int LicenseID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From DetainedLicenses Where LicenseID = @LicenseID AND IsReleased = 0";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<bool> ReleaseDetainedLicenseAsync(int DetainID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            using (var Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update DetainedLicenses
                                 Set IsReleased = 1,
                                     ReleaseDate = @ReleaseDate,
                                     ReleasedByUserID = @ReleasedByUserID,
                                     ReleaseApplicationID = @ReleaseApplicationID
                                 Where DetainID = @DetainID";
                using (var Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@DetainID", SqlDbType.Int) { Value = DetainID });
                    Command.Parameters.Add(new SqlParameter("@ReleaseDate", SqlDbType.DateTime) { Value = ReleaseDate });
                    Command.Parameters.Add(new SqlParameter("@ReleasedByUserID", SqlDbType.Int) { Value = ReleasedByUserID });
                    Command.Parameters.Add(new SqlParameter("@ReleaseApplicationID", SqlDbType.Int) { Value = ReleaseApplicationID });
                    int RowsAffected = await Command.ExecuteNonQueryAsync();
                    return RowsAffected > 0;
                }
            }
        }
        public async Task<SqlDataReader> GetAllDetainedLicensesAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From DetainedLicenseInfo_View";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterDetainedLicensesAccordingByAsync(string Filter, string SearchedText)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = $@"Select * From DetainedLicenseInfo_View Where {Filter} Like @FilterValue + '%'";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar) { Value = SearchedText });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterDetainedLicensesAccordingByReleaseStatusAsync(bool IsReleased)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From DetainedLicenseInfo_View Where IsReleased = @IsReleased";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@IsReleased", SqlDbType.Bit) { Value = IsReleased });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
