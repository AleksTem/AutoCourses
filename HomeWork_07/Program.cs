using HomeWork_07.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_07
{
    class Program
    {
        public Dictionary<int, Country> Dictionary { get; set; }

        static void Main(string[] args)
        {
            Program instance = new Program();
            instance.Dictionary = FileHelper.ReadCountriesFromFile(BaseConfigs.CountriesFile);
            instance.Dictionary.Add(instance.Dictionary.Keys.Count + 1, new Country("Ukraine"));

            instance.SetTelenorSupportedStatus("hUnGa ry", YesNoEnum.Yes);
            instance.SetTelenorSupportedStatus("Denmark", YesNoEnum.Yes);

            //Print Countries without TelenorSupport
            instance.PrintCountries(instance.Dictionary, YesNoEnum.No);

            //Print Countries With TelenorSupport
            Console.WriteLine();
            instance.PrintCountries(instance.Dictionary, YesNoEnum.Yes);
            //Write Dictionary to File
            FileHelper.WriteDictionaryToFile(instance.Dictionary, BaseConfigs.CountriesFile);

            Console.ReadLine();
        }

        public void SetTelenorSupportedStatus(string countryName, YesNoEnum IsTelenorSupportedStatus)
        {
            if (string.IsNullOrEmpty(countryName) || string.IsNullOrWhiteSpace(countryName))
            {
                return;
            }

            var item = Dictionary.FirstOrDefault(x =>
            x.Value.Name.PrepareForComparison().Equals(countryName.PrepareForComparison())).Value;
            if (item == null)
            {
                throw new System.Exception("Country not found.");
            }
            item.IsTelenorSupported = IsTelenorSupportedStatus;
        }

        internal void PrintCountries(Dictionary<int, Country> dictionary, YesNoEnum isTelenorSupportedFilter)
        {
            Console.WriteLine($"Countries TelenorSupported = {isTelenorSupportedFilter}");
            var telenorSupportedCountries = dictionary.Where(x =>
                    x.Value.IsTelenorSupported.Equals(isTelenorSupportedFilter));

            foreach (KeyValuePair<int, Country> item in telenorSupportedCountries)
            {
                Console.WriteLine($"{item.Value.Name,-20} {item.Value.IsTelenorSupported}");
            }
        }

    }

}
