using System;


namespace DLMApp_ModulesLayer
{
    public class clsEnrollmentResult
    {
        public enEnrollmentResults EnrollmentResult { get; set; } = enEnrollmentResults.eNone;
        public short NumberOfPeopleRegistered { get; set; }

        public clsEnrollmentResult(enEnrollmentResults EnrollmentResult, short NumberOfPeopleRegistered = 0)
        {
            this.EnrollmentResult = EnrollmentResult;
            this.NumberOfPeopleRegistered = NumberOfPeopleRegistered;
        }

        public clsEnrollmentResult()
        {
            this.EnrollmentResult = enEnrollmentResults.eNone;
            this.NumberOfPeopleRegistered = 0;
        }

    }
}
