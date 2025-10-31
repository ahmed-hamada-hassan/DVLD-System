using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL.International_License_BL
{
    public class ClsInternationalLicenseInfo
    {
        public string FullName { get; set; }
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public char Gender { get; set; }
        public int InternationalLicenseID { get; set; }
        public int LocalLicenseID { get; set; }
        public int DriverID { get; set; }
        public int ApplicationID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
    }
}
