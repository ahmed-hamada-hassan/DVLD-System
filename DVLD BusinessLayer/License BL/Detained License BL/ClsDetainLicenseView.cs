using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.License_BL.Detained_License_BL
{
    public class ClsDetainLicenseView
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public bool IsReleased { get; set; }
        public Decimal FineFees { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public int? ReleaseApplicationID { get; set; }
    }
}
