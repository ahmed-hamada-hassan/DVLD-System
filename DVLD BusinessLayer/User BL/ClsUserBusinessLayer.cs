using DVLD_BusinessLayer.PoepleBL;
using DVLD_BusinessLayer.User_BL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.UserBL
{
    public class ClsUserBusinessLayer
    {
        private readonly ClsUserDataAccess _userDAL = new ClsUserDataAccess();

        public async Task<bool> IsThisUserNameExistsAsync(string userName)
        {
            return await _userDAL.IsThisUserExistsAsync(userName);
        }

        public async Task<bool> IsThisPasswordExistsAsync(string Password)
        {
            return await _userDAL.IsThisPasswordExistAsync(Password);
        }

        public async Task<bool> IsThisUserExistsAsync(string userName,string Password)
        {
            return await _userDAL.IsThisUserExistsAsync(userName,Password);
        }

        public async Task<bool> IsThisUserActive(string userName)
        {
            return await _userDAL.IsThisUserActiveAsync(userName);
        }

        public async Task<List<ClsUserView>> GetUsersAsync()
        {
            var users = new List<ClsUserView>();

            using (var reader = await _userDAL.GetUsersAsync())
            {
                while (await reader.ReadAsync())
                {
                    users.Add(ClsUserMapper.MapToClsUserView(reader));
                }
            }

            return users;
        }

        public async Task<int> CountUserAsync()
        {
            return await _userDAL.CountRecordsAsync();
        }

        public async Task<bool> AddNewUserAsync(ClsUser user)
        {
            string PlainTextPassword = user.Password;
            byte[] Salt = ClsSecureHelperUserInfo.GenerateSalt();
            user.PasswordHash = ClsSecureHelperUserInfo.HashPassword(PlainTextPassword, Salt);
            user.PasswordSalt = Salt;
            user.Password = null;

            user.UserID = await _userDAL.AddNewUserAsync(user.PersonID, user.UserName, user.PasswordHash, user.PasswordSalt, user.IsActive);

            return (user.UserID != -1);
        }

        public async Task<bool> FindUserByAsync(int PersonID)
        {
            return await _userDAL.FindUserByAsync(PersonID);
        }

        public  bool FindUserBy(int PersonID)
        {
            return _userDAL.FindUserBy(PersonID);
        }

        public async Task<List<ClsUserView>> FilterUsersOrderByAsync(string Classification, string TextToSearch)
        {
            var users = new List<ClsUserView>();
            using (var reader = await _userDAL.FilterUsersOrderByAsync(Classification, TextToSearch))
            {
                while (await reader.ReadAsync())
                {
                    users.Add(ClsUserMapper.MapToClsUserView(reader));
                }
            }
            return users;
        }

        public async Task<List<ClsUserView>> FilterUsersOrderByActiveStatusAsync(byte SelectedStatus)
        {
            var users = new List<ClsUserView>();
            using (var reader = await _userDAL.FilterUsersOrderByActiveStatusAsync(SelectedStatus))
            {
                while (await reader.ReadAsync())
                {
                    users.Add(ClsUserMapper.MapToClsUserView(reader));
                }
            }
            return users;
        }

        public async Task<bool> UpdateUserInfoAsync(ClsUser User)
        {
            return await _userDAL.UpdatedUserInfoAsync(User.UserID,User.UserName,User.Password,User.IsActive);
        }

        public async Task<ClsUser> GetUserInfoByUserIDAsync(int UserID)
        {
            using (var reader = await _userDAL.GetUserInfoByUserIDAsync(UserID))
            {
                if(await reader.ReadAsync())
                {
                    return ClsUserMapper.MapToClsUser(reader);
                }
            }
            return null;
        }

        public async Task<bool> DeleteUserAsync(int UserID)
        {
            return await _userDAL.DeleteUserAsync(UserID);
        }

        public async Task<bool> UpdatePasswordAsync(string OldPassword, string NewPassword , int UserID)
        {
            
            ClsUser user = await GetUserInfoByUserIDAsync(UserID);
            if (user == null)
            {
                return false; 
            }

            bool isOldPasswordValid = ClsSecureHelperUserInfo.VerifyPassword(
                OldPassword,
                user.PasswordHash,
                user.PasswordSalt
            );

            if (!isOldPasswordValid)
            {
                return false; 
            }

            byte[] newSalt = ClsSecureHelperUserInfo.GenerateSalt();
            string newHash = ClsSecureHelperUserInfo.HashPassword(NewPassword, newSalt);

            
            return await _userDAL.UpdatePasswordInDatabaseAsync(UserID, newHash, newSalt);
        }

        public async Task<ClsUser> GetUserByUserNameAsync(string UserName)
        {
            using (var Reader = await _userDAL.GetUserByUserNameAsync(UserName))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsUserMapper.MapToClsUser(Reader);
                }
            }
            return null;
        }

        public async Task<ClsUser> GetUserInfoByPersonIDAsync(int PersonID)
        {
            using (var Reader = await _userDAL.GetUserInfoByPersonIDAsync(PersonID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsUserMapper.MapToClsUser(Reader);
                }
            }
            return null;
        }

        public async Task<ClsUser> AuthenticateUserAsync(string UserName, string Password)
        {
            ClsUser user = await GetUserByUserNameAsync(UserName);
            if(user == null) return null;
            if(!user.IsActive) return null;
            
            bool isPasswordValid = await Task.Run(() => 
                ClsSecureHelperUserInfo.VerifyPassword(Password, user.PasswordHash, user.PasswordSalt));
            
            if(!isPasswordValid) return null;
            
            user.PasswordHash = null;
            user.PasswordSalt = null;
            return user;
        }
    }
}
