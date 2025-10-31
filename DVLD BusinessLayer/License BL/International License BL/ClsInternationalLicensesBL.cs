using DVLD_BusinessLayer.License_BL.Local_License_BL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL.International_License_BL
{
    public class ClsInternationalLicensesBL
    {
        private readonly ClsInternationalLicensesDataAccess _InternationalLicenseDAL = new ClsInternationalLicensesDataAccess();

        public async Task<bool> AddNewInternationalLicenseAsync(ClsInternationalLicense InternationalLicens)
        {
            InternationalLicens.InternationalLicenseID = await _InternationalLicenseDAL.AddNewInternationalLicenseAsync(
                                                        InternationalLicens.ApplicantionID,
                                                        InternationalLicens.DriverID,
                                                        InternationalLicens.IssuedUsingLocalLicenseID,
                                                        InternationalLicens.IssueDate,
                                                        InternationalLicens.ExpirationDate,
                                                        InternationalLicens.IsCreatedByUserID);
            return InternationalLicens.InternationalLicenseID != -1;    
        }
        public async Task<List<ClsInternationalLicense>> GetAllInternationalLicensesAsync()
        {
            var InternationalLicenses = new List<ClsInternationalLicense>();
            using (var Reader = await _InternationalLicenseDAL.GetAllInternationalLicensesAsync())
            {
                while (await Reader.ReadAsync())
                {
                    InternationalLicenses.Add(ClsLicenseMapper.MapToClsInternationalLicense(Reader));
                }
            }
            return InternationalLicenses;
        }
        public async Task<ClsInternationalLicense> GetInternationalLicenseByIDAsync(int InternationalLicenseID)
        {
            using (var Reader = await _InternationalLicenseDAL.GetInternationalLicenseByIDAsync(InternationalLicenseID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsInternationalLicense(Reader);
                }
            }
            return null;
        }
        public async Task<List<ClsInternationalLicense>> GetAllInternationalLicenseByDriverIDAsync(int DriverID)
        {
            var internationalLicenses = new List<ClsInternationalLicense>();
            using (var Reader = await _InternationalLicenseDAL.GetAllInternationalLicenseByDriverIDAsync(DriverID))
            {
                while (await Reader.ReadAsync())
                {
                    internationalLicenses.Add(ClsLicenseMapper.MapToClsInternationalLicense(Reader));
                }
            }
            return internationalLicenses;
        }
        public async Task<ClsInternationalLicense> GetInternationalLicenseByIssuedLocalLicenseIDAsync(int LocalLicenseID)
        {
            using (var Reader = await _InternationalLicenseDAL.GetInternationalLicenseByIssuedLocalLicenseIDAsync(LocalLicenseID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsInternationalLicense(Reader);
                }
            }
            return null;
        }
        public async Task<List<ClsInternationalLicense>> GetAllInternationalLicenseByIssuedLocalLicenseIDAsync(int LocalLicenseID)
        {
            var InternationalLicenses = new List<ClsInternationalLicense>();
            using (var Reader = await _InternationalLicenseDAL.GetAllInternationalLicenseByIssuedLocalLicenseIDAsync(LocalLicenseID))
            {
                while (await Reader.ReadAsync())
                {
                    InternationalLicenses.Add(ClsLicenseMapper.MapToClsInternationalLicense(Reader));
                }
            }
            return null;
        }
        public async Task<List<ClsInternationalLicense>> FilterInternationalLicensesAccordingByAsync(string Filter, string SearchedText)
        {
            var internationalLicenses = new List<ClsInternationalLicense>();
            using (var Reader = await _InternationalLicenseDAL.FilterInternationalLicensesAccordingByAsync(Filter, SearchedText))
            {
                while (await Reader.ReadAsync())
                {
                    internationalLicenses.Add(ClsLicenseMapper.MapToClsInternationalLicense(Reader));
                }
            }
            return internationalLicenses;
        }
        public async Task<List<ClsInternationalLicense>> FilterInternationalLicensesByActiveStatusAsync(bool IsActive)
        {
            var internationalLicenses = new List<ClsInternationalLicense>();
            using (var Reader = await _InternationalLicenseDAL.FilterInternationalLicensesByActiveStatusAsync(IsActive))
            {
                while (await Reader.ReadAsync())
                {
                    internationalLicenses.Add(ClsLicenseMapper.MapToClsInternationalLicense(Reader));
                }
            }
            return internationalLicenses;
        }
        public async Task<ClsInternationalLicenseInfo> GetInternationalLicenseInfoByInternationalLicenseIDAsync(int InternationalLicenseID)
        {
            using (var Reader = await _InternationalLicenseDAL.GetInternationalLicenseInfoByInternationalLicenseIDAsync(InternationalLicenseID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsLicenseMapper.MapToClsInternationalLicenseInfo(Reader);
                }
            }
            return null;
        }
    }
}
