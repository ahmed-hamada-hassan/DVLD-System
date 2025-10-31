using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Drivers_BL
{
    public class ClsDriversMapper
    {
        public static ClsDriver MapToClsDriver(SqlDataReader Reader)
        {
            int DriverID = Reader.GetOrdinal("DriverID");
            int PersonID = Reader.GetOrdinal("PersonID");
            int CreatedByUserID = Reader.GetOrdinal("CreatedByUserID");
            int CreationDate = Reader.GetOrdinal("CreatedDate");

            return new ClsDriver
            {
                DriverID = Reader.GetInt32(DriverID),
                PersonID = Reader.GetInt32(PersonID),
                CreatedByUserID = Reader.GetInt32(CreatedByUserID),
                CreationDate = Reader.GetDateTime(CreationDate)
            };
        }

        public static ClsDriverView MapToClsDriverView(SqlDataReader Reader)
        {
            int DriverID = Reader.GetOrdinal("DriverID");
            int PersonID = Reader.GetOrdinal("PersonID");
            int NationalNo = Reader.GetOrdinal("NationalNo");
            int FullName = Reader.GetOrdinal("FullName");
            int CreatedDate = Reader.GetOrdinal("CreatedDate");
            int ActiveLicenses = Reader.GetOrdinal("ActiveLicenses");

            return new ClsDriverView
            {
                DriverID = Reader.GetInt32(DriverID),
                PersonID = Reader.GetInt32(PersonID),
                NationalNo = Reader.GetString(NationalNo),
                FullName = Reader.GetString(FullName),
                CreatedDate = Reader.GetDateTime(CreatedDate),
                ActiveLicenses = Reader.GetInt32(ActiveLicenses)
            };
        }
    }
}
