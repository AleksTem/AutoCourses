using System;

namespace HomeWork_07
{
    class Program
    {
        static void Main(string[] args)
        {
            CountriesDictionary countriesDictionary = new CountriesDictionary(BaseConfigs.CountriesFile)
            {
            "Ukraine"
            };
            countriesDictionary.SetTelenorSupportedStatus("hUnGa ry", YesNoEnum.Yes);
            countriesDictionary.SetTelenorSupportedStatus("Denmark", YesNoEnum.Yes);
            FileHelper.PrintCountries(countriesDictionary, YesNoEnum.No);
            FileHelper.WriteDictionaryToFile(countriesDictionary, BaseConfigs.CountriesFile);
            Console.ReadLine();
        }
    }

}
