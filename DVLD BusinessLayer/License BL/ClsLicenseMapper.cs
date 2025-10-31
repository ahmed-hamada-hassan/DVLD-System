using DVLD_BusinessLayer.License_BL.Detained_License_BL;
using DVLD_BusinessLayer.License_BL.International_License_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer.License_BL.Local_License_BL
{
    public class ClsLicenseMapper
    {
        public static ClsLicense MapToClsLicense(SqlDataReader Reader)
        {
            int LicenseIDOrdinal = Reader.GetOrdinal("LicenseID");
            int ApplicationIDOrdinal = Reader.GetOrdinal("ApplicationID");
            int DriverIDOrdinal = Reader.GetOrdinal("DriverID");
            int LicenseClassIDOrdinal = Reader.GetOrdinal("LicenseClassID");
            int IssueDateOrdinal = Reader.GetOrdinal("IssueDate");
            int ExpirationDateOrdinal = Reader.GetOrdinal("ExpirationDate");
            int NotesOrdinal = Reader.GetOrdinal("Notes");
            int PaidFeesOrdinal = Reader.GetOrdinal("PaidFees");
            int IsActiveOrdinal = Reader.GetOrdinal("IsActive");
            int IssueReasonOrdinal = Reader.GetOrdinal("IssueReason");
            int CreatedByUserIDOrdinal = Reader.GetOrdinal("CreatedByUserID");

            return new ClsLicense
            {
                LicenseID = Reader.GetInt32(LicenseIDOrdinal),
                ApplicationID = Reader.GetInt32(ApplicationIDOrdinal),
                DriverID = Reader.GetInt32(DriverIDOrdinal),
                LicenseClassID = Reader.GetInt32(LicenseClassIDOrdinal),
                IssueDate = Reader.GetDateTime(IssueDateOrdinal),
                ExpirationDate = Reader.GetDateTime(ExpirationDateOrdinal),
                Notes = Reader.GetString(NotesOrdinal),
                PaidFees = Reader.GetDecimal(PaidFeesOrdinal),
                IsActive = Reader.GetBoolean(IsActiveOrdinal),
                IssueReason = Reader.GetInt32(IssueReasonOrdinal),
                CreatedByUserID = Reader.GetInt32(CreatedByUserIDOrdinal)
            };

        }

        public static ClsLicenseAndDriverInfo MapToClsLicenseAndDriver(SqlDataReader Reader)
        {
            int PersonIDOrdinal = Reader.GetOrdinal("PersonID");
            int NationalNoOrdinal = Reader.GetOrdinal("NationalNo");
            int FullNameOrdinal = Reader.GetOrdinal("FullName");
            int DateOfBirthOrdinal = Reader.GetOrdinal("DateOfBirth");
            int GenderOrdinal = Reader.GetOrdinal("Gendor");
            int LicenseIDOrdinal = Reader.GetOrdinal("LicenseID");
            int ApplicationIDOrdinal = Reader.GetOrdinal("ApplicationID");
            int DriverIDOrdinal = Reader.GetOrdinal("DriverID");
            int ClassNameOrdinal = Reader.GetOrdinal("ClassName");
            int IsActiveOrdinal = Reader.GetOrdinal("IsActive");
            int IssueDateOrdinal = Reader.GetOrdinal("IssueDate");
            int ExpirationDateOrdinal = Reader.GetOrdinal("ExpirationDate");
            int IssueReasonOrdinal = Reader.GetOrdinal("IssueReasonDescription");
            int NotesOrdinal = Reader.GetOrdinal("Notes");
            int IsDetainedOrdinal = Reader.GetOrdinal("IsDetained");
            int ImagePathOrdinal = Reader.GetOrdinal("ImagePath");

            return new ClsLicenseAndDriverInfo
            {
                PersonID = Reader.GetInt32(PersonIDOrdinal),
                NationalNo = Reader.GetString(NationalNoOrdinal),
                FullName = Reader.GetString(FullNameOrdinal),
                DateOfBirth = Reader.GetDateTime(DateOfBirthOrdinal),
                Gender = Reader.GetString(GenderOrdinal)[0],
                LicenseID = Reader.GetInt32(LicenseIDOrdinal),
                ApplicationID = Reader.GetInt32(ApplicationIDOrdinal),
                DriverID = Reader.GetInt32(DriverIDOrdinal),
                ClassName = Reader.GetString(ClassNameOrdinal),
                IsActive = Reader.GetBoolean(IsActiveOrdinal),
                IssueDate = Reader.GetDateTime(IssueDateOrdinal),
                ExpirationDate = Reader.GetDateTime(ExpirationDateOrdinal),
                IssueReason = Reader.GetString(IssueReasonOrdinal),
                Notes = Reader.IsDBNull(NotesOrdinal) ? null : Reader.GetString(NotesOrdinal),
                IsDetained = Reader.GetString(IsDetainedOrdinal),
                ImagePath = Reader.IsDBNull(ImagePathOrdinal) ? null : Reader.GetString(ImagePathOrdinal)
            };
        }

        public static ClsInternationalLicense MapToClsInternationalLicense(SqlDataReader Reader)
        {
            int InternationalLicenseIDOrdinal = Reader.GetOrdinal("InternationalLicenseID");
            int ApplicantionIDOrdinal = Reader.GetOrdinal("ApplicationID");
            int DriverIDOrdinal = Reader.GetOrdinal("DriverID");
            int IssuedUsingLocalLicenseIDOrdinal = Reader.GetOrdinal("IssuedUsingLocalLicenseID");
            int IssueDateOrdinal = Reader.GetOrdinal("IssueDate");
            int ExpirationDateOrdinal = Reader.GetOrdinal("ExpirationDate");
            int IsActiveOrdinal = Reader.GetOrdinal("IsActive");
            int IsCreatedByUserIDOrdinal = Reader.GetOrdinal("CreatedByUserID");

            return new ClsInternationalLicense
            {
                InternationalLicenseID = Reader.GetInt32(InternationalLicenseIDOrdinal),
                ApplicantionID = Reader.GetInt32(ApplicantionIDOrdinal),
                DriverID = Reader.GetInt32(DriverIDOrdinal),
                IssuedUsingLocalLicenseID = Reader.GetInt32(IssuedUsingLocalLicenseIDOrdinal),
                IssueDate = Reader.GetDateTime(IssueDateOrdinal),
                ExpirationDate = Reader.GetDateTime(ExpirationDateOrdinal),
                IsActive = Reader.GetBoolean(IsActiveOrdinal),
                IsCreatedByUserID = Reader.GetInt32(IsCreatedByUserIDOrdinal)
            };
        }

        public static ClsInternationalLicenseInfo MapToClsInternationalLicenseInfo(SqlDataReader Reader)
        {
            int FullNameOrdinal = Reader.GetOrdinal("FullName");
            int PersonIDOrdinal = Reader.GetOrdinal("PersonID");
            int NationalNumberOrdinal = Reader.GetOrdinal("NationalNo");
            int GenderOrdinal = Reader.GetOrdinal("Gendor");
            int InternationalLicenseIDOrdinal = Reader.GetOrdinal("InternationalLicenseID");
            int LocalLicenseIDOrdinal = Reader.GetOrdinal("LocalLicenseID");
            int DriverIDOrdinal = Reader.GetOrdinal("DriverID");
            int ApplicationIDOrdinal = Reader.GetOrdinal("ApplicationID");
            int IssueDateOrdinal = Reader.GetOrdinal("IssueDate");
            int ExpirationDateOrdinal = Reader.GetOrdinal("ExpirationDate");
            int DateOfBirthOrdinal = Reader.GetOrdinal("DateOfBirth");
            int IsActiveOrdinal = Reader.GetOrdinal("IsActive");
            int ImagePathOrdinal = Reader.GetOrdinal("ImagePath");

            return new ClsInternationalLicenseInfo
            {
                FullName = Reader.GetString(FullNameOrdinal),
                PersonID = Reader.GetInt32(PersonIDOrdinal),
                NationalNumber = Reader.GetString(NationalNumberOrdinal),
                Gender = Reader.GetString(GenderOrdinal)[0],
                InternationalLicenseID = Reader.GetInt32(InternationalLicenseIDOrdinal),
                LocalLicenseID = Reader.GetInt32(LocalLicenseIDOrdinal),
                DriverID = Reader.GetInt32(DriverIDOrdinal),
                ApplicationID = Reader.GetInt32(ApplicationIDOrdinal),
                IssueDate = Reader.GetDateTime(IssueDateOrdinal),
                ExpirationDate = Reader.GetDateTime(ExpirationDateOrdinal),
                DateOfBirth = Reader.GetDateTime(DateOfBirthOrdinal),
                IsActive = Reader.GetBoolean(IsActiveOrdinal),
                ImagePath = Reader.IsDBNull(ImagePathOrdinal) ? null : Reader.GetString(ImagePathOrdinal)
            };
        }

        public static ClsDetainLicense MapToClsDetainLicense(SqlDataReader Reader)
        {
            int DetainIDOrdinal = Reader.GetOrdinal("DetainID");
            int LicenseIDOrdinal = Reader.GetOrdinal("LicenseID");
            int DetainDateOrdinal = Reader.GetOrdinal("DetainDate");
            int FineFeesOrdinal = Reader.GetOrdinal("FineFees");
            int CreatedByUserIDOrdinal = Reader.GetOrdinal("CreatedByUserID");
            int IsReleasedOrdinal = Reader.GetOrdinal("IsReleased");
            int ReleaseDateOrdinal = Reader.GetOrdinal("ReleaseDate");
            int ReleasedByUserIDOrdinal = Reader.GetOrdinal("ReleasedByUserID");
            int ReleaseApplicationIDOrdinal = Reader.GetOrdinal("ReleaseApplicationID");

            return new ClsDetainLicense
            {
                DetainID = Reader.GetInt32(DetainIDOrdinal),
                LicenseID = Reader.GetInt32(LicenseIDOrdinal),
                DetainDate = Reader.GetDateTime(DetainDateOrdinal),
                FineFees = Reader.GetDecimal(FineFeesOrdinal),
                CreatedByUserID = Reader.GetInt32(CreatedByUserIDOrdinal),
                IsReleased = Reader.GetBoolean(IsReleasedOrdinal),
                ReleaseDate = Reader.IsDBNull(ReleaseDateOrdinal) ? (DateTime?)null : Reader.GetDateTime(ReleaseDateOrdinal),
                ReleasedByUserID = Reader.IsDBNull(ReleasedByUserIDOrdinal) ? (int?)null : Reader.GetInt32(ReleasedByUserIDOrdinal),
                ReleaseApplicationID = Reader.IsDBNull(ReleaseApplicationIDOrdinal) ? (int?)null : Reader.GetInt32(ReleaseApplicationIDOrdinal)
            };
        }

        public static ClsDetainLicenseView MapToClsDetainLicenseView(SqlDataReader Reader)
        {
            int DetainIDOrdinal = Reader.GetOrdinal("DetainID");
            int LicenseIDOrdinal = Reader.GetOrdinal("LicenseID");
            int DetainDateOrdinal = Reader.GetOrdinal("DetainDate");
            int IsReleasedOrdinal = Reader.GetOrdinal("IsReleased");
            int FineFeesOrdinal = Reader.GetOrdinal("FineFees");
            int ReleaseDateOrdinal = Reader.GetOrdinal("ReleaseDate");
            int NationalNoOrdinal = Reader.GetOrdinal("NationalNo");
            int FullNameOrdinal = Reader.GetOrdinal("FullName");
            int ReleaseApplicationIDOrdinal = Reader.GetOrdinal("ReleaseApplicationID");

            return new ClsDetainLicenseView
            {
                DetainID = Reader.GetInt32(DetainIDOrdinal),
                LicenseID = Reader.GetInt32(LicenseIDOrdinal),
                DetainDate = Reader.GetDateTime(DetainDateOrdinal),
                IsReleased = Reader.GetBoolean(IsReleasedOrdinal),
                FineFees = Reader.GetDecimal(FineFeesOrdinal),
                ReleaseDate = Reader.IsDBNull(ReleaseDateOrdinal) ? (DateTime?)null : Reader.GetDateTime(ReleaseDateOrdinal),
                NationalNo = Reader.GetString(NationalNoOrdinal),
                FullName = Reader.GetString(FullNameOrdinal),
                ReleaseApplicationID = Reader.IsDBNull(ReleaseApplicationIDOrdinal) ? (int?)null : Reader.GetInt32(ReleaseApplicationIDOrdinal)
            };
        }
    }
}
