using System;


namespace DLMApp_ModulesLayer
{
    public class clsAppointment
    {
        public int ID { get; set; }
        public DateTime Appointment { get; set; }
        public bool IsCompleted { get; set; }
        public short NumberOfPeople { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedByUser { get; set; }

        public bool IsFull()
        {
            return NumberOfPeople > -1 && CreatedByUserID > 0 && Appointment != default(DateTime);
        }


    }
}
