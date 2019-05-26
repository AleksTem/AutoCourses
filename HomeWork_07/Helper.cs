using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork_07
{
    internal class Helper
    {
        internal static void PrintCountries(ref CountriesDictionary dictionary, bool IsTelenorSupportedFilter)
        {
            foreach (KeyValuePair<int, Country> item in 
                dictionary.Where(x => 
                    x.Value.IsTelenorSupported == IsTelenorSupportedFilter))
            {
                Console.WriteLine($"{item.Value.Name, -20} {(item.Value.IsTelenorSupported ? "Yes":"No")}");
            }
        }
    }
}
