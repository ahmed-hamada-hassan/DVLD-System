using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Tests
{
    public class ClsTestsBL
    {
        private readonly ClsTestsDataAccess _TestsDAL = new ClsTestsDataAccess();

        public async Task<int> CountTakeTestTrialsAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return await _TestsDAL.CountTakeTestTrialsAsync(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public async Task<bool> AddNewTestAsync(ClsTest TestInfo)
        {
            TestInfo.TestID = 
                await _TestsDAL.AddNewTestAsync(TestInfo.TestAppointmentID, TestInfo.TestResult, TestInfo.Notes, TestInfo.CreatedByUserID);
            return TestInfo.TestID != -1;
        }
        public async Task<bool> HasPassedTestAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return await _TestsDAL.HasPassedTestAsync(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public async Task<ClsTest> GetTestByAsync(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            using (var Reader = await _TestsDAL.GetTestByAsync(LocalDrivingLicenseApplicationID,TestTypeID))
            {
                if (await Reader.ReadAsync())
                {
                    return ClsTestMapper.MapToClsTest(Reader);
                }
            }
            return null;
        }
        public async Task<int> CountPassedTestsAsync(int LocalDrivingLicenseApplicationID)
        {
            return await _TestsDAL.CountPassedTestsAsync(LocalDrivingLicenseApplicationID);
        }
        public async Task<bool> TakeThisTestBefore(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return await _TestsDAL.TakeThisTestBefore(LocalDrivingLicenseApplicationID, TestTypeID);
        }
    }
}
