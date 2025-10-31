using DVLD_BusinessLayer.UserBL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.User_BL
{
    public class ClsUserMapper
    {
        public static ClsUser MapToClsUser(SqlDataReader Reader)
        {
            int UserIDOrdinal = Reader.GetOrdinal("UserID");
            int UserNameOrdinal = Reader.GetOrdinal("UserName");
            int PersonIDOrdinal = Reader.GetOrdinal("PersonID");
            int PasswordOrdinal = Reader.GetOrdinal("Password");
            int IsActiveOrdinal = Reader.GetOrdinal("IsActive");
            int PasswordHashOrdinal = Reader.GetOrdinal("PasswordHash");
            int PasswordSaltOrdinal = Reader.GetOrdinal("PasswordSalt");

            return new ClsUser
            {
                UserID = Reader.GetInt32(UserIDOrdinal),
                UserName = Reader.GetString(UserNameOrdinal),
                PersonID = Reader.GetInt32(PersonIDOrdinal),
                IsActive = Reader.GetBoolean(IsActiveOrdinal),
                PasswordHash = Reader.IsDBNull(PasswordHashOrdinal) ? null : Reader.GetString(PasswordHashOrdinal),
                PasswordSalt = Reader.IsDBNull(PasswordSaltOrdinal) ? null : (byte[])Reader[PasswordSaltOrdinal]
            };
        }

        public static ClsUserView MapToClsUserView(SqlDataReader Reader)
        {
            int UserIDOrdinal = Reader.GetOrdinal("UserID");
            int PersonIDOrdinal = Reader.GetOrdinal("PersonID");
            int FullNameOrdinal = Reader.GetOrdinal("FullName");
            int UserNameOrdinal = Reader.GetOrdinal("UserName");
            int IsActiveOrdinal = Reader.GetOrdinal("IsActive");
            
            return new ClsUserView
            {
                UserID = Reader.GetInt32(UserIDOrdinal),
                PersonID = Reader.GetInt32(PersonIDOrdinal),
                FullName = Reader.GetString(FullNameOrdinal),
                UserName = Reader.GetString(UserNameOrdinal),
                IsActive = Reader.GetBoolean(IsActiveOrdinal)
            };
        }
    }
}
