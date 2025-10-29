using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    internal class Device
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Device(string brand)
        {
            Brand = brand;
        }
        public void PowerOn()
        {
            Console.WriteLine($"{brand} включён.");
        }
    }
    internal class Laptop : Device
    {
        private int ram;
        private int battery;

        public Laptop(string brand) : base(brand)
        {
        }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 1 || value > 64)
                {
                    Console.WriteLine("ОЗУ должно быть от 1 до 64");
                    return;
                }
                else
                {
                    ram = value;
                }
            }
        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд батареи должно быть от 0 до 100");
                    return;
                }
                else
                {
                    battery = value;
                }
            }
        }
        public Laptop(string brand, int ram, int battery) : base(brand)
        {
            Ram = ram;
            Battery = battery;
        }
        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery} %.");
        }
    }
}
