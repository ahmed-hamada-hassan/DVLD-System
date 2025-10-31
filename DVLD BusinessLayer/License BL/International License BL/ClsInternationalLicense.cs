using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL.International_License_BL
{
    public class ClsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicantionID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int IsCreatedByUserID { get; set; }
    }
}
