using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCsharp_202021.Basics
{
    public class Employee
    {
        private int salary;
        
        private int bonus;

        public Employee()
        {
            salary = 700000;
            bonus = 30000;
        }


        public Employee(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }


        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if(value >= 0) {
                    this.salary = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Arguments - Salary cannot be negative or zero");
                }
                
            }
        }

        //get -- gives read 
        public int Bonus { get; set; }

        public void CalculateSalary()
        {
            int totalSalary;

            totalSalary = salary + bonus;

            Console.WriteLine($"Total Salary {totalSalary}");
        }

        public int CalculateSalary1()
        {
            int totalSalary;

            totalSalary = salary + bonus;

            return totalSalary;
        }

        public int CalculateSalary2(int salary, int bonus)
        {
            int totalSalary;

            totalSalary = this.salary + this.bonus;

            return totalSalary;
        }
    }
}
