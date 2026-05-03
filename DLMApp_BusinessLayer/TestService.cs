using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_BusinessLayer
{
    public class TestService
    {
        public static List<clsTest> GetAllTests()
        {
            return TestRepository.GetAllTests();
        }

        public static short GetMaxNumberOfPeople(byte TestID)
        {
            if (TestID > 0)
            {
                return TestRepository.GetMaxNumberOfPeople(TestID);
            }

            return 0;
        }

        public static bool UpdateTest(byte TestID, float TestFees, short MaxNumberOfPeople)
        {
            if (TestID > 0 && TestFees > 0 && MaxNumberOfPeople > 0)
            {
                return TestRepository.UpdateTest(TestID, TestFees, MaxNumberOfPeople);
            }
            else
            {
                return false;
            }
        }







    }
}
