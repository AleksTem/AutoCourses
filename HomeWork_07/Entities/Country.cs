
namespace HomeWork_07
{
    public class Country
    {
        private string _name;
        public Country(string name)
        {
            Name = name;
            IsTelenorSupported = YesNoEnum.No;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public YesNoEnum IsTelenorSupported { get; set; }


    }
}
