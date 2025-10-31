using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL
{
    public class ClsLicenseAndDriverInfo
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public string ClassName { get; set; }
        public bool IsActive { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string IssueReason { get; set; }
        public string Notes { get; set; }
        public string IsDetained { get; set; }
        public string ImagePath { get; set; }
    }
}
