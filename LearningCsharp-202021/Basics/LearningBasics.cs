using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class LearningBasics
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World, from my class!!");


            Console.WriteLine("Hello world again");


            byte byteVar;

            byteVar = 6;


            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);


            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            int var = 23768247;

            Console.WriteLine("Integer value"+ var);

            Console.WriteLine(long.MaxValue);

            long longVar = 731895748957234985L;

            var = (int) longVar;

            Console.WriteLine(var);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);

            float fVar = 7.324f;

            var = (int)fVar;

            Console.WriteLine(var);

            char abc = 'A';

            bool status = false;

            string str;


            str = "   My Name is Saurabh      ";

            Console.WriteLine(str.Length);

            Console.WriteLine(str);


            str = str.Trim();
            Console.WriteLine(str);

            Console.WriteLine(str.Length);
           

            Console.WriteLine(str.Contains("Saurabh"));

            Console.WriteLine(str.StartsWith("My"));

            //String Interpollation ---

            Console.WriteLine("The value of string variable is " + str + " and I am priniting it");


            Console.WriteLine($"This value of string variable is {str} and I am priniting this and status is {status} ");
        }

    }
}
