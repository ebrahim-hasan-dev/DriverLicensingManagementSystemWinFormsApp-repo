using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_BusinessLayer
{
    public class EnrollmentService
    {
        static enEnrollmentResults IsPasssedInThisTest(byte TestID, int NewLocalLicenseApplicationID)
        {
            if (TestID == (byte)enTests.eVisionTest)
            {
                if (EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eVisionTest) == true)
                {
                    return enEnrollmentResults.eAlreadyPassedInVisionTest;
                }
            }

            else if (TestID == (byte)enTests.eWrittenTest)
            {
                if (EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eWrittenTest) == true)
                {
                    return enEnrollmentResults.eAlreadyPassedInWrittenTest;
                }
            }

            else if (TestID == (byte)enTests.eStreetTest)
            {
                if (EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eStreetTest) == true)
                {
                    return enEnrollmentResults.eAlreadyPassedInStreetTest;
                }
            }

            return enEnrollmentResults.eNone;
        }

        public static enEnrollmentResults Enroll(int AppointmentID, byte TestID, int CreatedByUserID, int NewLocalLicenseApplicationID, float TestFees, ref short NumberOfPeopleRegistered, string Notes, int RetakeTestOrderID = 0)
        {
            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && NewLocalLicenseApplicationID > 0 && TestFees > 0)
            {
                if (EnrollmentRepository.IsSameApplicationIDExistInSameAppointment(AppointmentID, NewLocalLicenseApplicationID) == false)
                {
                    enEnrollmentResults IsPassed = IsPasssedInThisTest(TestID, NewLocalLicenseApplicationID);

                    if (IsPassed != enEnrollmentResults.eNone)
                    {
                        return IsPassed;
                    }

                    if (TestID == (byte)enTests.eWrittenTest)
                    {
                        if (EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eVisionTest) == false)
                        {
                            return enEnrollmentResults.eFailInVisionTest;
                        }
                    }

                    else if (TestID == (byte)enTests.eStreetTest)
                    {
                        if (EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eWrittenTest) == false)
                        {
                            return enEnrollmentResults.eFailInWrittenTest;
                        }
                    }

                    if (EnrollmentRepository.IsEnrollmentFoFutureAppointment(NewLocalLicenseApplicationID, TestID))
                    {
                        return enEnrollmentResults.eAlreadyEnrollBefor;
                    }

                    short MaxNumberOfPeople = TestService.GetMaxNumberOfPeople(TestID);

                    if (MaxNumberOfPeople > 0)
                    {
                        if (AppointmentService.AppointmentUpdate(AppointmentID, MaxNumberOfPeople, ref NumberOfPeopleRegistered))
                        {
                            if (EnrollmentRepository.Enroll(AppointmentID, TestID, CreatedByUserID, NewLocalLicenseApplicationID, TestFees, Notes, RetakeTestOrderID))
                            {
                                return enEnrollmentResults.Success;
                            }
                            else
                            {
                                return enEnrollmentResults.eFail;
                            }
                        }
                        else
                        {
                            return enEnrollmentResults.AppointmentCompleted;
                        }
                    }
                    else
                    {
                        return enEnrollmentResults.eFail;
                    }
                }
                else
                {
                    return enEnrollmentResults.eSameApplicationInSameApplointment;
                }
            }
            else
            {
                return enEnrollmentResults.eFail;
            }
        }

        public static enEnrollmentResults EnrollByApplicationID(int AppointmentID, byte TestID, int CreatedByUserID, int ApplicationID, float TestFees, ref short NumberOfPeopleRegistered, string Notes, int RetakeTestOrderID = 0)
        {
            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && ApplicationID > 0 && TestFees > 0)
            {
                if (ApplicationService.IsStatusNew(ApplicationID))
                {
                    int NewLocalLicenseID = ApplicationService.FindNewLocalLicenseID(ApplicationID);

                    if (NewLocalLicenseID > 0)
                    {
                        return EnrollmentService.Enroll(AppointmentID, TestID, CreatedByUserID, NewLocalLicenseID, TestFees, ref NumberOfPeopleRegistered, Notes, RetakeTestOrderID);
                    }
                    else
                    {
                        return enEnrollmentResults.eNoNewLocalLicenseID;
                    }
                }
                else
                {
                    return enEnrollmentResults.StatusNotNew;
                }
            }
            else
            {
                return enEnrollmentResults.eFail;
            }
        }

        public static bool SetResults(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople, byte TestID)
        {
            if (ListOfRegisteredPeople.Count > 0)
            {
                if (ApplicationRepository.UpdateNumberOfPassedTests(ListOfRegisteredPeople))
                {
                    return EnrollmentRepository.SetResults(ListOfRegisteredPeople, TestID);
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

        public static bool SetResults(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeopleRenewLicense)
        {
            if (ListOfRegisteredPeopleRenewLicense.Count > 0)
            {
                ApplicationService.MakeFaildRenewLicenseApplicationsIsCompleted(ListOfRegisteredPeopleRenewLicense);

                return EnrollmentRepository.SetResults(ListOfRegisteredPeopleRenewLicense);
            }
            else
            {
                return false;
            }
        }

        public static bool IsPassedInAllTests(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                int NewLocalLicenseID = ApplicationService.FindNewLocalLicenseID(ApplicationID);

                if (NewLocalLicenseID > 0)
                {
                    if (EnrollmentRepository.IsPassInTest(NewLocalLicenseID, (byte)enTests.eVisionTest) == false)
                    {
                        return false;
                    }
                    if (EnrollmentRepository.IsPassInTest(NewLocalLicenseID, (byte)enTests.eWrittenTest) == false)
                    {
                        return false;
                    }
                    if (EnrollmentRepository.IsPassInTest(NewLocalLicenseID, (byte)enTests.eStreetTest) == false)
                    {
                        return false;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public static enEnrollmentResults Enroll(int AppointmentID, byte TestID, int CreatedByUserID, float TestFees, ref short NumberOfPeopleRegistered, string Notes, int RenewLicenseApplicationID)
        {
            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && TestFees > 0 && RenewLicenseApplicationID > 0)
            {
                if (ApplicationService.IsStatusNew(RenewLicenseApplicationID))
                {
                    short MaxNumberOfPeople = TestService.GetMaxNumberOfPeople(TestID);

                    if (MaxNumberOfPeople > 0)
                    {
                        if (AppointmentService.AppointmentUpdate(AppointmentID, MaxNumberOfPeople, ref NumberOfPeopleRegistered))
                        {
                            if (EnrollmentRepository.Enroll(AppointmentID, TestID, CreatedByUserID, TestFees, Notes, RenewLicenseApplicationID))
                            {
                                return enEnrollmentResults.Success;
                            }
                            else
                            {
                                return enEnrollmentResults.eAlreadyEnrollBefor;
                            }
                        }
                        else
                        {
                            return enEnrollmentResults.AppointmentCompleted;
                        }
                    }
                    else
                    {
                        return enEnrollmentResults.eFail;
                    }
                }
                else
                {
                    return enEnrollmentResults.StatusNotNew;
                }
            }
            else
            {
                return enEnrollmentResults.eFail;
            }
        }

        public static bool IsPassedInVisionTestRenewLicense(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return EnrollmentRepository.IsPassedInVisionTestRenewLicense(ApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteByNewLocalLicenseApplicationID(int NewLocalLicenseApplicationID)
        {
            if (NewLocalLicenseApplicationID > 0)
            {
                return EnrollmentRepository.DeleteByNewLocalLicenseApplicationID(NewLocalLicenseApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteByApplicationID(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return EnrollmentRepository.DeleteByApplicationID(ApplicationID);
            }
            else
            {
                return false;
            }
        }





    }
}
