using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer.Local_Driveing_License_Applications
{
    public class ClsLocalDrivingLicenseApplicationMapper
    {
        public static ClsLocalDrivingLicense MapToClsLocalDrivingLicense(SqlDataReader Reader)
        {
            int LocalDrivingLicenseApplicationIDOrdinal = Reader.GetOrdinal("LocalDrivingLicenseApplicationID");
            int ApplicationIDOrdinal = Reader.GetOrdinal("ApplicationID");
            int LicenseClassIDOrdinal = Reader.GetOrdinal("LicenseClassID");
            int DrivingClassTitleOrdinal = Reader.GetOrdinal("ClassName");
            int ApplicationTypeIDOrdinal = Reader.GetOrdinal("ApplicationTypeID");
            int ApplicationTypeTitleOrdinal = Reader.GetOrdinal("ApplicationTypeTitle");
            int ApplicationDateOrdinal = Reader.GetOrdinal("ApplicationDate");
            int LastStatusDateOrdinal = Reader.GetOrdinal("LastStatusDate");
            int StatusOrdinal = Reader.GetOrdinal("Status");
            int PaidFeesOrdinal = Reader.GetOrdinal("PaidFees");
            int CreatedByUserIDOrdinal = Reader.GetOrdinal("CreatedByUserID");
            int UserNameOrdinal = Reader.GetOrdinal("UserName");
            int PersonIDOrdinal = Reader.GetOrdinal("PersonID");
            int FullNameOrdinal = Reader.GetOrdinal("FullName");
            int PassedTestCountOrdinal = Reader.GetOrdinal("PassedTestCount");
            int NationalNoOrdinal = Reader.GetOrdinal("NationalNo");

            return new ClsLocalDrivingLicense
            {
                LocalDrivingLicenseApplicationID = Reader.GetInt32(LocalDrivingLicenseApplicationIDOrdinal),
                ApplicationID = Reader.GetInt32(ApplicationIDOrdinal),
                LicenseClassID = Reader.GetInt32(LicenseClassIDOrdinal),
                DrivingClassTitle = Reader.GetString(DrivingClassTitleOrdinal),
                ApplicationTypeID = Reader.GetInt32(ApplicationTypeIDOrdinal),
                ApplicationTypeTitle = Reader.GetString(ApplicationTypeTitleOrdinal),
                ApplicationDate = Reader.GetDateTime(ApplicationDateOrdinal),
                LastStatusDate = Reader.GetDateTime(LastStatusDateOrdinal),
                Status = Reader.GetString(StatusOrdinal),
                PaidFees = Reader.GetDecimal(PaidFeesOrdinal),
                CreatedByUserID = Reader.GetInt32(CreatedByUserIDOrdinal),
                UserName = Reader.GetString(UserNameOrdinal),
                PersonID = Reader.GetInt32(PersonIDOrdinal),
                FullName = Reader.GetString(FullNameOrdinal),
                PassedTestCount = Reader.GetInt32(PassedTestCountOrdinal),
                NationalNo = Reader.GetString(NationalNoOrdinal)
            };
        }
    }
}
