using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practica10
{
    internal class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 1 || value > 5000)
                {
                    Console.WriteLine("Страниц должно быть от 1 до 5000!");
                    return;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public Book(string title, int pages)
        {
            this.Title = title;
            this.Pages = pages;
        }
        public Book(string title)
        {
            this.Title = title;
            this.Pages = 100;
        }
        public Book()
        {
            this.Pages = 1;
            this.Title = "Без названия";
        }
        public void Read()
        {
            Console.WriteLine($"Читаю книгу {Title}, страниц {Pages}");
        }
    }
}
