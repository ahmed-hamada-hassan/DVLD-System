using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_Classes_BL
{
    public class ClsLicenseClassesMapper
    {
        public static ClsLicenseClasses MapToClsLicenseClasses(SqlDataReader Reader)
        {
            int LicenseClassID = Reader.GetOrdinal("LicenseClassID");
            int ClassName = Reader.GetOrdinal("ClassName");
            int ClassDescription = Reader.GetOrdinal("ClassDescription");
            int MinimumAllowedAge = Reader.GetOrdinal("MinimumAllowedAge");
            int DefaultValidityLength = Reader.GetOrdinal("DefaultValidityLength");
            int ClassFees = Reader.GetOrdinal("ClassFees");

            return new ClsLicenseClasses
            {
                LicenseClassID = Reader.GetInt32(LicenseClassID),
                ClassName = Reader.GetString(ClassName),
                ClassDescription = Reader.GetString(ClassDescription),
                MinimumAllowedAge = Reader.GetByte(MinimumAllowedAge),
                DefaultValidityLength = Reader.GetByte(DefaultValidityLength),
                ClassFees = Reader.GetDecimal(ClassFees)
            };
        }
    }
}
