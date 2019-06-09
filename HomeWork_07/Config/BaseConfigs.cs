using System;
using System.IO;

namespace HomeWork_07
{
    static internal class BaseConfigs
    {
        static private string _fileName = "EU_Countries.txt";
        static internal string CountriesFile => Path.Combine(AppContext.BaseDirectory, @"..\..\Data\", _fileName);
    }
}
