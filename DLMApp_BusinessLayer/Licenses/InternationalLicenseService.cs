using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class InternationalLicenseService
    {
        public static async Task<bool> AddNewInternationalLicense(clsInternationalLicense InternationalLicense)
        {
            if (InternationalLicense.IsFull())
            {
                await UpdateInternationalLicneseToInactive(InternationalLicense.DriverID);

                return await InternationalLicenseRepository.AddNewInternationalLicense(InternationalLicense);
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

        public static async Task<bool> UpdateInternationalLicneseToInactive(int DriverID)
        {
            if (DriverID > 0)
            {
                return await InternationalLicenseRepository.UpdateInternationalLicneseToInactive(DriverID);
            }
            else
            {
                return false;
            }
        }

        public static async Task<List<clsInternationalLicense>> GetInternationalLicnesesForDriver(int DriverID)
        {
            if (DriverID > 0)
            {
                return await InternationalLicenseRepository.GetInternationalLicnesesForDriver(DriverID);
            }
            else
            {
                return new List<clsInternationalLicense>();
            }
        }



    }
}
