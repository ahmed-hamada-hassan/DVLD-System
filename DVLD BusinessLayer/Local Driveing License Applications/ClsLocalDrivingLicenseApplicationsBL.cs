using DVLD_BusinessLayer.Applications_BL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Local_Driveing_License_Applications
{
    public class ClsLocalDrivingLicenseApplicationsBL
    {
        private readonly ClsLocalDrivingLicenseApplicationsDataAccess _LDLAppDAL = new ClsLocalDrivingLicenseApplicationsDataAccess();
        public async Task<bool> AddNewLocalDrivingLicenseApplicationAsync(int ApplicationID , int LicenseClassID)
        {
            int LDLAppID = await _LDLAppDAL.AddNewLocalDrivingLicenseApplicationAsync(ApplicationID, LicenseClassID);
            return LDLAppID != -1;
        }
        public async Task<int> FindLicenseClassIDByApplicationIDAsync(int ApplicationID)
        {
            return await _LDLAppDAL.FindLicenseClassIDByApplicationIDAsync(ApplicationID);
        }
        public async Task<List<ClsLocalDrivingLicense>> GetAllLocalDrivingLicenseApplicationsAsync()
        {
            var LDLAppList = new List<ClsLocalDrivingLicense>();
            using (var reader = await _LDLAppDAL.GetAllLocalDrivingLicenseApplicationsAsync())
            {
                while (await reader.ReadAsync())
                {
                    LDLAppList.Add(ClsLocalDrivingLicenseApplicationMapper.MapToClsLocalDrivingLicense(reader));
                }
            }
            return LDLAppList;
        }
        public async Task<List<ClsLocalDrivingLicense>> FilterLocalDrivingLicenseAccordingByAsync(string Filter, string SearchedText)
        {
            var LDLAppList = new List<ClsLocalDrivingLicense>();
            using (var reader = await _LDLAppDAL.FilterLocalDrivingLicenseAccordingByAsync(Filter,SearchedText))
            {
                while (await reader.ReadAsync())
                {
                    LDLAppList.Add(ClsLocalDrivingLicenseApplicationMapper.MapToClsLocalDrivingLicense(reader));
                }
            }
            return LDLAppList;
        }
        public async Task<List<ClsLocalDrivingLicense>> FilterLocalDrivingLicenseAccordingByStatusAsync(string Status)
        {
            var LDLAppList = new List<ClsLocalDrivingLicense>();
            using (var reader = await _LDLAppDAL.FilterLocalDrivingLicenseAccordingByStatusAsync(Status))
            {
                while (await reader.ReadAsync())
                {
                    LDLAppList.Add(ClsLocalDrivingLicenseApplicationMapper.MapToClsLocalDrivingLicense(reader));
                }
            }
            return LDLAppList;
        }
        public async Task<ClsLocalDrivingLicense> GetDrivingLicenseApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            using (var Reader = await _LDLAppDAL.GetDrivingLicenseApplicationAsync(LocalDrivingLicenseApplicationID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsLocalDrivingLicenseApplicationMapper.MapToClsLocalDrivingLicense(Reader);
                }    
            }
            return null;
        }
    }
}
