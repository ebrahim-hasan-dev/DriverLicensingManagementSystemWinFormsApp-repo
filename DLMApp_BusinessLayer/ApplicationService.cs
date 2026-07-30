using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class ApplicationService
    {
        // ===============================================================================================================

        public static async Task<clsApplicationType> GetApplicationType(enApplicationTypes ApplicationTypeID)
        {
            return await ApplicationRepository.GetApplicationType(ApplicationTypeID);
        }

        public static async Task<List<clsApplicationType>> GetAllApplicationTypes()
        {
            return await ApplicationRepository.GetAllApplicationTypes();
        }

        public static async Task<bool> UpdateApplicationTypeFees(byte ApplicationTypeID, float ApplicationTypeFees)
        {
            if (ApplicationTypeID > 0 && ApplicationTypeFees > 0)
            {
                return await ApplicationRepository.UpdateApplicationTypeFees(ApplicationTypeID, ApplicationTypeFees);
            }
            else
            {
                return false;
            }
        }


        // ===============================================================================================================

        public static async Task<bool> AddNewApplication(clsApplication Application)
        {
            if (Application.IsFull())
            {
                return await ApplicationRepository.AddNewApplication(Application);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> AddNewLocalLicenseApplication(clsNewLocalLicenseApplication NewLocalLicenseApplication)
        {
            if (NewLocalLicenseApplication.IsFull())
            {
                if (await ApplicationRepository.AddNewApplication(NewLocalLicenseApplication.ApplicationInfo))
                {
                    if (await ApplicationRepository.AddNewLocalLisenceApplication(NewLocalLicenseApplication))
                    {
                        return true;
                    }
                    else
                    {
                        await ApplicationRepository.Delete(NewLocalLicenseApplication.ApplicationInfo.ApplicationID);

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

        public static async Task<int> FindNewLocalLicenseID(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await ApplicationRepository.FindNewLocalLicenseID(ApplicationID);
            }
            else
            {
                return 0;
            }
        }

        public static async Task<bool> UpdateApplicationStatus(int ApplicationID, enApplicationStatus ApplicationStatus)
        {
            if (ApplicationID > 0)
            {
                return await ApplicationRepository.UpdateApplicationStatus(ApplicationID, ApplicationStatus);
            }
            else
            {
                return false;
            }
        }

        public static async Task<clsApplication> Find(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await ApplicationRepository.Find(ApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static async Task<List<clsNewLocalLicenseApplication>> FindAllNewLocalLicensesApplications()
        {
            return await ApplicationRepository.FindAllNewLocalLicensesApplications();
        }

        public static async Task<List<clsNewLocalLicenseApplication>> FindAllNewLocalLicensesApplications(DateTime AddedDateTime)
        {
            if (AddedDateTime != default(DateTime))
            {
                return await ApplicationRepository.FindAllNewLocalLicensesApplications(AddedDateTime);
            }
            else
            {
                return new List<clsNewLocalLicenseApplication>();
            }
        }

        public static async Task<List<clsApplication>> FindAllRenewLicensesApplications()
        {
            return await ApplicationRepository.FindAllRenewLicensesApplications();
        }

        public static async Task<List<clsApplication>> FindAllRenewLicensesApplications(DateTime AddedDateTime)
        {
            if (AddedDateTime != default(DateTime))
            {
                return await ApplicationRepository.FindAllRenewLicensesApplications(AddedDateTime);
            }
            else
            {
                return new List<clsApplication>();
            }
        }

        public static async Task<bool> IsStatusNew(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await ApplicationRepository.IsStatusNew(ApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static async Task<int> DoesHaveApplicationOfSameLicenseClassForNewLocalLicenseStatusNew(int PersonID, byte LicenseClass)
        {
            if (PersonID > 0 && LicenseClass > 0)
            {
                return await ApplicationRepository.DoesHaveApplicationOfSameLicenseClassForNewLocalLicenseStatusNew(PersonID, LicenseClass);
            }
            else
            {
                return 0;
            }
        }

        public static async Task<List<clsApplication>> FindAllRenewLicenseApplicationsForNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return await ApplicationRepository.FindAllRenewLicenseApplicationsForNationalNumber(NationalNumber);
            }
            else
            {
                return new List<clsApplication>();
            }
        }

        public static async Task<List<clsNewLocalLicenseApplication>> FindAllNewLocalLicensesApplicationsForNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return await ApplicationRepository.FindAllNewLocalLicensesApplicationsForNationalNumber(NationalNumber);
            }
            else
            {
                return new List<clsNewLocalLicenseApplication>();
            }
        }

        public static async Task<bool> MakeFaildRenewLicenseApplicationsIsCompleted(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeopleRenewLicense)
        {
            if (ListOfRegisteredPeopleRenewLicense.Count > 0)
            {
                return await ApplicationRepository.MakeFaildRenewLicenseApplicationsIsCompleted(ListOfRegisteredPeopleRenewLicense);
            }
            else
            {
                return false;
            }
        }



    }
}
