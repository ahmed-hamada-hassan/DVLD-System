using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.CountriesBL
{
    public class ClsCountriesBusinessLayer
    {
        private readonly ClsCountryDataAccess _Countries = new ClsCountryDataAccess();
        public async Task<List<ClsCountry>> GetAllCountriesAsync()
        {
            var countries = new List<ClsCountry>();

            using (var reader = await _Countries.GetAllCountriesAsync())
            {
                while (await reader.ReadAsync())
                {
                    countries.Add(new ClsCountry
                    {
                        CountryID = Convert.ToInt32(reader["CountryID"]),
                        CountryName = Convert.ToString(reader["CountryName"])
                    });
                }
            }
            return countries;
        }
        public async Task<string> GetCountryNameByIDAsync(int CountryID)
        {
            return await _Countries.GetCountryNameByIDAsync(CountryID);
        }
    }
}
