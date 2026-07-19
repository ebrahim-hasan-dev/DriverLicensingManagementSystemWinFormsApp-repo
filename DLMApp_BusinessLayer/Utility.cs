using DLMApp_ModulesLayer;
using System;


namespace DLMApp_BusinessLayer
{
    public class Utility
    {
        public static clsApplication FillAndGetApplication(int PersonID, enApplicationStatus ApplicationStatus, enApplicationTypes ApplicationTypes, float Fees, int CurrentUserID)
        {
            clsApplication Application = new clsApplication();

            Application.PersonID = PersonID;
            Application.StatusID = ApplicationStatus;
            Application.AddedDateTme = DateTime.Now;
            Application.ApplicationTypeID = ApplicationTypes;
            Application.CreatedByUserID = CurrentUserID;
            Application.Fees = Fees;

            return Application;
        }

       
    }
}
