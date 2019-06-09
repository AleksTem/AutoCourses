using HomeWork_04;
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

        public void SetTelenorSupportedStatus(string country, YesNoEnum IsTelenorSupportedStatus)
        {
            if (string.IsNullOrEmpty(country) || string.IsNullOrWhiteSpace(country))
            {
                return;
            }
            string cleanString = PalindromAnalizer.CleanInput(country);

            cleanString.FirstLetterToUpperCaseOrConvertNullToEmptyString();
            //country.
            var elem = _dictionary.Single(x => x.Value.Name.Equals(country));
            elem.Value.IsTelenorSupported = IsTelenorSupportedStatus;
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
