using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class Cuboid : Shape
    {
        public override double CalculateArea(double side)
        {
            return side * side;
        }
    }
}
