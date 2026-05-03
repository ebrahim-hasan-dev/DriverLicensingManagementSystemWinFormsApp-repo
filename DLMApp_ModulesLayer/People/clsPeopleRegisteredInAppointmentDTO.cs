using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsPeopleRegisteredInAppointmentDTO
    {
        public int PersonID { get; set; }
        public int ApplicationID { get; set; }
        public int LocalLicenseApplicationID { get; set; }
        public bool? Result { get; set; }
        public DateTime Appointment { get; set; }
        public int AppointmentID { get; set; }
        public short NumberOfPeopleRegisteredInAppointment { get; set; }
        public string Notes { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNumber { get; set; }
       
        public enLicenseClasses LicenseClass { get; set; }


        public string GetFullName()
        {
            return $"{this.FirstName} {this.SecondName} {this.ThirdName} {this.LastName}";
        }





    }
}
