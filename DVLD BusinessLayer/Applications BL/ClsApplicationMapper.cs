using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Applications_BL
{
    public class ClsApplicationMapper
    {
        public static ClsApplication MapToClsApplication(SqlDataReader Reader)
        {
            int ApplicationID = Reader.GetOrdinal("ApplicationID");
            int ApplicantPersonID = Reader.GetOrdinal("ApplicantPersonID");
            int ApplicationDate = Reader.GetOrdinal("ApplicationDate");
            int ApplicationTypeID = Reader.GetOrdinal("ApplicationTypeID");
            int ApplicationStatus = Reader.GetOrdinal("ApplicationStatus");
            int LastStatusDate = Reader.GetOrdinal("LastStatusDate");
            int PaidFees = Reader.GetOrdinal("PaidFees");
            int CreatedByUserID = Reader.GetOrdinal("CreatedByUserID");

            return new ClsApplication
            {
                ApplicationID = Reader.GetInt32(ApplicationID),
                ApplicationPersonID = Reader.GetInt32(ApplicantPersonID),
                ApplicationDate = Reader.GetDateTime(ApplicationDate),
                ApplicationTypeID = Reader.GetInt32(ApplicationTypeID),
                ApplicationStatus = Reader.GetByte(ApplicationStatus),
                LastStatusDate = Reader.GetDateTime(LastStatusDate),
                PaidFees = Reader.GetDecimal(PaidFees),
                CreatedByUserID = Reader.GetInt32(CreatedByUserID)
            };
        }
    }
}
