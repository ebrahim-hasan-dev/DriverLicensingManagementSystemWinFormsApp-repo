using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsLicenseClass
    {
        public byte ID { get; set; }
        public string LicenseClass { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte ValidityPeriod { get; set; }

        public bool IsFull()
        {
            return this.ID > 0 && !string.IsNullOrWhiteSpace(this.LicenseClass) &&
                !string.IsNullOrWhiteSpace(this.Description) &&
                this.Fees > 0 && this.MinimumAllowedAge > 0 &&
                 this.ValidityPeriod > 0;
        }


    }


}
