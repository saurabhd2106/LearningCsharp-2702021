using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class Cylinder : Shape
    {
        public override double CalculateArea(double side)
        {
            return Math.PI * side * side;
        }
    }
}
