using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class PeopleRegisteredInAppointmentDTOService
    {
        public static async Task<(List<clsPeopleRegisteredInAppointmentDTO>, string)> GetAllRegisteredPeopleInAppointment(byte TestID, DateTime Appointment = new DateTime(), bool IsTestDay = false)
        {
            if (TestID > 0)
            {
                if (IsTestDay)
                {
                    if (Appointment != default(DateTime))
                    {
                        return await PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointmentTestDay(TestID, Appointment);
                    }
                    else
                    {
                        return (new List<clsPeopleRegisteredInAppointmentDTO>(), "");
                    }
                }
                else
                {
                    return await PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointment(TestID);
                }
            }
            else
            {
                return (new List<clsPeopleRegisteredInAppointmentDTO>(), "");
            }
        }

        public static async Task<(List<clsPeopleRegisteredInAppointmentDTO>, string)> GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(byte TestID, DateTime Appointment = new DateTime(), bool IsTestDay = false)
        {
            if (TestID > 0)
            {
                if (IsTestDay)
                {
                    if (Appointment != default(DateTime))
                    {
                        return await PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointmentTestDayRenewLicenseTestDay(TestID, Appointment);
                    }
                    else
                    {
                        return (new List<clsPeopleRegisteredInAppointmentDTO>(), "");
                    }
                }
                else
                {
                    return await PeopleRegisteredInAppointmentDTORepository.GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(TestID);
                }
            }
            else
            {
                return (new List<clsPeopleRegisteredInAppointmentDTO>(), "");
            }
        }



    }
}
