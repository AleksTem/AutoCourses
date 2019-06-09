﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork_07
{
    internal class FileHelper
    {
        internal static void PrintCountries(CountriesDictionary dictionary, YesNoEnum IsTelenorSupportedFilter)
        {
            foreach (KeyValuePair<int, Country> item in
                dictionary.Where(x =>
                    x.Value.IsTelenorSupported.Equals(IsTelenorSupportedFilter)))
            {
                Console.WriteLine($"{item.Value.Name,-20} {item.Value.IsTelenorSupported}");
            }
        }

        internal static Dictionary<int, Country> ReadCountriesFromFile(string filePath)
        {
            int i = 0;
            return File.ReadLines(filePath)
                .Select(line => new KeyValuePair<int, Country>(i++, new Country(line)))
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        internal static void WriteDictionaryToFile(CountriesDictionary dictionary, string filePath)
        {
            using (StreamWriter file = new StreamWriter(filePath))
                foreach (var entry in dictionary)
                    file.WriteLine("{0} {1}", entry.Value.Name, entry.Value.IsTelenorSupported);
        }
    }
}