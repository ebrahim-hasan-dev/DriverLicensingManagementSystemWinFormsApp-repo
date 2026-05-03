using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DLMApp_BusinessLayer
{
    public class LicenseService
    {
        // =========================================================================================

        public static List<clsLicenseClass> GetAllLicensesClasses()
        {
            return LicenseRepository.GetAllLicensesClasses();
        }

        public static clsLicenseClass GetLicenseClass(int ApplicationID, ref int PersonID)
        {
            if (ApplicationID > 0)
            {
                return LicenseRepository.GetLicenseClass(ApplicationID, ref PersonID);
            }
            else
            {
                return null;
            }
        }

        public static clsLicenseClass GetLicenseClass(byte LicenseClassID)
        {
            if (LicenseClassID > 0)
            {
                return LicenseRepository.GetLicenseClass(LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        public static float GetLicenseClassFees(byte LicenseClassID)
        {
            if (LicenseClassID > 0)
            {
                return LicenseRepository.GetLicenseClassFees(LicenseClassID);
            }
            else
            {
                return 0;
            }
        }

        public static bool UpdateLicenseClass(byte LicenseClassID, float LicenseFees, byte ValidityPeriod, byte MinimumAllowedAge)
        {
            if (LicenseClassID > 0 && LicenseFees > 0 && ValidityPeriod > 0 && MinimumAllowedAge > 0)
            {
                return LicenseRepository.UpdateLicenseClass(LicenseClassID, LicenseFees, ValidityPeriod, MinimumAllowedAge);
            }
            else
            {
                return false;
            }
        }

        // =========================================================================================


        public static bool DoesHaveLicenseOfSameClass(int PersonID, byte LicenseClassID)
        {
            if (PersonID > 0 && LicenseClassID > 0)
            {
                return LicenseRepository.DoesHaveLicenseOfSameClass(PersonID, LicenseClassID);
            }
            else
            {
                return false;
            }
        }

        public static bool AddNewLicense(clsLicense license)
        {
            if (license.IsFull())
            {
                if (license.ID != 0)
                {
                    LicenseService.UpdateActiveLicense(license.ID, false);
                }

                if (license.LicenseStatusID == enLicenseStatus.New || license.LicenseStatusID == enLicenseStatus.Renew)
                {
                    ApplicationService.UpdateApplicationStatus(license.ApplicationID, enApplicationStatus.Completed);
                }

                return LicenseRepository.AddNewLicense(license);
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

        public static clsLicense Find(int LicenseID)
        {
            if (LicenseID > 0)
            {
                clsLicense license = LicenseRepository.Find(LicenseID);

                if (license != null)
                {
                    license.LicenseClassInfo = GetLicenseClass(license.LicenseClassID);
                    license.PersonInfo = PersonService.FindByDriverID(license.DriverID);
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

        public static bool UpdateActiveLicense(int LicenseID, bool Active)
        {
            if (LicenseID > 0)
            {
                return LicenseRepository.UpdateActiveLicense(LicenseID, Active);
            }
            else
            {
                return false;
            }
        }

        public static clsLicense FindActiveAndValidLicense(int PersonID, byte LicenseClassID)
        {
            if (PersonID > 0 && LicenseClassID > 0)
            {
                clsLicense license = LicenseRepository.FindActiveAndValidLicense(PersonID, LicenseClassID);

                if (license != null)
                {
                    license.LicenseClassInfo = GetLicenseClass(license.LicenseClassID);
                    license.PersonInfo = PersonService.FindByDriverID(license.DriverID);
                }

                return license;
            }
            else
            {
                return null;
            }
        }

        public static bool UpdateDetainedLicense(int LicenseID, bool Detained)
        {
            if (LicenseID > 0)
            {
                return LicenseRepository.UpdateDetainedLicense(LicenseID, Detained);
            }
            else
            {
                return false;
            }
        }

        public static List<clsLicense> GetAllLicenses()
        {
            return LicenseRepository.GetAllLicenses();
        }

        public static List<clsLicense> FindAllByDriverID(int DriverID)
        {
            if (DriverID > 0)
            {
                return LicenseRepository.FindAllByDriverID(DriverID);
            }
            else
            {
                return new List<clsLicense>();
            }
        }

        public static List<clsLicense> FindAllByNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return LicenseRepository.FindAllByNationalNumber(NationalNumber);
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
