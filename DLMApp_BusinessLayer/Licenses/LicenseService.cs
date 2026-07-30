using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class LicenseService
    {
        // =========================================================================================

        public static async Task<List<clsLicenseClass>> GetAllLicensesClasses()
        {
            return await LicenseRepository.GetAllLicensesClasses();
        }

        public static async Task<(clsLicenseClass, int)> GetLicenseClass(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await LicenseRepository.GetLicenseClass(ApplicationID);
            }
            else
            {
                return (null, 0);
            }
        }

        public static async Task<clsLicenseClass> GetLicenseClass(byte LicenseClassID)
        {
            if (LicenseClassID > 0)
            {
                return await LicenseRepository.GetLicenseClass(LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> UpdateLicenseClass(byte LicenseClassID, float LicenseFees, byte ValidityPeriod, byte MinimumAllowedAge)
        {
            if (LicenseClassID > 0 && LicenseFees > 0 && ValidityPeriod > 0 && MinimumAllowedAge > 0)
            {
                return await LicenseRepository.UpdateLicenseClass(LicenseClassID, LicenseFees, ValidityPeriod, MinimumAllowedAge);
            }
            else
            {
                return false;
            }
        }

        // =========================================================================================


        public static async Task<bool> DoesHaveLicenseOfSameClass(int PersonID, byte LicenseClassID)
        {
            if (PersonID > 0 && LicenseClassID > 0)
            {
                return await LicenseRepository.DoesHaveLicenseOfSameClass(PersonID, LicenseClassID);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> AddNewLicense(clsLicense license)
        {
            if (license.IsFull())
            {
                if (license.ID != 0)
                {
                    await LicenseService.UpdateActiveLicense(license.ID, false);
                }

                if (license.LicenseStatusID == enLicenseStatus.New || license.LicenseStatusID == enLicenseStatus.Renew)
                {
                    await ApplicationService.UpdateApplicationStatus(license.ApplicationID, enApplicationStatus.Completed);
                }

                return await LicenseRepository.AddNewLicense(license);
            }
            else
            {
                return false;
            }
        }

        public static DateTime CalcEndDate(DateTime ReleaseDate, byte ValidityPeriod)
        {
            return ReleaseDate.AddYears(ValidityPeriod);
        }

        public static async Task<clsLicense> Find(int LicenseID)
        {
            if (LicenseID > 0)
            {
                clsLicense license = await LicenseRepository.Find(LicenseID);

                if (license != null)
                {
                    license.LicenseClassInfo = await GetLicenseClass(license.LicenseClassID);
                    license.PersonInfo = await PersonService.FindByDriverID(license.DriverID);
                }

                return license;
            }
            else
            {
                return null;
            }
        }

        public static bool IsLicenseValidAndActive(clsLicense license)
        {
            if (license.IsFull())
            {
                return license.IsActive == true && license.EndDate > DateTime.Now.Date;
            }
            else
            {
                return false;
            }
        }

        public static void UpdateToReplaceDamagedOrReplaceLost(clsLicense license, int ApplicationID, int CreatedByUserID, enLicenseStatus LicenseStatus)
        {
            license.ReleaseDate = DateTime.Now.Date;
            license.LicenseStatusID = LicenseStatus;
            license.ApplicationID = ApplicationID;
            license.CreatedByUserID = CreatedByUserID;
            license.IsActive = true;
            license.LicenseFees = 0;
        }

        public static async Task<bool> UpdateActiveLicense(int LicenseID, bool Active)
        {
            if (LicenseID > 0)
            {
                return await LicenseRepository.UpdateActiveLicense(LicenseID, Active);
            }
            else
            {
                return false;
            }
        }

        public static async Task<clsLicense> FindActiveAndValidLicense(int PersonID, byte LicenseClassID)
        {
            if (PersonID > 0 && LicenseClassID > 0)
            {
                clsLicense license = await LicenseRepository.FindActiveAndValidLicense(PersonID, LicenseClassID);

                if (license != null)
                {
                    license.LicenseClassInfo = await GetLicenseClass(license.LicenseClassID);
                    license.PersonInfo = await PersonService.FindByDriverID(license.DriverID);
                }

                return license;
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> UpdateDetainedLicense(int LicenseID, bool Detained)
        {
            if (LicenseID > 0)
            {
                return await LicenseRepository.UpdateDetainedLicense(LicenseID, Detained);
            }
            else
            {
                return false;
            }
        }

        public static async Task<List<clsLicense>> GetAllLicenses()
        {
            return await LicenseRepository.GetAllLicenses();
        }

        public static async Task<List<clsLicense>> FindAllByDriverID(int DriverID)
        {
            if (DriverID > 0)
            {
                return await LicenseRepository.FindAllByDriverID(DriverID);
            }
            else
            {
                return new List<clsLicense>();
            }
        }

        public static async Task<List<clsLicense>> FindAllByNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return await LicenseRepository.FindAllByNationalNumber(NationalNumber);
            }
            else
            {
                return new List<clsLicense>();
            }
        }

        public static bool IsAllowedAge(DateTime DateOfBirth, byte MinimumAllowedAge)
        {
            if (PersonService.CalcAge(DateOfBirth) >= MinimumAllowedAge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
