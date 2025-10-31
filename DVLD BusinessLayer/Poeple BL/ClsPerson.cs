using DVLD_BusinessLayer.CountriesBL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.PoepleBL
{
    public class ClsPerson
    {
        
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        private char _Gendor;
        public char Gendor
        {
            get => _Gendor;
            set
            {
                if (value == 'M' || value == 'F') _Gendor = value;
                else _Gendor = 'O';
            }
        }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public ClsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.MinValue;
            this.Gendor = 'M';
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
        }

        
    }
}
