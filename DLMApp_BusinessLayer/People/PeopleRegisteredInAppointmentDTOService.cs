using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_BusinessLayer
{
    public class PeopleRegisteredInAppointmentDTOService
    {
        public static List<clsPeopleRegisteredInAppointmentDTO> GetAllRegisteredPeopleInAppointment(byte TestID, ref string CreatedByUser, DateTime Appointment = new DateTime(), bool IsTestDay = false)
        {
            if (TestID > 0)
            {
                if (IsTestDay)
                {
                    if (Appointment != default(DateTime))
                    {
                        return PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointmentTestDay(TestID, ref CreatedByUser, Appointment);
                    }
                    else
                    {
                        return new List<clsPeopleRegisteredInAppointmentDTO>();
                    }
                }
                else
                {
                    return PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointment(TestID, ref CreatedByUser);
                }
            }
            else
            {
                return new List<clsPeopleRegisteredInAppointmentDTO>();
            }
        }

        public static List<clsPeopleRegisteredInAppointmentDTO> GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(byte TestID, ref string CreatedByUser, DateTime Appointment = new DateTime(), bool IsTestDay = false)
        {
            if (TestID > 0)
            {
                if (IsTestDay)
                {
                    if (Appointment != default(DateTime))
                    {
                        return PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointmentTestDayRenewLicenseTestDay(TestID, ref CreatedByUser, Appointment);
                    }
                    else
                    {
                        return new List<clsPeopleRegisteredInAppointmentDTO>();
                    }
                }
                else
                {
                    return PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(TestID, ref CreatedByUser);
                }
            }
            else
            {
                return new List<clsPeopleRegisteredInAppointmentDTO>();
            }
        }



    }
}
