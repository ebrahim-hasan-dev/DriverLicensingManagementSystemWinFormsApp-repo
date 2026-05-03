using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }
        public float Fees { get; set; }
        public DateTime AddedDateTme { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public enApplicationStatus StatusID = enApplicationStatus.New;
        public enApplicationTypes ApplicationTypeID { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedByUser { get; set; }
        public int PersonID { get; set; }


        // this property spciel for renew license application
        public bool PassedInVisionTest { get; set; }


        public bool IsFull()
        {
            return this.Fees > 0 && this.AddedDateTme != default(DateTime) && this.StatusID != enApplicationStatus.None &&
                this.ApplicationTypeID != enApplicationTypes.None &&
                this.CreatedByUserID > 0 && this.PersonID > 0;
        }






    }
}
