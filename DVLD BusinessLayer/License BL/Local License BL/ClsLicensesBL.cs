using DVLD_BusinessLayer.License_BL.Local_License_BL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL
{
    public class ClsLicensesBL
    {
        private readonly ClsLicenseDataAccess _LicenseDAL = new ClsLicenseDataAccess();
        public async Task<bool> AddNewLicenseAsync(ClsLicense LicensInfo)
        {
            LicensInfo.LicenseID = await _LicenseDAL.AddNewLicenseAsync(LicensInfo.ApplicationID, LicensInfo.DriverID, LicensInfo.LicenseClassID,
                                                                        LicensInfo.IssueDate, LicensInfo.ExpirationDate, LicensInfo.Notes, 
                                                                        LicensInfo.PaidFees, LicensInfo.IsActive, LicensInfo.IssueReason, 
                                                                        LicensInfo.CreatedByUserID);

            return LicensInfo.LicenseID != -1;
        }
        public async Task<ClsLicense> GetLicenseInfoByApplicationIDAsync(int ApplicationID)
        {
            using (var Reader = await _LicenseDAL.GetLicenseInfoByApplicationIDAsync(ApplicationID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsLicense(Reader);
                }
            }
            return null;
        }
        public async Task<List<ClsLicense>> GetAllLicenseInfoByDriverIDAsync(int DriverID)
        {
            List<ClsLicense> licenses = new List<ClsLicense>();
            
            using (var Reader = await _LicenseDAL.GetAllLicenseInfoByDriverIDAsync(DriverID))
            {
                while (await Reader.ReadAsync())
                {
                    licenses.Add(ClsLicenseMapper.MapToClsLicense(Reader));
                }
            }
            
            return licenses;
        }
        public async Task<ClsLicense> GetLicenseInfoByPersonIDAsync(int PersonID, int LicenseClassID)
        {
            using (var Reader = await _LicenseDAL.GetLicenseInfoByPersonIDAsync(PersonID, LicenseClassID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsLicense(Reader);
                }
            }
            return null;
        }
        public async Task<ClsLicenseAndDriverInfo> GetActiveLicenseByNationalNumberAsync(string NationalNumber)
        { 
            using (var Reader = await _LicenseDAL.GetActiveLicenseByNationalNumberAsync(NationalNumber))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsLicenseAndDriver(Reader);
                }
            }
            
            return null;
        }
        public async Task<ClsLicenseAndDriverInfo> GetLicenseInfoByLicenseIDAsync(int LicenseID)
        {
            using (var Reader = await _LicenseDAL.GetLicenseInfoByLicenseIDAsync(LicenseID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsLicenseAndDriver(Reader);
                }
            }
            return null;
        }
        public async Task<List<ClsLicenseAndDriverInfo>> GetAllLicensesByDriverIDAsync(int DriverID)
        {
            List<ClsLicenseAndDriverInfo> licenses = new List<ClsLicenseAndDriverInfo>();
            
            using (var Reader = await _LicenseDAL.GetAllAboutLicenseByDriverIDAsync(DriverID))
            {
                while (await Reader.ReadAsync())
                {
                    licenses.Add(ClsLicenseMapper.MapToClsLicenseAndDriver(Reader));
                }
            }
            
            return licenses;
        }
        public async Task<List<ClsLicenseAndDriverInfo>> GetAllAboutLicenseByLicenseIDAsync(int LicenseID)
        {
            List<ClsLicenseAndDriverInfo> licenses = new List<ClsLicenseAndDriverInfo>();
            
            using (var Reader = await _LicenseDAL.GetAllAboutLicenseByLicenseIDAsync(LicenseID))
            {
                while (await Reader.ReadAsync())
                {
                    licenses.Add(ClsLicenseMapper.MapToClsLicenseAndDriver(Reader));
                }
            }
            
            return licenses;
        }
        public async Task<List<ClsLicenseAndDriverInfo>> GetAllAboutLicenseByPersonIDAsync(int PersonID)
        {
            List<ClsLicenseAndDriverInfo> licenses = new List<ClsLicenseAndDriverInfo>();
            
            using (var Reader = await _LicenseDAL.GetAllAboutLicenseByPersonIDAsync(PersonID))
            {
                while (await Reader.ReadAsync())
                {
                    licenses.Add(ClsLicenseMapper.MapToClsLicenseAndDriver(Reader));
                }
            }
            
            return licenses;
        }
        public async Task<ClsLicenseAndDriverInfo> GetLicensesByDriverIDAsync(int DriverID)
        {
            using (var Reader = await _LicenseDAL.GetAllAboutLicenseByDriverIDAsync(DriverID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsLicenseAndDriver(Reader);
                }
            }
            return null;
           
        }
        public async Task<bool> IsActiveOrdinaryLicenseByIDAsync(int LicenseID)
        {
            return await _LicenseDAL.IsActiveOrdinaryLicenseByIDAsync(LicenseID);
        }
        public async Task<bool> IsActiveLicenseByIDAsync(int LicenseID)
        {
            return await _LicenseDAL.IsActiveLicenseByIDAsync(LicenseID);
        }
        public async Task<bool> DeActiveLicenseByIDAsync(int LicenseID)
        {
            return await _LicenseDAL.DeActiveLicenseByIDAsync(LicenseID);
        }
        public async Task<bool> FindIfHasActiveLicenseByPersonIDAsync(int PersonID, int LicenseClassID)
        {
            return await _LicenseDAL.FindIfHasActiveLicenseByPersonIDAsync(PersonID, LicenseClassID);
        }

    }
}
