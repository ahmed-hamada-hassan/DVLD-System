using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_Classes_BL
{
    public class ClsLicenseClassesBusinessLayer
    {
        private readonly ClsLicenseClassesDataAccess _LicenseClassesDAL = new ClsLicenseClassesDataAccess();
        public async Task<List<ClsLicenseClasses>> GetLicenseClassesAsync()
        {
            var LicenseClasses = new List<ClsLicenseClasses>();
            using (var reader = await _LicenseClassesDAL.GetLicenseClassesAsync())
            {
                while (await reader.ReadAsync())
                {
                    LicenseClasses.Add(ClsLicenseClassesMapper.MapToClsLicenseClasses(reader));
                }
            }
            return LicenseClasses;
        }
        public async Task<ClsLicenseClasses> GetLicenseClassesWithIDAsync(int LicenseClassID)
        {
            using (var reader = await _LicenseClassesDAL.GetLicenseClassesWithIDAsync(LicenseClassID))
            {
                if (await reader.ReadAsync())
                {
                    return ClsLicenseClassesMapper.MapToClsLicenseClasses(reader);
                }
            }
            return null;
        }
        public async Task<ClsLicenseClasses> GetLicenseClassesWithNameAsync(string ClassName)
        {
            using (var reader = await _LicenseClassesDAL.GetLicenseClassesWithNameAsync(ClassName))
            {
                if (await reader.ReadAsync())
                {
                    return ClsLicenseClassesMapper.MapToClsLicenseClasses(reader);
                }
            }
            return null;
        }
    }
}
