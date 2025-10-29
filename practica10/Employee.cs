using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    internal class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Зарплата не может быть отрицательной!");
                    return;
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 50000;
        }
        public void Work()
        {
            Console.WriteLine($"{Name} работает, зарплата: {Salary}.");
        }
    }
}
