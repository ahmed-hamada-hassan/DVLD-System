using DVLD_BusinessLayer.PoepleBL;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsPeopleBusinessLayer
    {
        private readonly ClsPeopleDataAccess _DataAccessLayer = new ClsPeopleDataAccess();
        public async Task<List<ClsPersonView>> GetPeopleAsync(string orderBy = "NationalNo")
        {
            var people = new List<ClsPersonView>();

            using (var reader = await _DataAccessLayer.GetPeopleAsync(orderBy))
            {
                while (await reader.ReadAsync())
                {
                    people.Add(ClsPeopleMapper.MapToClsPersonView(reader));
                }
            }
            
            return people;
        }
        public async Task<List<ClsPersonView>> GetPeopleAsync()
        {
            var people = new List<ClsPersonView>();

            using (var reader = await _DataAccessLayer.GetPeopleAsync())
            {
                while (await reader.ReadAsync())
                {
                    people.Add(ClsPeopleMapper.MapToClsPersonView(reader));
                }
            }
            
            return people;
        }
        public async Task<bool> AddNewPersonAsync(ClsPerson Person)
        {
            Person.PersonID = await _DataAccessLayer.AddNewPersonAsync(
                Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.NationalNo, Person.Address, Person.Phone,
                Person.Email, Person.ImagePath, Person.DateOfBirth, Person.Gendor, Person.NationalityCountryID
            );

            return (Person.PersonID != -1);
        }
        public async Task<bool> FindPersonByNationalNumberAsync(string NationalNumber)
        {
            return await _DataAccessLayer.FindPersonByNationalNumberAsync( NationalNumber );
        }
        public async Task<int> CountPeopleAsync()
        {
            return await _DataAccessLayer.CountPeopleAsync();
        }
        public async Task<ClsPerson> GetPersonByIDAsync(int PersonID)
        {
            ClsPerson Person = new ClsPerson();
            using (var reader = await _DataAccessLayer.GetPersonInfoByIDAsync(PersonID))
            {
                if(await reader.ReadAsync())
                {
                    return (ClsPeopleMapper.MapToClsPerson(reader));
                }
            }
            return null;
        }
        public async Task<ClsPerson> GetPersonByNationalNoAsync(string NationalNumber)
        {
            using (var reader = await _DataAccessLayer.GetPersonInfoByNationalNoAsync(NationalNumber))
            {
                if (await reader.ReadAsync())
                {
                    return (ClsPeopleMapper.MapToClsPerson(reader));
                }
            }
            return null;
        }
        public async Task<ClsPerson> GetPersonInfoByDriverIDAsync(int DriverID)
        {
            using (var reader = await _DataAccessLayer.GetPersonInfoByDriverIDAsync(DriverID))
            {
                if (await reader.ReadAsync())
                {
                    return (ClsPeopleMapper.MapToClsPerson(reader));
                }
            }
            return null;
        }
        public async Task<string> GetPersonFullNameByIDAsync(int PersonID)
        {
            return await _DataAccessLayer.GetPersonFullNameByIDAsync(PersonID);
        }
        public async Task<string> GetPersonFullNameByNationalNoAsync(string NationalNumber)
        {
            return await _DataAccessLayer.GetPersonFullNameByNationalNoAsync(NationalNumber);
        }
        public async Task<bool> IsNationalNumberNotRepeatedAsync(string NationalNumber,int ExcludedPersonID)
        {
            ClsPerson ExistingPerson = await GetPersonByNationalNoAsync(NationalNumber);
            if (ExistingPerson != null && ExistingPerson.PersonID != ExcludedPersonID)
                return true;
            else
                return false;
        }
        public async Task<bool> UpdatePersonInfoAsync(ClsPerson Person)
        {
            return await _DataAccessLayer.UpdatePersonInfoAsync(Person.PersonID, Person.FirstName, Person.SecondName
                                                     , Person.ThirdName, Person.LastName, Person.NationalNo, Person.Address
                                                     , Person.Phone, Person.Email, Person.ImagePath, Person.DateOfBirth
                                                     , Person.Gendor, Person.NationalityCountryID);
        }
        public async Task<bool> DeletePersonAsync(int PersonID)
        {
            return await _DataAccessLayer.DeletePersonAsync(PersonID);
        }
        public async Task<List<ClsPersonView>> FilterPeopleAccordingByAsync(string FilterBy, string FilterValue)
        {
            var people = new List<ClsPersonView>();
            using (var reader = await _DataAccessLayer.FilterPeopleAccordingByAsync(FilterBy, FilterValue))
            {
                while (await reader.ReadAsync())
                {
                    people.Add(ClsPeopleMapper.MapToClsPersonView(reader));
                }
            }
            
            return people;
        }
        public async Task<List<ClsPersonView>> FilterPeopleAccordingByGenderAsync(char Gender)
        {
            var people = new List<ClsPersonView>();
            using (var reader = await _DataAccessLayer.FilterPeopleAccordingByGenderAsync(Gender))
            {
                while (await reader.ReadAsync())
                {
                    people.Add(ClsPeopleMapper.MapToClsPersonView(reader));
                }
            }
            
            return people;
        }
    }
}