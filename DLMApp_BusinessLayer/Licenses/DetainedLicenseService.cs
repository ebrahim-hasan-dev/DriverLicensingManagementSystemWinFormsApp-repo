using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class DetainedLicenseService
    {
        public static async Task<bool> AddDetainedLicense(int LicenseID, float Fine, string Reason, DateTime DetainedDate, int CreatedByUserID)
        {
            if (LicenseID > 0 && Fine > 0 && !string.IsNullOrWhiteSpace(Reason) && CreatedByUserID > 0 && DetainedDate != default(DateTime))
            {
                await DetainedLicenseRepository.AddDetainedLicense(LicenseID, Fine, Reason, DetainedDate, CreatedByUserID);

                await LicenseService.UpdateDetainedLicense(LicenseID, true);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static async Task<clsDetainedLicenseInfo> GetDetainedLicenseInfo(int LicenseID)
        {
            if (LicenseID > 0)
            {
                return await DetainedLicenseRepository.GetDetainedLicenseInfo(LicenseID);
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> ReleaseDetainedLicense(int LicenseID, int ReleasedByUserID, int ApplicationID)
        {
            if (LicenseID > 0 && ReleasedByUserID > 0 && ReleasedByUserID > 0)
            {
                await DetainedLicenseRepository.ReleaseDetainedLicense(LicenseID, ReleasedByUserID, ApplicationID);

                await LicenseService.UpdateDetainedLicense(LicenseID, false);

                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
