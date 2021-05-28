using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public abstract class Shape
    {
        public double CalculateVolume(double side, double height)
        {
            double volume;

            volume = CalculateArea(side) * height;

            return volume;
        }

        public abstract double CalculateArea(double side);
    }
}
