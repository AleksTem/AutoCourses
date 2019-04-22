using HomeWork_01.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square area: {new SquareFactory().Create().Area()}");
            Console.WriteLine($"Circle area: {new CircleFactory().Create().Area()}");
            Console.ReadKey();
        }        
    }
}
