using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class Car : Machine
    {

        public Car(int enginesize) : base(enginesize)
        {
            Console.WriteLine("Car Constructor");

            EngineSize = 1800;

            gears = 12;
        }
        public void RunEngine()
        {
            Console.WriteLine("Run engine in car class");
        }

        public void stopEngine()
        {
            Console.WriteLine("Stop engine in car class");
        }

        public override void Restart()
        {
            Console.WriteLine("Restart from Car class");
        }
    }
}
