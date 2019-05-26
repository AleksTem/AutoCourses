using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_07
{
    public class Country
    {
        public string Name { get; set; }
        public bool IsTelenorSupported { get; set; }

        public Country(string name)
        {
            Name = name;
            IsTelenorSupported = false;
        }
    }
}
