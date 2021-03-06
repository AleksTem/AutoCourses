﻿using System;

namespace HomeWork_01.Figures
{
    public class Square : Shape
    {
        public Square(double side) : base(side)
        {
        }

        public override double Area() => Math.Round(Parameter * Parameter, 2);
    }
}
