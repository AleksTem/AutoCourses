using HomeWork_07.Helpers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace HomeWork_07
{
    class CountriesDictionary : IEnumerable<KeyValuePair<int, Country>>
    {
        Dictionary<int, Country> _dictionary;

        public CountriesDictionary(string filePath)
        {
            _dictionary = FileHelper.ReadCountriesFromFile(filePath);
            // _dictionary.Add();
        }

        public void Add(string country)
        {
            Add(new Country(country));
        }

        public void Add(Country country)
        {
            int keyRecord = _dictionary.Count + 1;
            _dictionary.Add(keyRecord, country);
        }

        public void SetTelenorSupportedStatus(string countryName, YesNoEnum IsTelenorSupportedStatus)
        {
            if (string.IsNullOrEmpty(countryName) || string.IsNullOrWhiteSpace(countryName))
            {
                return;
            }

            var item = _dictionary.FirstOrDefault(x =>
            x.Value.Name.PrepareForComparison().Equals(countryName.PrepareForComparison())).Value;
            if (item == null)
            {
                throw new System.Exception("Country not found.");
            }
            item.IsTelenorSupported = IsTelenorSupportedStatus;
        }

        public IEnumerator<KeyValuePair<int, Country>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<int, Country>>)_dictionary).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<int, Country>>)_dictionary).GetEnumerator();
        }




    }
}
