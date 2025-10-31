using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class ClsUserDataAccess
    {
        public async Task<SqlDataReader> GetUsersAsync()
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From UsersWithThierNames";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetUserInfoByUserIDAsync(int  UserID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From Users where UserID = @UserID";
            var Command = new SqlCommand(Query,Connection);
            Command.Parameters.Add(new SqlParameter("@UserID",SqlDbType.Int) { Value = UserID});

            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetUserInfoByUserNameAsync(string UserName)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From Users where UserName = @UserName";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar,20) { Value = UserName });

            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetUserInfoByPersonIDAsync(int PersonID)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From Users where PersonID = @PersonID";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });

            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<bool> IsThisUserExistsAsync(int UserID)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select IIF(Exists(Select 1 From Users Where UserID = @UserID),1,0)As IsFound";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();

                    Command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = UserID });
                    IsExists = Convert.ToInt32(await Command.ExecuteScalarAsync()) > 0; 
                }
            }

            return IsExists;
        }
        public async Task<bool> IsThisUserExistsAsync(string UserName)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select IIF(Exists(Select 1 From Users Where UserName = @UserName),1,0)As IsFound";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 20) { Value = UserName });
                    IsExists = Convert.ToInt32(await Command.ExecuteScalarAsync()) > 0;
                }
            }

            return IsExists;
        }
        public async Task<bool> IsThisPasswordExistAsync(string Password)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select IIF(Exists(Select 1 From Users Where Password = @Password),1,0)As IsFound";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();

                    Command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 20) { Value = Password });
                    IsExists = Convert.ToInt32(await Command.ExecuteScalarAsync()) > 0;
                }
            }

            return IsExists;
        }
        public async Task<bool> IsThisUserExistsAsync(string UserName,string Password)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query =
                    @"Select IIF(Exists(Select 1 From Users Where UserName = 
                      @UserName And Password = @Password And IsActive = 1),1,0)As IsFound";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 20) { Value = UserName });
                    Command.Parameters.Add(new SqlParameter("@Password",SqlDbType.NVarChar,20) { Value = Password });
                    IsExists = Convert.ToInt32(await Command.ExecuteScalarAsync()) > 0;
                }
            }

            return IsExists;
        }
        public async Task<bool> IsThisUserActiveAsync(string UserName)
        {
            bool IsActive = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"SELECT IIF(IsActive = 1, 1, 0) AS IsActiveUser FROM Users WHERE UserName = @UserName";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 20) { Value = UserName });
                    IsActive = Convert.ToInt32(await Command.ExecuteScalarAsync()) > 0;
                }
            }

            return IsActive;
        }
        public async Task<bool> FindUserByAsync(int PersonID)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select IIF(Exists(Select 1 from Users Where PersonID = @PersonID),1,0)As IsFound";

                using(SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("@PersonID",SqlDbType.Int) { Value = PersonID });

                    IsExists = Convert.ToInt32(await Command.ExecuteScalarAsync()) > 0;
                }
            }
            return IsExists;
        }
        public bool FindUserBy(int PersonID)
        {
            bool IsExists = false;
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select IIF(Exists(Select 1 from Users Where PersonID = @PersonID),1,0)As IsFound";

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Connection.Open();
                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });

                    IsExists = Convert.ToInt32 (Command.ExecuteScalar()) > 0;
                }
            }
            return IsExists;
        }
        public async Task<bool> UpdatedUserInfoAsync(int UserID, string UserName, string Password, bool IsActive)
        {
            using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Update Users
                                 Set UserName = @UserName,
                                     Password = @Password,
                                 	IsActive  = @IsActive 
                                 Where UserID = @UserID";
                using (SqlCommand Command = new SqlCommand(Query, connection))
                {
                    await connection.OpenAsync().ConfigureAwait(false);
                    Command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = UserID });
                    Command.Parameters.Add(new SqlParameter("@UserName",SqlDbType.NVarChar,20) { Value = UserName });
                    Command.Parameters.Add(new SqlParameter("@Password",SqlDbType.NVarChar,20) { Value= Password });
                    Command.Parameters.Add(new SqlParameter("@IsActive",SqlDbType.Bit) { Value = IsActive });

                    return await Command.ExecuteNonQueryAsync() > 0;
                }
            }
        }
        public async Task<bool> DeleteUserAsync(int UserID)
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Delete Users Where UserID = @UserID";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    Command.Parameters.Add(new SqlParameter("UserId", SqlDbType.Int) { Value = UserID });

                    return await Command.ExecuteNonQueryAsync() > 0;
                }
            }
        }
        public async Task<int> CountRecordsAsync()
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Select Count(UserID) From Users";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync();
                    return (int)await Command.ExecuteScalarAsync();
                }
            }
        }
        public async Task<int> AddNewUserAsync(int PersonID, string UserName, string PasswordHash, byte[] PasswordSalt, bool IsActive)
        {
            using (SqlConnection Connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string Query = @"Insert Into Users (PersonID, UserName, PasswordHash, PasswordSalt, IsActive)
                                     Values (@PersonID,@UserName,@PasswordHash, @PasswordSalt,@IsActive)
                                     SELECT SCOPE_IDENTITY();";

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    await Connection.OpenAsync().ConfigureAwait(false);

                    Command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = PersonID });
                    Command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 20) { Value = UserName });
                    Command.Parameters.Add(new SqlParameter("@PasswordHash", SqlDbType.NVarChar, int.MaxValue) { Value = PasswordHash });
                    Command.Parameters.Add(new SqlParameter("@PasswordSalt", SqlDbType.VarBinary, -1) { Value = PasswordSalt });
                    Command.Parameters.Add(new SqlParameter("@IsActive", SqlDbType.Bit) { Value = IsActive });

                    object obj = await Command.ExecuteScalarAsync();
                    if (obj != null && int.TryParse(obj.ToString(), out var result))
                    {
                        return result;
                    }
                }
            }
            return -1;
        }
        public async Task<SqlDataReader> FilterUsersOrderByAsync(string Classification,string TextToSearch)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = $@"Select * From UsersWithThierNames Where {Classification} Like @FilterValue + '%'";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar, 20) { Value = TextToSearch });
            
            await Connection.OpenAsync();

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> FilterUsersOrderByActiveStatusAsync(byte SelectedStatus)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From UsersWithThierNames Where IsActive = @Status";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@Status",SqlDbType.Bit) { Value = SelectedStatus });
            await Connection.OpenAsync();
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
        public async Task<SqlDataReader> GetPersonAndUserByNationalNoAsync(string NationalNo)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            await Connection.OpenAsync().ConfigureAwait(false);
            string Query = @"Select P.PersonID , U.UserID , P.NationalNo , P.FirstName , P.SecondName , P.ThirdName , P.LastName , U.UserName ,
                                    P.Gendor , P.DateOfBirth , P.Phone , P.Email , P.Address , P.NationalityCountryID , P.ImagePath , U.IsActive
                             From People P Left Join Users U On P.PersonID = U.PersonID Where U.UserID Is Not NULL";
            var Command = new SqlCommand(Query, Connection);
            Command.Parameters.Add(new SqlParameter("@NationalNo", SqlDbType.NVarChar, 20) { Value = NationalNo });

            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);
        }
        public async Task<bool> UpdatePasswordInDatabaseAsync(int userID, string newHash, byte[] newSalt)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString))
            {
                string query = @"UPDATE Users 
                         SET PasswordHash = @PasswordHash, 
                             PasswordSalt = @PasswordSalt 
                         WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@PasswordHash", SqlDbType.NVarChar, -1) // -1 means MAX
                    {
                        Value = newHash
                    });
                    command.Parameters.Add(new SqlParameter("@PasswordSalt", SqlDbType.VarBinary, -1) // -1 means MAX
                    {
                        Value = newSalt
                    });
                    command.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        await connection.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public async Task<SqlDataReader> GetUserByUserNameAsync(string UserName)
        {
            var Connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string Query = @"Select * From Users Where UserName = @UserName";
            var Command = new SqlCommand(Query, Connection);
            await Connection.OpenAsync().ConfigureAwait(false);
            Command.Parameters.Add(new SqlParameter("@UserName",SqlDbType.NVarChar,20) { Value = UserName });
            return await Command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
