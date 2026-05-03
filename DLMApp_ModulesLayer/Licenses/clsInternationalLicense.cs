using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int LocalLicenseID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int DriverID { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedByUser { get; set; }
        public int ApplicationID { get; set; }


        public bool IsFull()
        {
            return this.EndDate != default(DateTime) && this.CreatedByUserID > 0 && this.ReleaseDate != default(DateTime) &&
                this.ApplicationID > 0 && this.LocalLicenseID > 0 && this.DriverID > 0;
        }






    }
}
