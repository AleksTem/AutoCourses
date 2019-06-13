
namespace HomeWork_07
{
    public class Country
    {
        public Country(string name) : this(name, YesNoEnum.No)
        {
        }

        public Country(string name, YesNoEnum isTelenorSupported)
        {
            Name = name;
            IsTelenorSupported = isTelenorSupported;
        }

        public string Name { get; set; }
        public YesNoEnum IsTelenorSupported { get; set; }


    }
}
