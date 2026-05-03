using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DLMApp_BusinessLayer
{
    public class AppointmentService
    {
        public static bool AddNewAppointment(clsAppointment Appointment)
        {
            if (Appointment.IsFull())
            {
                return AppointmentRepository.AddNewAppointment(Appointment);
            }
            else
            {
                return false;
            }
        }

        public static bool IsExist(clsAppointment Appointment)
        {
            if (Appointment.Appointment != default(DateTime))
            {
                return AppointmentRepository.IsExist(Appointment);
            }
            else
            {
                return false;
            }
        }

        public static bool AppointmentUpdate(int AppointmentID, short MaxNumberOfPeople, ref short NumberOfPeopleRegistered)
        {
            if (AppointmentID > 0 && MaxNumberOfPeople > 0)
            {
                NumberOfPeopleRegistered = AppointmentRepository.GetNumberOfPeopleRegistered(AppointmentID);

                if (NumberOfPeopleRegistered < MaxNumberOfPeople)
                {
                    NumberOfPeopleRegistered++;
                    return AppointmentRepository.IncreaseNumberOfPeople(AppointmentID);
                }
                else
                {
                    AppointmentRepository.SetAppointmentComplete(AppointmentID);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static short GetNumberOfPeopleRegistered(int AppointmentID)
        {
            if (AppointmentID > 0)
            {
                return AppointmentRepository.GetNumberOfPeopleRegistered(AppointmentID);
            }
            else
            {
                return -1;
            }
        }




    }
}
