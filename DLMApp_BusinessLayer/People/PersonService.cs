using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLMApp_ModulesLayer;
using DLMApp_DataAccessLayer;

namespace DLMApp_BusinessLayer
{
    public class PersonService
    {
        public static bool AddNewPerson(clsPerson Person)
        {
            if (Person.IsFull())
            {
                return PersonRepository.AddNewPerson(Person);
            }
            else
            {
                return false;
            }
        }

        public static bool NationalNumberExist(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return PersonRepository.NationalNubmerExist(NationalNumber);
            }
            else
            {
                return false;
            }
        }

        public static bool PhoneExist(string PhoneNumber)
        {
            if (!string.IsNullOrWhiteSpace(PhoneNumber))
            {
                return PersonRepository.PhoneNumberExist(PhoneNumber);
            }
            else
            {
                return false;
            }
        }

        public static bool EmailExist(string Email)
        {
            if (!string.IsNullOrWhiteSpace(Email))
            {
                return PersonRepository.EmailExist(Email);
            }
            else
            {
                return false;
            }
        }

        public static clsPerson FindByApplicationID(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return PersonRepository.FindByApplicationID(ApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson FindByLicenseID(int LicenseID)
        {
            if (LicenseID > 0)
            {
                return PersonRepository.FindByLicenseID(LicenseID);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson FindByNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return PersonRepository.FindByNationalNumber(NationalNumber);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson FindByPersonID(int PersonID)
        {
            if (PersonID > 0)
            {
                return PersonRepository.FindByPersonID(PersonID);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson FindByDriverID(int DriverID)
        {
            if (DriverID > 0)
            {
                return PersonRepository.FindByDriverID(DriverID);
            }
            else
            {
                return null;
            }
        }
        public static bool DeleteByID(int PersonID)
        {
            if (PersonID > 0)
            {
                return PersonRepository.DeleteByID(PersonID);
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

        public static List<clsPerson> GetAllPeople()
        {
            return PersonRepository.GetAllPeople();
        }

        public static bool UpdatePerson(int PersonID, string OldPhone1, string OldPhone2, clsPerson Person)
        {
            if (PersonID > 0 && Person.IsFull())
            {
                return PersonRepository.UpdatePerson(PersonID, OldPhone1, OldPhone2, Person);
            }
            else
            {
                return false;
            }
        }




    }
}
