using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Local_Driveing_License_Applications
{
    public class ClsLocalDrivingLicense
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public string DrivingClassTitle { get; set; }
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }
        public string Status { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public string UserName { get; set; }
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public int PassedTestCount { get; set; }
        public string NationalNo { get; set; }
    }
}
