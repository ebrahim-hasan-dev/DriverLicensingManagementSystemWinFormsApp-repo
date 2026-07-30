using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class AppointmentService
    {
        public static async Task<bool> AddNewAppointment(clsAppointment Appointment)
        {
            if (Appointment.IsFull())
            {
                return await AppointmentRepository.AddNewAppointment(Appointment);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> IsExist(clsAppointment Appointment)
        {
            if (Appointment.Appointment != default(DateTime))
            {
                return await AppointmentRepository.IsExist(Appointment);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> AppointmentUpdate(int AppointmentID, short MaxNumberOfPeople, clsEnrollmentResult EnrollmentResult)
        {
            if (AppointmentID > 0 && MaxNumberOfPeople > 0)
            {
                EnrollmentResult.NumberOfPeopleRegistered = await AppointmentRepository.GetNumberOfPeopleRegistered(AppointmentID);

                if (EnrollmentResult.NumberOfPeopleRegistered < MaxNumberOfPeople)
                {
                    EnrollmentResult.NumberOfPeopleRegistered++;
                    return await AppointmentRepository.IncreaseNumberOfPeople(AppointmentID);
                }
                else
                {
                    await AppointmentRepository.SetAppointmentComplete(AppointmentID);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
