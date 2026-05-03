
using System.Collections.Generic;
using DLMApp_DataAccessLayer;
using DLMApp_ModulesLayer;


namespace DLMApp_BusinessLayer
{
    public class CountryService
    {
        public static List<clsCountry> GetAllCountries()
        {
            return CountryRepository.GetAllCountries();
        }
    }
}
