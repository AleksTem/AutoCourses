using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace HomeWork_07
{
    class CountriesDictionary : IEnumerable<KeyValuePair<int, Country>>
    {
        Dictionary<int, Country> _dictionary;

        public CountriesDictionary()
        {
            _dictionary = new Dictionary<int, Country>();
        }

        public CountriesDictionary(string fileName)
        {
            _dictionary = ReadCountriesFromFile(fileName);
        }

        public void Add(string country)
        {
            Add(new Country(country));
        }

        public void Add(Country country)
        {
            _dictionary.Add(_dictionary.Count + 1, country);
        }

        public void SetTelenorSupportedStatus(string Country, bool IsTelenorSupportedStatus)
        {
            _dictionary.Single(x => x.Value.Name.Equals(Country)).Value.IsTelenorSupported = IsTelenorSupportedStatus;
        }

        public IEnumerator<KeyValuePair<int, Country>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<int, Country>>)_dictionary).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<int, Country>>)_dictionary).GetEnumerator();
        }

        private static Dictionary<int, Country> ReadCountriesFromFile(string FileName)
        {
            string countriesPath = Path.Combine(AppContext.BaseDirectory, @"..\..\Data\", FileName);
            return DictionaryReader(countriesPath);
        }

        private static Dictionary<int, Country> DictionaryReader(string filename)
        {
            int i = 0;
            return File.ReadLines(filename)
                .Select(line => new KeyValuePair<int, Country>(i++, new Country(line)))
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
