using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Задание 1 ---------");

            Book book1 = new Book("Война и мир", 1200);
            Book book2 = new Book("1984");
            Book book3 = new Book();

            book1.Read();
            book2.Read();
            book3.Read();

            Console.WriteLine();

            Console.WriteLine("--------- Задание 2 ---------");

            Employee e1 = new Employee("Иван", 80000);
            Employee e2 = new Employee("Анна");

            e1.Work();
            e2.Work();

            Console.WriteLine();

            Console.WriteLine("--------- Задание 3 ---------");

            Laptop laptop = new Laptop("Dell", 16, 85);

            laptop.PowerOn();
            laptop.Work();

            Console.WriteLine();

            Console.WriteLine("--------- Задание 4 ---------");

            Point p1 = new Point(3.5, 7.2);
            Point p2 = new Point(5);
            Point p3 = new Point();

            p1.Show();
            p2.Show();
            p3.Show();

            Console.WriteLine();

            Console.WriteLine("--------- Задание 5 ---------");

            Cat cat1 = new Cat("Мурзик", 9);
            Cat cat2 = new Cat("Барсик");

            cat1.Meow();
            cat2.Meow();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
