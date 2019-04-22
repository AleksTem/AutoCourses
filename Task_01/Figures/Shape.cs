using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01.Figures
{
    abstract class Shape
    {        
        private readonly double _parameter;

        protected double Parameter => _parameter;

        public Shape(double parameter) => _parameter = parameter > 0 ? parameter : 0;

        public abstract double Area();
    }
}
