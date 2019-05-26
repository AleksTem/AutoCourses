using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "EU_Countries.txt";
            CountriesDictionary countriesDictionary = new CountriesDictionary(fileName)
            {
                "Ukraine"
            };
            countriesDictionary.SetTelenorSupportedStatus("Hungary", true);
            countriesDictionary.SetTelenorSupportedStatus("Denmark", true);
            Helper.PrintCountries(ref countriesDictionary, false);
            Console.ReadLine();
        }
    }
}
