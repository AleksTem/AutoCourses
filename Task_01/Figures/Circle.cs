using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01.Figures
{
    class Circle : Shape
    {
        private const double Pi = 3.14;

        Circle(double radius) : base(radius)
        {
        }

        public override double Area() => Pi * Parameter;
    }
}
