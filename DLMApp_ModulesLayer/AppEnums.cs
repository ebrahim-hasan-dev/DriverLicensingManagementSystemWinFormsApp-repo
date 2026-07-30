
namespace DLMApp_ModulesLayer
{
    public enum enApplicationStatus : byte {None = 0, New = 1, Canceled = 2, Completed = 3 };

    public enum enApplicationTypes : byte
    {
        None = 0,
        NewLocalLicense = 1,
        RenewLicense = 2,
        ReplacementForLostLicense = 3,
        ReplacementForDamagedLicense = 4,
        ReleaseDetainedLicense = 5,
        NewInternationalLicense = 6,
        RetakeTest = 7
    };

    public enum enTests : byte { eVisionTest = 1, eWrittenTest = 2, eStreetTest = 3 };

    public enum enLicenseStatus : byte { New = 1, LostReplacement = 2, DamagedReplacement = 3, Renew = 4 };

    public enum enEnrollmentResults : byte { eNone = 0, Success = 1, eSameApplicationInSameApplointment = 2, eFailInVisionTest = 3, 
        eFailInWrittenTest = 4, eFail = 5, eNoNewLocalLicenseID = 6, eAlreadyPassedInVisionTest = 7, eAlreadyPassedInWrittenTest = 8, 
        eAlreadyPassedInStreetTest = 9, eAlreadyEnrollBefor = 10, StatusNotNew = 11, AppointmentCompleted = 12};



    public enum enLicenseClasses : byte { None = 0, Class1_SmallMotorcycle = 1, Class2_HeavyMotorcycle = 2, Class3_Ordinarydriving = 3, Class4_Commercial = 4, Class5_Agricultural = 5, Class6_SmallandMediumBus = 6, Class7_TruckandHeavyVehicle = 7 };



}
