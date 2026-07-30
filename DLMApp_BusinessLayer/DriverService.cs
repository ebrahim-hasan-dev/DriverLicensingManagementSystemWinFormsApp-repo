using DLMApp_DataAccessLayer;
using System.Threading.Tasks;


namespace DLMApp_BusinessLayer
{
    public class DriverService
    {
        public static async Task<int> AddNewDriver(int PersonID, int CreatedByUserID)
        {
            if (PersonID > 0 && CreatedByUserID > 0)
            {
                return await DriverRepository.AddNewDriver(PersonID, CreatedByUserID);
            }
            else
            {
                return 0;
            }
        }

        public static async Task<int> GetDriverID(int PersonID)
        {
            if (PersonID > 0)
            {
                return await DriverRepository.GetDriverID(PersonID);
            }
            else
            {
                return 0;
            }
        }



    }
}
