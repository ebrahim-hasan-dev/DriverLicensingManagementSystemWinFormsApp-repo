using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_BusinessLayer
{
    public class InternationalLicenseService
    {
        public static bool AddNewInternationalLicense(clsInternationalLicense InternationalLicense)
        {
            if (InternationalLicense.IsFull())
            {
                UpdateInternationalLicneseToInactive(InternationalLicense.DriverID);

                return InternationalLicenseRepository.AddNewInternationalLicense(InternationalLicense);
            }
            else
            {
                return false;
            }
        }

        public static DateTime CalcEndDate(DateTime ReleaseDate)
        {
            return ReleaseDate.AddYears(1);
        }

        public static bool UpdateInternationalLicneseToInactive(int DriverID)
        {
            if (DriverID > 0)
            {
                return InternationalLicenseRepository.UpdateInternationalLicneseToInactive(DriverID);
            }
            else
            {
                return false;
            }
        }

        public static List<clsInternationalLicense> GetInternationalLicnesesForDriver(int DriverID)
        {
            if (DriverID > 0)
            {
                return InternationalLicenseRepository.GetInternationalLicnesesForDriver(DriverID);
            }
            else
            {
                return new List<clsInternationalLicense>();
            }
        }




    }
}
