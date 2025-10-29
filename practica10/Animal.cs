using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    internal class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string Name)
        {

        }
        public void Speak()
        {
            Console.WriteLine($"{Name} издаёт звук");
        }
    }

    internal class Cat : Animal
    {
        private int lives;

        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1 || value > 9)
                {
                    Console.WriteLine("Количество жизней должно быть от 1 до 9");
                }
                else
                {
                    lives = value;
                }
            }
        }
        public Cat(string name, int lives) : base(name)
        {
            this.Name = name;
            this.Lives = lives;
        }
        public Cat(string name) : base(name)
        {
            this.Name = name;
            this.Lives = 9;
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives - 1}");
        }
    }
}
