using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class DemoShape
    {

        static void Main(string[] args)
        {
            var cylinder = new Cylinder();

            var cuboid = new Cuboid();

            double cylVol =  cylinder.CalculateVolume(10 , 10);

            double cubVol = cuboid.CalculateVolume(10, 10);

            Console.WriteLine($"Cylinder Volume {cylVol}");

            Console.WriteLine($"Cuboid Volume {cubVol}");
        }
    }
}
