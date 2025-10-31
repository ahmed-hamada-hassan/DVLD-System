using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.PoepleBL
{
    public static class ClsPeopleMapper
    {
        public static ClsPerson MapToClsPerson(SqlDataReader reader)
        {
            int PersonIDOrdinal = reader.GetOrdinal("PersonID");
            int NationalNoOrdinal = reader.GetOrdinal("NationalNo");
            int FirstNameOrdinal = reader.GetOrdinal("FirstName");
            int SecondNameOrdinal = reader.GetOrdinal("SecondName");
            int ThirdNameOrdinal = reader.GetOrdinal("ThirdName");
            int LastNameOrdinal = reader.GetOrdinal("LastName");
            int DateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
            int GendorOrdinal = reader.GetOrdinal("Gendor");
            int AddressOrdinal = reader.GetOrdinal("Address");
            int PhoneOrdinal = reader.GetOrdinal("Phone");
            int EmailOrdinal = reader.GetOrdinal("Email");
            int NationalityCountryIDOrdinal = reader.GetOrdinal("NationalityCountryID");
            int ImagePathOrdinal = reader.GetOrdinal("ImagePath");

            return new ClsPerson
            {
                PersonID = Convert.ToInt32(reader[PersonIDOrdinal]),
                NationalNo = reader[NationalNoOrdinal]?.ToString(),
                FirstName = reader[FirstNameOrdinal]?.ToString(),
                SecondName = reader[SecondNameOrdinal]?.ToString(),
                ThirdName = reader[ThirdNameOrdinal]?.ToString(),
                LastName = reader[LastNameOrdinal]?.ToString(),
                DateOfBirth = Convert.ToDateTime(reader[DateOfBirthOrdinal]),
                Gendor = Convert.ToChar(reader[GendorOrdinal]),
                Address = reader[AddressOrdinal]?.ToString(),
                Phone = reader[PhoneOrdinal]?.ToString(),
                Email = reader.IsDBNull(EmailOrdinal) ? null : reader[EmailOrdinal].ToString(),
                NationalityCountryID = Convert.ToInt32(reader[NationalityCountryIDOrdinal]),
                ImagePath = reader.IsDBNull(ImagePathOrdinal) ? null : reader[ImagePathOrdinal].ToString()
            };
        }
        public static ClsPersonView MapToClsPersonView(SqlDataReader reader)
        {
            int PersonIDOrdinal = reader.GetOrdinal("PersonID");
            int NationalNoOrdinal = reader.GetOrdinal("NationalNo");
            int FirstNameOrdinal = reader.GetOrdinal("FirstName");
            int SecondNameOrdinal = reader.GetOrdinal("SecondName");
            int ThirdNameOrdinal = reader.GetOrdinal("ThirdName");
            int LastNameOrdinal = reader.GetOrdinal("LastName");
            int DateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
            int GenderOrdinal = reader.GetOrdinal("Gendor");
            int PhoneOrdinal = reader.GetOrdinal("Phone");
            int EmailOrdinal = reader.GetOrdinal("Email");
            int CountryNameOrdinal = reader.GetOrdinal("CountryName");
            return new ClsPersonView
            {
                PersonID = Convert.ToInt32(reader[PersonIDOrdinal]),
                NationalNo = reader[NationalNoOrdinal]?.ToString(),
                FirstName = reader[FirstNameOrdinal]?.ToString(),
                SecondName = reader[SecondNameOrdinal]?.ToString(),
                ThirdName = reader[ThirdNameOrdinal]?.ToString(),
                LastName = reader[LastNameOrdinal]?.ToString(),
                DateOfBirth = Convert.ToDateTime(reader[DateOfBirthOrdinal]),
                Gender = Convert.ToChar(reader[GenderOrdinal]),
                Phone = reader[PhoneOrdinal]?.ToString(),
                Email = reader.IsDBNull(EmailOrdinal) ? null : reader[EmailOrdinal].ToString(),
                CountryName = reader[CountryNameOrdinal]?.ToString()
            };

        }
    }
}
