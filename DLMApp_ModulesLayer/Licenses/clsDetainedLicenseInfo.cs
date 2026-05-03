using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsDetainedLicenseInfo
    {
        public int LicenseID {  get; set; }
        public float Fine {  get; set; }
        public DateTime DetainedDate {  get; set; }
        public string Reasson {  get; set; }
        public string CreatedByUser {  get; set; }
        public string ReleasedByUser {  get; set; }
        public int ApplicationID {  get; set; }
    }
}
