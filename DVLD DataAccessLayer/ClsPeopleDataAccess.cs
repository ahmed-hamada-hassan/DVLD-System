using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsPeopleDataAccess
    {
        public async Task<SqlDataReader> GetPeopleAsync(string OrderBy = "NationalNo")
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From PeopleWithCountries Order By @OrderBy ASC";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@OrderBy", SqlDbType.NVarChar, 50) { Value = OrderBy });
            await Connection.OpenAsync();

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetPeopleAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From PeopleWithCountries";
            var Command = new SqlCommand(Query, Connection);
             
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<int> AddNewPersonAsync(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo
                                , string Address, string Phone, string Email, string ImagePath, DateTime DateOfBirth, char Gendor
                                , int NationalityCountryID)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
                {
                    string Query = @"
                                      INSERT INTO People 
                                      (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                                      Address, Phone, Email, NationalityCountryID, ImagePath)
                                      VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor,
                                      @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                                      SELECT SCOPE_IDENTITY();";

                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        await Connection.OpenAsync();

                        Command.Parameters.Add(new SqlParameter("@NationalNo", SqlDbType.NVarChar, 20) { Value = NationalNo });
                        Command.Parameters.Add(new SqlParameter("@FirstName" , SqlDbType.NVarChar, 20) { Value = FirstName });
                        Command.Parameters.Add(new SqlParameter("@SecondName", SqlDbType.NVarChar, 20) { Value = SecondName });
                        Command.Parameters.Add(new SqlParameter("@ThirdName", SqlDbType.NVarChar, 20) { Value = ThirdName });
                        Command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 20) { Value = LastName });
                        Command.Parameters.Add(new SqlParameter("@DateOfBirth", SqlDbType.DateTime) { Value = DateOfBirth.ToShortDateString() });
                        Command.Parameters.Add(new SqlParameter("@Gendor", SqlDbType.Char, 1) { Value = Gendor });
                        Command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 500) { Value = Address });
                        Command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = Phone });
                        Command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = Email });
                        Command.Parameters.Add(new SqlParameter("@NationalityCountryID", SqlDbType.Int) { Value = NationalityCountryID });
                        Command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250) 
                                                                { 
                                                                    Value = (object)ImagePath ?? DBNull.Value
                                                                });
                        
                        object obj = await Command.ExecuteScalarAsync();
                        if (obj != null && int.TryParse(obj.ToString(), out var result))
                        {
                            return result;
                        }
                    }
                }
            }
            catch
            {
                // To Save StackTrace
                throw;
            }
            return -1;
        }
        public async Task<bool> FindPersonByNationalNumberAsync(string NationalNumber)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select 
                                 Case 
                                 When Exists (Select 1 From People Where NationalNo = @NationalNo)
                                 Then Cast (1 As Bit)
                                 Else Cast (0 As Bit)
                                 End As IsExists";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.AddWithValue("@NationalNo", NationalNumber);
                    IsExists = (bool) await Command.ExecuteScalarAsync();
                }
            }
            return IsExists;
        }
        public async Task<int> CountPeopleAsync()
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select count(PersonID) from People";
                using (SqlCommand command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    return (int) await command.ExecuteScalarAsync();
                }
            }
        }
        public async Task<bool> FindPersonByIDAsync(int PersonID)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select 
                                 Case 
                                 When Exists (Select 1 From People Where PersonID = @PersonID)
                                 Then Cast (1 As Bit)
                                 Else Cast (0 As Bit)
                                 End As IsExists";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    IsExists = (bool) await Command.ExecuteScalarAsync();
                }
            }
            return IsExists;
        }
        public async Task<SqlDataReader> GetPersonInfoByIDAsync(int PersonID)
        {
            var Connection =  new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From People Where PersonID = @PersonID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
            await Connection.OpenAsync();

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

        }
        public async Task<SqlDataReader> GetPersonInfoByNationalNoAsync(string NationalNo)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From People Where NationalNo = @NationalNo";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@NationalNo", SqlDbType.NVarChar, 20) { Value = NationalNo });
            await Connection.OpenAsync();

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetPersonInfoByDriverIDAsync(int DriverID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select P.* From People P
                             Inner Join Drivers D On P.PersonID = D.PersonID
                             Where D.DriverID = @DriverID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@DriverID", SqlDbType.Int) { Value = DriverID });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<string> GetPersonFullNameByIDAsync(int PersonID)
        {
            string FullName = string.Empty;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName As FullName 
                                 From People Where PersonID = @PersonID";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    var obj = await Command.ExecuteScalarAsync();
                    if (obj != null)
                        FullName = obj.ToString();
                }
            }
            return FullName;
        }
        public async Task<string> GetPersonFullNameByNationalNoAsync(string NationalNo)
        {
            string FullName = string.Empty;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName As FullName 
                                 From People Where NationalNo = @NationalNo";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@NationalNo", SqlDbType.NVarChar, 20) { Value = NationalNo });
                    var obj = await Command.ExecuteScalarAsync();
                    if (obj != null)
                        FullName = obj.ToString();
                }
            }
            return FullName;
        }
        public async Task<bool> UpdatePersonInfoAsync(int PersonID ,string FirstName, string SecondName, string ThirdName
                                , string LastName, string NationalNo, string Address, string Phone, string Email
                                , string ImagePath, DateTime DateOfBirth, char Gendor , int NationalityCountryID)
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"
                                 UPDATE People
                                 SET FirstName = @FirstName,
                                     SecondName = @SecondName,
                                     ThirdName = @ThirdName,
                                     LastName = @LastName,
                                     NationalNo = @NationalNo,
                                     DateOfBirth = @DateOfBirth,
                                     Gendor = @Gendor,
                                     Phone = @Phone,
                                     Email = @Email,
                                     Address = @Address,
                                     NationalityCountryID = @NationalityCountryID,
                                     ImagePath = @ImagePath
                                 WHERE PersonID = @PersonID";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();

                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    Command.Parameters.Add(new SqlParameter("@NationalNo", SqlDbType.NVarChar, 20) { Value = NationalNo });
                    Command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 20) { Value = FirstName });
                    Command.Parameters.Add(new SqlParameter("@SecondName", SqlDbType.NVarChar, 20) { Value = SecondName });
                    Command.Parameters.Add(new SqlParameter("@ThirdName", SqlDbType.NVarChar, 20) { Value = ThirdName });
                    Command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 20) { Value = LastName });
                    Command.Parameters.Add(new SqlParameter("@DateOfBirth", SqlDbType.DateTime) { Value = DateOfBirth });
                    Command.Parameters.Add(new SqlParameter("@Gendor", SqlDbType.Char, 1) { Value = Gendor });
                    Command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 500) { Value = Address });
                    Command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = Phone });
                    Command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = Email });
                    Command.Parameters.Add(new SqlParameter("@NationalityCountryID", SqlDbType.Int) { Value = NationalityCountryID });
                    Command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250)
                                                           {
                                                               Value = (object)ImagePath ?? DBNull.Value
                                                           });

                    return await Command.ExecuteNonQueryAsync() > 0;
                }
            }
        }
        public async Task<bool> DeletePersonAsync(int PersonID)
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string deleteQuery = @"DELETE FROM People WHERE PersonID = @PersonID";
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, Connection))
                {
                    deleteCommand.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    try
                    {
                        await Connection.OpenAsync();
                        return await deleteCommand.ExecuteNonQueryAsync() > 0;
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
        public async Task<SqlDataReader> FilterPeopleAccordingByAsync(string FilterBy, string FilterValue)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From PeopleWithCountries Where " + FilterBy + " LIKE @FilterValue";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar) { Value = FilterValue + "%" });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterPeopleAccordingByGenderAsync(char Gender)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From PeopleWithCountries Where Gendor = @Gender";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Char, 1) { Value = Gender});
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection); 
        }
    }
}