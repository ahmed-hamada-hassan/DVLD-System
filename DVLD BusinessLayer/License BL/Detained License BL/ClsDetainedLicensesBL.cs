using DVLD_BusinessLayer.License_BL.Local_License_BL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL.Detained_License_BL
{
    public class ClsDetainedLicensesBL
    {
        private readonly ClsDetainedLicensesDataAccess _DetainedLicenseDAL = new ClsDetainedLicensesDataAccess();
        public async Task<bool> AddNewDetainedLicenseAsync(ClsDetainLicense DetainedLicense)
        {
            DetainedLicense.DetainID = await _DetainedLicenseDAL.AddNewDetainedLicenseAsync
                                             (DetainedLicense.LicenseID, DetainedLicense.DetainDate, DetainedLicense.FineFees,
                                             DetainedLicense.CreatedByUserID);
            return DetainedLicense.DetainID != -1;
        }
        public async Task<bool> CheckIfLicenseIsDetainedAsync(int LicenseID)
        {
            return await _DetainedLicenseDAL.CheckIfLicenseIsDetainedAsync(LicenseID);
        }
        public async Task<ClsDetainLicense> GetDetainLicenseInfoByLicenseIDAsync(int LicenseID)
        {
            using (var Reader = await _DetainedLicenseDAL.GetDetainLicenseInfoByLicenseIDAsync(LicenseID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsDetainLicense(Reader);
                }
            }
            return null;
        }
        public async Task<bool> ReleaseDetainedLicenseAsync(ClsDetainLicense DetainedLicense)
        {
            return await _DetainedLicenseDAL.ReleaseDetainedLicenseAsync(DetainedLicense.DetainID,
                                                                          DetainedLicense.ReleaseDate.Value,
                                                                          DetainedLicense.ReleasedByUserID.Value,
                                                                          DetainedLicense.ReleaseApplicationID.Value);
        }
        public async Task<List<ClsDetainLicenseView>> GetAllDetainedLicensesAsync()
        {
            var DetainedLicenses = new List<ClsDetainLicenseView>();
            using (var Reader = await _DetainedLicenseDAL.GetAllDetainedLicensesAsync())
            {
                while (await Reader.ReadAsync())
                {
                    DetainedLicenses.Add(ClsLicenseMapper.MapToClsDetainLicenseView(Reader));
                }
            }
            return DetainedLicenses;
        }
        public async Task<List<ClsDetainLicenseView>> FilterDetainedLicensesAccordingByAsync(string Filter, string SearchedText)
        {
            var DetainedLicenses = new List<ClsDetainLicenseView>();
            using (var Reader = await _DetainedLicenseDAL.FilterDetainedLicensesAccordingByAsync(Filter, SearchedText))
            {
                while (await Reader.ReadAsync())
                {
                    DetainedLicenses.Add(ClsLicenseMapper.MapToClsDetainLicenseView(Reader));
                }
            }
            return DetainedLicenses;
        }
        public async Task<List<ClsDetainLicenseView>> FilterDetainedLicensesAccordingByReleaseStatusAsync(bool IsReleased)
        {
            var DetainedLicenses = new List<ClsDetainLicenseView>();
            using (var Reader = await _DetainedLicenseDAL.FilterDetainedLicensesAccordingByReleaseStatusAsync(IsReleased))
            {
                while (await Reader.ReadAsync())
                {
                    DetainedLicenses.Add(ClsLicenseMapper.MapToClsDetainLicenseView(Reader));
                }
            }
            return DetainedLicenses;
        }
    }
}
