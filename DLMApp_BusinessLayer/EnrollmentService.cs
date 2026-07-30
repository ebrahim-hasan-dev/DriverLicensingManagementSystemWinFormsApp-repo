using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class EnrollmentService
    {
        static async Task<enEnrollmentResults> IsPasssedInThisTest(byte TestID, int NewLocalLicenseApplicationID)
        {
            if (TestID == (byte)enTests.eVisionTest)
            {
                if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eVisionTest) == true)
                {
                    return enEnrollmentResults.eAlreadyPassedInVisionTest;
                }
            }

            else if (TestID == (byte)enTests.eWrittenTest)
            {
                if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eWrittenTest) == true)
                {
                    return enEnrollmentResults.eAlreadyPassedInWrittenTest;
                }
            }

            else if (TestID == (byte)enTests.eStreetTest)
            {
                if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eStreetTest) == true)
                {
                    return enEnrollmentResults.eAlreadyPassedInStreetTest;
                }
            }

            return enEnrollmentResults.eNone;
        }

        public static async Task<clsEnrollmentResult> Enroll(int AppointmentID, byte TestID, int CreatedByUserID, int NewLocalLicenseApplicationID, float TestFees, string Notes, int RetakeTestOrderID = 0)
        {
            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && NewLocalLicenseApplicationID > 0 && TestFees > 0)
            {
                if (await EnrollmentRepository.IsSameApplicationIDExistInSameAppointment(AppointmentID, NewLocalLicenseApplicationID) == false)
                {
                    enEnrollmentResults IsPassed = await IsPasssedInThisTest(TestID, NewLocalLicenseApplicationID);

                    if (IsPassed != enEnrollmentResults.eNone)
                    {
                        return new clsEnrollmentResult(IsPassed);
                    }

                    if (TestID == (byte)enTests.eWrittenTest)
                    {
                        if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eVisionTest) == false)
                        {
                            return new clsEnrollmentResult(enEnrollmentResults.eFailInVisionTest);
                        }
                    }

                    else if (TestID == (byte)enTests.eStreetTest)
                    {
                        if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseApplicationID, (byte)enTests.eWrittenTest) == false)
                        {
                            return new clsEnrollmentResult(enEnrollmentResults.eFailInWrittenTest);
                        }
                    }

                    if (await EnrollmentRepository.IsEnrollmentFoFutureAppointment(NewLocalLicenseApplicationID, TestID))
                    {
                        return new clsEnrollmentResult(enEnrollmentResults.eAlreadyEnrollBefor);
                    }

                    short MaxNumberOfPeople = await TestService.GetMaxNumberOfPeople(TestID);

                    if (MaxNumberOfPeople > 0)
                    {
                        clsEnrollmentResult EnrollmentResult = new clsEnrollmentResult();

                        if (await AppointmentService.AppointmentUpdate(AppointmentID, MaxNumberOfPeople, EnrollmentResult))
                        {
                            if (await EnrollmentRepository.Enroll(AppointmentID, TestID, CreatedByUserID, NewLocalLicenseApplicationID, TestFees, Notes, RetakeTestOrderID))
                            {
                                EnrollmentResult.EnrollmentResult = enEnrollmentResults.Success;
                                return EnrollmentResult;
                            }
                            else
                            {
                                return new clsEnrollmentResult(enEnrollmentResults.eFail);
                            }
                        }
                        else
                        {
                            return new clsEnrollmentResult(enEnrollmentResults.AppointmentCompleted);
                        }
                    }
                    else
                    {
                        return new clsEnrollmentResult(enEnrollmentResults.eFail);
                    }
                }
                else
                {
                    return new clsEnrollmentResult(enEnrollmentResults.eSameApplicationInSameApplointment);
                }
            }
            else
            {
                return new clsEnrollmentResult(enEnrollmentResults.eFail);
            }
        }

        public static async Task<clsEnrollmentResult> EnrollByApplicationID(int AppointmentID, byte TestID, int CreatedByUserID, int ApplicationID, float TestFees, string Notes, int RetakeTestOrderID = 0)
        {
            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && ApplicationID > 0 && TestFees > 0)
            {
                if (await ApplicationService.IsStatusNew(ApplicationID))
                {
                    int NewLocalLicenseID = await ApplicationService.FindNewLocalLicenseID(ApplicationID);

                    if (NewLocalLicenseID > 0)
                    {
                        return await EnrollmentService.Enroll(AppointmentID, TestID, CreatedByUserID, NewLocalLicenseID, TestFees, Notes, RetakeTestOrderID);
                    }
                    else
                    {
                        return new clsEnrollmentResult(enEnrollmentResults.eNoNewLocalLicenseID);
                    }
                }
                else
                {
                    return new clsEnrollmentResult(enEnrollmentResults.StatusNotNew);
                }
            }
            else
            {
                return new clsEnrollmentResult(enEnrollmentResults.eFail);
            }
        }

        public static async Task<bool> SetResults(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople, byte TestID)
        {
            if (ListOfRegisteredPeople.Count > 0)
            {
                if (await ApplicationRepository.UpdateNumberOfPassedTests(ListOfRegisteredPeople))
                {
                    return await EnrollmentRepository.SetResults(ListOfRegisteredPeople, TestID);
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

        public static async Task<bool> SetResults(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeopleRenewLicense)
        {
            if (ListOfRegisteredPeopleRenewLicense.Count > 0)
            {
                await ApplicationService.MakeFaildRenewLicenseApplicationsIsCompleted(ListOfRegisteredPeopleRenewLicense);

                return await EnrollmentRepository.SetResults(ListOfRegisteredPeopleRenewLicense);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> IsPassedInAllTests(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                int NewLocalLicenseID = await ApplicationService.FindNewLocalLicenseID(ApplicationID);

                if (NewLocalLicenseID > 0)
                {
                    if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseID, (byte)enTests.eVisionTest) == false)
                    {
                        return false;
                    }
                    if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseID, (byte)enTests.eWrittenTest) == false)
                    {
                        return false;
                    }
                    if (await EnrollmentRepository.IsPassInTest(NewLocalLicenseID, (byte)enTests.eStreetTest) == false)
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

        public static async Task<clsEnrollmentResult> Enroll(int AppointmentID, byte TestID, int CreatedByUserID, float TestFees, string Notes, int RenewLicenseApplicationID)
        {
            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && TestFees > 0 && RenewLicenseApplicationID > 0)
            {
                if (await ApplicationService.IsStatusNew(RenewLicenseApplicationID))
                {
                    short MaxNumberOfPeople = await TestService.GetMaxNumberOfPeople(TestID);

                    if (MaxNumberOfPeople > 0)
                    {
                        clsEnrollmentResult EnrollmentResult = new clsEnrollmentResult();

                        if (await AppointmentService.AppointmentUpdate(AppointmentID, MaxNumberOfPeople, EnrollmentResult))
                        {
                            if (await EnrollmentRepository.Enroll(AppointmentID, TestID, CreatedByUserID, TestFees, Notes, RenewLicenseApplicationID))
                            {
                                EnrollmentResult.EnrollmentResult = enEnrollmentResults.Success;
                                return EnrollmentResult;
                            }
                            else
                            {
                                return new clsEnrollmentResult(enEnrollmentResults.eAlreadyEnrollBefor);
                            }
                        }
                        else
                        {
                            return new clsEnrollmentResult(enEnrollmentResults.AppointmentCompleted);
                        }
                    }
                    else
                    {
                        return new clsEnrollmentResult(enEnrollmentResults.eFail);
                    }
                }
                else
                {
                    return new clsEnrollmentResult(enEnrollmentResults.StatusNotNew);
                }
            }
            else
            {
                return new clsEnrollmentResult(enEnrollmentResults.eFail);
            }
        }

        public static async Task<bool> IsPassedInVisionTestRenewLicense(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await EnrollmentRepository.IsPassedInVisionTestRenewLicense(ApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> DeleteByNewLocalLicenseApplicationID(int NewLocalLicenseApplicationID)
        {
            if (NewLocalLicenseApplicationID > 0)
            {
                return await EnrollmentRepository.DeleteByNewLocalLicenseApplicationID(NewLocalLicenseApplicationID);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> DeleteByApplicationID(int ApplicationID)
        {
            if (ApplicationID > 0)
            {
                return await EnrollmentRepository.DeleteByApplicationID(ApplicationID);
            }
            else
            {
                return false;
            }
        }





    }
}
