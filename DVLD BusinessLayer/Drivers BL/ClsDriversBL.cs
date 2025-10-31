using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Drivers_BL
{
    public class ClsDriversBL
    {
        private readonly ClsDriversDataAccess _DriversDAL = new ClsDriversDataAccess();

        public async Task<ClsDriver> GetDriverInfoByPersonIDAsync(int PersonID)
        {
            using (var Reader = await _DriversDAL.GetDriverInfoByPersonIDAsync(PersonID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsDriversMapper.MapToClsDriver(Reader);
                }
            }
            return null;
        }
        public async Task<bool> AddNewDriverAsync(ClsDriver DriverInfo)
        {
            DriverInfo.DriverID = await _DriversDAL.AddNewDriverAsync(DriverInfo.PersonID, DriverInfo.CreatedByUserID, DriverInfo.CreationDate);
            return DriverInfo.DriverID != -1;
        }
        public async Task<List<ClsDriverView>> GetDriversAsync()
        {
            var DriversList = new List<ClsDriverView>();
            using (var Reader = await _DriversDAL.GetDriversAsync())
            {
                while (await Reader.ReadAsync())
                {
                    DriversList.Add(ClsDriversMapper.MapToClsDriverView(Reader));
                }
            }
            return DriversList;
        }
        public async Task<List<ClsDriverView>> FilterDriversAccordingByAsync(string FilterBy, string FilterValue)
        {
            var DriversList = new List<ClsDriverView>();
            using (var Reader = await _DriversDAL.FilterDriversAccordingByAsync(FilterBy, FilterValue))
            {
                while (await Reader.ReadAsync())
                {
                    DriversList.Add(ClsDriversMapper.MapToClsDriverView(Reader));
                }
            }
            return DriversList;
        }
    }
}
