using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class DemoEmployee1
    {
        static void Main(string[] args)
        {
            Employee Sachin;

            Sachin = new Employee(50000,6000);

            Sachin.Salary = 400000;

            Sachin.CalculateSalary();

            Employee Gaurav;

            Gaurav = new Employee(23764, 7234679);
        }
    }
}
