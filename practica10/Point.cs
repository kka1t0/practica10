using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point(double value)
        {
            this.X = value;
            this.Y = value;
        }
        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }
        public void Show()
        {
            Console.WriteLine($"Точка: ( {x} ; {y} )");
        }
    }
}
