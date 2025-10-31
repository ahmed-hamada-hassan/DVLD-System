using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.TestTypes
{
    public class ClsTestTypesBusinessLayer
    {
        private readonly ClsTestTypesDataAccess _TestTypeDAL = new ClsTestTypesDataAccess();
        public async Task<List<ClsTestType>> GetAllTestTypeAsync()
        {
            var AllTestTypes = new List<ClsTestType>();
            using (var Reader = await _TestTypeDAL.GetAllTestTypesAsync())
            {
                while (await Reader.ReadAsync())
                {
                    AllTestTypes.Add(ClsTestTypeMapper.MapToClsTestType(Reader));
                }
            }
            return AllTestTypes;
        }
        public async Task<ClsTestType> GetTestTypeByIDAsync(int TestTypeID)
        {
            using (var Reader = await _TestTypeDAL.GetTestTypeByIDAsync(TestTypeID))
            {
                if(await Reader.ReadAsync())
                {
                    return ClsTestTypeMapper.MapToClsTestType(Reader);
                }
            }
            return null;
        }
        public async Task<int> CountTestTypesAsync()
        {
            return await _TestTypeDAL.CountAllTestTypesAsync();
        }
        public async Task<bool> UpdateTestTypeAsync(ClsTestType TestTypeInfo)
        {
            return await _TestTypeDAL.UpdateTestTypeAsync(TestTypeInfo.TestTypeID,TestTypeInfo.TestTypeTitle,TestTypeInfo.TestTypeDescription,
                                                    TestTypeInfo.TestTypeFees);
        }
    }
}
