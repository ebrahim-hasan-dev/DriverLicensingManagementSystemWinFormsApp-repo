using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DLMApp_ModulesLayer;
using DLMApp_DataAccessLayer;


namespace DLMApp_BusinessLayer
{
    public class PersonService
    {
        public static async Task<bool> AddNewPerson(clsPerson Person)
        {
            if (Person.IsFull())
            {
                return await PersonRepository.AddNewPerson(Person);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> NationalNumberExist(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return await PersonRepository.NationalNubmerExist(NationalNumber);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> PhoneExist(string PhoneNumber)
        {
            if (!string.IsNullOrWhiteSpace(PhoneNumber))
            {
                return await PersonRepository.PhoneNumberExist(PhoneNumber);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> EmailExist(string Email)
        {
            if (!string.IsNullOrWhiteSpace(Email))
            {
                return await PersonRepository.EmailExist(Email);
            }
            else
            {
                return false;
            }
        }

        public static async Task<clsPerson> FindByApplicationID(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await PersonRepository.FindByApplicationID(ApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static async Task<clsPerson> FindByNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return await PersonRepository.FindByNationalNumber(NationalNumber);
            }
            else
            {
                return null;
            }
        }

        public static async Task<clsPerson> FindByPersonID(int PersonID)
        {
            if (PersonID > 0)
            {
                return await PersonRepository.FindByPersonID(PersonID);
            }
            else
            {
                return null;
            }
        }

        public static async Task<clsPerson> FindByDriverID(int DriverID)
        {
            if (DriverID > 0)
            {
                return await PersonRepository.FindByDriverID(DriverID);
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> DeleteByID(int PersonID)
        {
            if (PersonID > 0)
            {
                return await PersonRepository.DeleteByID(PersonID);
            }
            else
            {
                return false;
            }
        }

        public static byte CalcAge(DateTime DateOfBirth)
        {
            return (byte)(DateTime.Now.Year - DateOfBirth.Year);
        }

        public static async Task<List<clsPerson>> GetAllPeople()
        {
            return await PersonRepository.GetAllPeople();
        }

        public static async Task<bool> UpdatePerson(int PersonID, string OldPhone1, string OldPhone2, clsPerson Person)
        {
            if (PersonID > 0 && Person.IsFull())
            {
                return await PersonRepository.UpdatePerson(PersonID, OldPhone1, OldPhone2, Person);
            }
            else
            {
                return false;
            }
        }




    }
}
