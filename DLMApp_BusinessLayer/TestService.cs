using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class TestService
    {
        public static async Task<List<clsTest>> GetAllTests()
        {
            return await TestRepository.GetAllTests();
        }

        public static async Task<short> GetMaxNumberOfPeople(byte TestID)
        {
            if (TestID > 0)
            {
                return await TestRepository.GetMaxNumberOfPeople(TestID);
            }

            return 0;
        }

        public static async Task<bool> UpdateTest(byte TestID, float TestFees, short MaxNumberOfPeople)
        {
            if (TestID > 0 && TestFees > 0 && MaxNumberOfPeople > 0)
            {
                return await TestRepository.UpdateTest(TestID, TestFees, MaxNumberOfPeople);
            }
            else
            {
                return false;
            }
        }







    }
}
