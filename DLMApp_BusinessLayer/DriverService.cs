using DLMApp_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_BusinessLayer
{
    public class DriverService
    {
        public static int AddNewDriver(int PersonID, int CreatedByUserID)
        {
            if (PersonID > 0 && CreatedByUserID > 0)
            {
                return DriverRepository.AddNewDriver(PersonID, CreatedByUserID);
            }
            else
            {
                return 0;
            }
        }

        public static int GetDriverID(int PersonID)
        {
            if (PersonID > 0)
            {
                return DriverRepository.GetDriverID(PersonID);
            }
            else
            {
                return 0;
            }
        }



    }
}
