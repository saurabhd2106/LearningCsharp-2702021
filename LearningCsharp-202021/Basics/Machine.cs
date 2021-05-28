using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class Machine
    {
        public int EngineSize { get; set; }

        protected int gears;

        public Machine()
        {
            
            Console.WriteLine("Machine Constructor");
        }


        public Machine(int engineSize)
        {
            EngineSize = engineSize;
            Console.WriteLine("Machine Constructor");
        }

        public void Start()
        {
            Console.WriteLine("Start from Machine class");
        }


        public virtual void Restart()
        {
            Console.WriteLine("Restart from Machine class");
        }
    }
}
