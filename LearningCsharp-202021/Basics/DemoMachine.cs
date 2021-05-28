using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class DemoMachine
    {

        static void Main(string[] args)
        {
            Machine mac = new Machine(1000);

            

            mac.Start();

            mac.Restart();

            Console.WriteLine("**********************************************************");

            //------------------------------------------------

            Car car = new Car(2000);

            car.Restart();

            car.RunEngine();

            Console.WriteLine("**********************************************************");

            //-------------------------------------------------

            Machine alto = new Car(3000);

            alto.Start();

            alto.Restart();

            //-----------------------------------------------------

            var str = "Saurabh";

            var bmw = new Machine();

            var merc = new Car(3000);

            
        }
    }
}
