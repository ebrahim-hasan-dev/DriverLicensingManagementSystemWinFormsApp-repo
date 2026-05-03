using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_BusinessLayer
{
    public class ApplicationService
    {
        // ===============================================================================================================

        public static clsApplicationType GetApplicationType(enApplicationTypes ApplicationTypeID)
        {
            return ApplicationRepository.GetApplicationType(ApplicationTypeID);
        }

        public static List<clsApplicationType> GetAllApplicationTypes()
        {
            return ApplicationRepository.GetAllApplicationTypes();
        }

        public static bool UpdateApplicationTypeFees(byte ApplicationTypeID, float ApplicationTypeFees)
        {
            if (ApplicationTypeID > 0 && ApplicationTypeFees > 0)
            {
                return ApplicationRepository.UpdateApplicationTypeFees(ApplicationTypeID, ApplicationTypeFees);
            }
            else
            {
                return false;
            }
        }


        // ===============================================================================================================

        public static bool AddNewApplication(clsApplication Application)
        {
            if (Application.IsFull())
            {
                return ApplicationRepository.AddNewApplication(Application);
            }
            else
            {
                return false;
            }
        }

        public static bool AddNewLocalLicenseApplication(clsNewLocalLicenseApplication NewLocalLicenseApplication)
        {
            if (NewLocalLicenseApplication.IsFull())
            {
                if (ApplicationRepository.AddNewApplication(NewLocalLicenseApplication.ApplicationInfo))
                {
                    if (ApplicationRepository.AddNewLocalLisenceApplication(NewLocalLicenseApplication))
                    {
                        return true;
                    }
                    else
                    {
                        ApplicationRepository.Delete(NewLocalLicenseApplication.ApplicationInfo.ApplicationID);

                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static int FindNewLocalLicenseID(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return ApplicationRepository.FindNewLocalLicenseID(ApplicationID);
            }
            else
            {
                return 0;
            }
        }

        public static bool IsExist(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return ApplicationRepository.IsExist(ApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static bool UpdateApplicationStatus(int ApplicationID, enApplicationStatus ApplicationStatus)
        {
            if (ApplicationID > 0)
            {
                return ApplicationRepository.UpdateApplicationStatus(ApplicationID, ApplicationStatus);
            }
            else
            {
                return false;
            }
        }

        public static clsApplication Find(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return ApplicationRepository.Find(ApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static List<clsNewLocalLicenseApplication> FindAllNewLocalLicensesApplications()
        {
            return ApplicationRepository.FindAllNewLocalLicensesApplications();
        }

        public static List<clsNewLocalLicenseApplication> FindAllNewLocalLicensesApplications(DateTime AddedDateTime)
        {
            if (AddedDateTime != default(DateTime))
            {
                return ApplicationRepository.FindAllNewLocalLicensesApplications(AddedDateTime);
            }
            else
            {
                return new List<clsNewLocalLicenseApplication>();
            }
        }

        public static List<clsApplication> FindAllRenewLicensesApplications()
        {
            return ApplicationRepository.FindAllRenewLicensesApplications();
        }

        public static List<clsApplication> FindAllRenewLicensesApplications(DateTime AddedDateTime)
        {
            if (AddedDateTime != default(DateTime))
            {
                return ApplicationRepository.FindAllRenewLicensesApplications(AddedDateTime);
            }
            else
            {
                return new List<clsApplication>();
            }
        }

        public static bool IsStatusNew(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return ApplicationRepository.IsStatusNew(ApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static int DoesHaveApplicationOfSameLicenseClassForNewLocalLicenseStatusNew(int PersonID, byte LicenseClass)
        {
            if (PersonID > 0 && LicenseClass > 0)
            {
                return ApplicationRepository.DoesHaveApplicationOfSameLicenseClassForNewLocalLicenseStatusNew(PersonID, LicenseClass);
            }
            else
            {
                return 0;
            }
        }

        public static List<clsApplication> FindAllRenewLicenseApplicationsForNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return ApplicationRepository.FindAllRenewLicenseApplicationsForNationalNumber(NationalNumber);
            }
            else
            {
                return new List<clsApplication>();
            }
        }

        public static List<clsNewLocalLicenseApplication> FindAllNewLocalLicensesApplicationsForNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return ApplicationRepository.FindAllNewLocalLicensesApplicationsForNationalNumber(NationalNumber);
            }
            else
            {
                return new List<clsNewLocalLicenseApplication>();
            }
        }

        public static bool MakeFaildRenewLicenseApplicationsIsCompleted(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeopleRenewLicense)
        {
            if (ListOfRegisteredPeopleRenewLicense.Count > 0)
            {
                return ApplicationRepository.MakeFaildRenewLicenseApplicationsIsCompleted(ListOfRegisteredPeopleRenewLicense);
            }
            else
            {
                return false;
            }
        }






    }
}
