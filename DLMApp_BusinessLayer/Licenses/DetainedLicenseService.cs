using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DLMApp_BusinessLayer
{
    public class DetainedLicenseService
    {
        public static bool AddDetainedLicense(int LicenseID, float Fine, string Reason, DateTime DetainedDate, int CreatedByUserID)
        {
            if (LicenseID > 0 && Fine > 0 && !string.IsNullOrWhiteSpace(Reason) && CreatedByUserID > 0 && DetainedDate != default(DateTime))
            {
                DetainedLicenseRepository.AddDetainedLicense(LicenseID, Fine, Reason, DetainedDate, CreatedByUserID);

                LicenseService.UpdateDetainedLicense(LicenseID, true);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDetained(int LicenseID)
        {
            if (LicenseID > 0)
            {
                return DetainedLicenseRepository.IsDetained(LicenseID);
            }
            else
            {
                return false;
            }
        }

        public static clsDetainedLicenseInfo GetDetainedLicenseInfo(int LicenseID)
        {
            if (LicenseID > 0)
            {
                return DetainedLicenseRepository.GetDetainedLicenseInfo(LicenseID);
            }
            else
            {
                return null;
            }
        }

        public static bool ReleaseDetainedLicense(int LicenseID, int ReleasedByUserID, int ApplicationID)
        {
            if (LicenseID > 0 && ReleasedByUserID > 0 && ReleasedByUserID > 0)
            {
                DetainedLicenseRepository.ReleaseDetainedLicense(LicenseID, ReleasedByUserID, ApplicationID);

                LicenseService.UpdateDetainedLicense(LicenseID, false);

                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
