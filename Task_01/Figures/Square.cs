using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01.Figures
{
    class Square : Shape
    {        
        Square(double side) : base (side)
        {
        }

        public override double Area() => Parameter * Parameter;
    }
}
