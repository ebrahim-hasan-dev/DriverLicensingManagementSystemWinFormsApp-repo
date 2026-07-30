using System.Collections.Generic;
using System.Threading.Tasks;
using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;


namespace DLMApp_BusinessLayer
{
    public class CountryService
    {
        public static async Task<List<clsCountry>> GetAllCountries()
        {
            return await CountryRepository.GetAllCountries();
        }


    }
}
