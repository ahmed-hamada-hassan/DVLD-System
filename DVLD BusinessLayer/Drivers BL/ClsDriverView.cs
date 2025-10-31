using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Drivers_BL
{
    public class ClsDriverView
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ActiveLicenses { get; set; }
    }
}
