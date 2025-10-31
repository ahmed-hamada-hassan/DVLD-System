using DVLD_BusinessLayer.Application_Types_BL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.ApplicationsBL
{
    public class ClsApplicationTypesBusinessLayer
    {
        private readonly ClsApplicationTypesDataAccess _ApplicationTypesDAL = new ClsApplicationTypesDataAccess();
        public async Task<List<ClsApplicationType>> GetApplicationTypesAsync()
        {
            List<ClsApplicationType> Applications = new List<ClsApplicationType>();
            using (var Reader = await _ApplicationTypesDAL.GetApplicationTypesAsync())
            {
                while (await Reader.ReadAsync())
                {
                    Applications.Add(ClsApplicationTypeMapper.MapToClsApplicationType(Reader));
                }
            }
            return Applications;
        }
        public async Task<int> CountApplicationTypesAsync()
        {
            return await _ApplicationTypesDAL.CountApplicationTypesAsync();
        }
        public async Task<ClsApplicationType> GetApplicationTypeByIDAsync(int ApplicationTypeID)
        {
            using (var Reader = await _ApplicationTypesDAL.GetApplicationTypeByIDAsync(ApplicationTypeID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsApplicationTypeMapper.MapToClsApplicationType(Reader);
                }
            }
            return null;
        }
        public async Task<bool> UpdateApplicationTypeInfoAsync(ClsApplicationType App)
        {
            return await _ApplicationTypesDAL.UpdateApplicationTypeInfoAsync(App.ApplicationName, App.ApplicationFees,App.ApplicationID);
        }
        public async Task<decimal> GetApplicationFeesByIDAsync(int ApplicationTypeID)
        {
            return await _ApplicationTypesDAL.GetApplicationFeesByIDAsync(ApplicationTypeID);
        }
    }
}
