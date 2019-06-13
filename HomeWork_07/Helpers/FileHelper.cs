using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HomeWork_07
{
    internal class FileHelper
    {


        internal static Dictionary<int, Country> ReadCountriesFromFile(string filePath)
        {
            int i = 0;
            return File.ReadLines(filePath, Encoding.GetEncoding(1250)).Skip(1)
                .Select(line => new KeyValuePair<int, Country>(i++, CountryResolver(line)))
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        private static Country CountryResolver(string stringLine)
        {
            List<string> lineInList = stringLine.Split('\t').ToList();
            string isTelenorSupport = lineInList.LastOrDefault();
            lineInList.RemoveAt(lineInList.Count - 1);
            bool isParsingCorrectly = Enum.TryParse(isTelenorSupport, ignoreCase: true, result: out YesNoEnum enumParsingResult);
            StringBuilder stringBuilder = new StringBuilder();
            lineInList.ForEach(x => stringBuilder.Append(x));
            return new Country(stringBuilder.ToString(), enumParsingResult);
        }


        internal static void WriteDictionaryToFile(Dictionary<int, Country> dictionary, string filePath)
        {
            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.WriteLine("Country\tIsTelenorSupported");
                foreach (var entry in dictionary)
                {
                    file.WriteLine($"{entry.Value.Name}\t{entry.Value.IsTelenorSupported}");
                }
            }
        }
    }
}
