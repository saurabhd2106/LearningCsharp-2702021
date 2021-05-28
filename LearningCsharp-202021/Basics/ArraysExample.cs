using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class ArraysExample
    {

        static void Main(string[] args)
        {
            int[] arr = new int[5];

            arr[0] = 15;
            arr[1] = 23;
            arr[2] = 23;
            arr[3] = 25;
            arr[4] = 27;

            for(int index =0; index < 5; index++)
            {
                if(arr[index] > 25) {
                    Console.WriteLine("Array value " + arr[index]);
                }
                
            }

            Console.WriteLine("************************************************");

            foreach(int item in arr)
            {
                Console.WriteLine(item);

            }

            //------------------------------------------

            string[] names = new string[5];

            names[0] = "Saurabh";
            names[1] = "Gaurav";
            names[2] = "Mirav";
            names[3] = "Rohan";
            names[4] = "Sohan";

            foreach(string name in names)
            {
                Console.WriteLine($"Name defined in the array are {name}");
            }

            //------------------------------------------------------

            Object[] obj = new object[5];

            obj[0] = "Saurabh";

            obj[0] = 11;

            List<string> list = new List<string>();

            list.Add("Saurabh");
            list.Add("Gaurav");
            list.Add("Rohan");
            list.Add("Mohan");
            list.Add("Rohit");
            list.Add("Saurabh");
            list.Add("Saurabh");

            list.Sort();

            list.AddRange(names);

            foreach(string name in list)
            {
                Console.WriteLine(name);
            }

            //------------------------------------------------------------


            int[] arrExample = new int[10] {0,2,4,0,2,1,1,0,0,1};

            int[] count = new int[10];

            foreach(int item in arrExample)
            {
                count[item]++;
            }

            Console.WriteLine($"count of 0 is {count[0]} and count of 1 is {count[1]} and count of 4 {count[4]}" );



            int[,] arrExample2d = new int[10,10] ;



            int[] count2d = new int[10];

            foreach (var item in arrExample2d)
            {
                count[item]++;
                
            }

            for(int row=0; row<10; row++)
            {
                for(int col =0; col < 10; col++)
                {
                    count[arrExample2d[row,col]]++;
                }
            }

            Console.WriteLine($"count of 0 is {count[0]} and count of 1 is {count[1]} and count of 4 {count[4]}");

        }
    }
}
