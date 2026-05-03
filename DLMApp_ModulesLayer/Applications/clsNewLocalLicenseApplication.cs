using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsNewLocalLicenseApplication
    {
        public int NewLocalLicenseApplicationID { get; set; }
        public byte PassedTests { get; set; }
        public enLicenseClasses LicenseClassID { get; set; }

        public clsApplication ApplicationInfo { get; set; }

        public clsNewLocalLicenseApplication()
        {
            NewLocalLicenseApplicationID = 0;
            PassedTests = 0;
            LicenseClassID = enLicenseClasses.None;
            ApplicationInfo = new clsApplication();
        }


        public bool IsFull()
        {
            return LicenseClassID != enLicenseClasses.None && ApplicationInfo.IsFull();
        }
    }
}
