using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Applications_BL
{
    public class ClsApplicationsBL
    {
        private readonly ClsApplicationsDataAccess _ApplicationDAL = new ClsApplicationsDataAccess();

        public async Task<bool> AddNewApplicationAsync(ClsApplication NewApplication)
        {
            NewApplication.ApplicationID = await _ApplicationDAL.AddNewApplicationAsync( NewApplication.ApplicationPersonID,
                                                        NewApplication.ApplicationDate,
                                           NewApplication.ApplicationTypeID,
                                           NewApplication.ApplicationStatus,
                                           NewApplication.LastStatusDate,
                                           NewApplication.PaidFees,
                                           NewApplication.CreatedByUserID);
            return NewApplication.ApplicationID != -1;
        }

        public async Task<bool> IsThisPersonHasApplicationWithTheSameLicenseClass(int PersonID, int CurrentLicenseClass)
        {
            return await _ApplicationDAL.IsThisPersonHasApplicationWithTheSameLicenseClass(PersonID, CurrentLicenseClass);
        }

        public async Task<int> FindApplicationIDWithPersonID(int PersonID, int CurrentLicenseClassID)
        {
            return await _ApplicationDAL.FindApplicationIDWithPersonID(PersonID, CurrentLicenseClassID);
        }

        public async Task<ClsApplication> FindApplicationInfoWithLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            
            using (var Reader = await _ApplicationDAL.FindApplicationInfoWithLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsApplicationMapper.MapToClsApplication(Reader);
                }
            }
            return null;
        }

        public async Task<int> FindLicenseClassIDByApplicationIDAsync(int ApplicationID)
        {
            return await _ApplicationDAL.FindLicenseClassIDByApplicationIDAsync(ApplicationID);
        }

        public async Task<bool> CancelApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            return await _ApplicationDAL.CancelApplicationAsync(LocalDrivingLicenseApplicationID);
        }

        public async Task<bool> CompleteApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            return await _ApplicationDAL.CompleteApplicationAsync(LocalDrivingLicenseApplicationID);
        }

        public async Task<bool> DeleteApplicationAsync(int LocalDrivingLicenseApplicationID)
        {
            return await _ApplicationDAL.DeleteApplicationAsync(LocalDrivingLicenseApplicationID);
        }

        public async Task<bool> DeleteApplicationPermanentlyAsync(int LocalDrivingLicenseApplicationID)
        {
            return await _ApplicationDAL.DeleteApplicationPermanentlyAsync(LocalDrivingLicenseApplicationID);
        }

        public async Task<bool> UpdateApplicationStatusAsync(ClsApplication ApplicationInfo)
        {
            return await _ApplicationDAL.UpdateApplicationStatusAsync(ApplicationInfo.ApplicationPersonID,
                                                                      ApplicationInfo.CreatedByUserID, ApplicationInfo.ApplicationID);
        }
    }
}
