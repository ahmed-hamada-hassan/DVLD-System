using DVLD_BusinessLayer.ApplicationsBL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Application_Types_BL
{
    public class ClsApplicationTypeMapper
    {
        public static ClsApplicationType MapToClsApplicationType(SqlDataReader Reader)
        {
            int ApplicationTypeID = Reader.GetOrdinal("ApplicationTypeID");
            int ApplicationTypeTitle = Reader.GetOrdinal("ApplicationTypeTitle");
            int ApplicationFees = Reader.GetOrdinal("ApplicationFees");

            return new ClsApplicationType
            {
                ApplicationID = Reader.GetInt32(ApplicationTypeID),
                ApplicationName = Reader.GetString(ApplicationTypeTitle),
                ApplicationFees = Reader.GetDecimal(ApplicationFees)
            };
        }
    }
}
