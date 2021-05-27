using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class DemoEmployee
    {
        static void Main(string[] args)
        {
            Employee Saurabh;

            Saurabh = new Employee();

            Saurabh.Salary = 50000;

            Saurabh.Bonus = 40000;

            Saurabh.CalculateSalary();

            Employee Anil = new Employee();

            Anil.Salary = 800000;

            Anil.Bonus= 60000;

            int anilSalary =   Anil.CalculateSalary1();

            Console.WriteLine($"Anil's Salary - {anilSalary}" );

            Employee Pradeep = new Employee();

            Pradeep.Salary = 700000;
            Pradeep.Bonus = 80000;

            int pradeepSalary = Pradeep.CalculateSalary2(600000, 89222);

            Console.WriteLine(pradeepSalary);


        }
    }
}
