using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Book
    {
        public string Name { get; set; }
        public string FioA { get; set; }
        private decimal year;
        public decimal Year
        {
            get => year;
            set
            {
                if (value < 2024 && value > 0) year = value;
            }
        }
        public Book() { }
        public Book(string name, string avtor, decimal year)
        {
            Name = name;
            FioA = avtor;
            Year = year;
        }
        public void Bookyear()
        {
            decimal bookyear = 2024 - year;
            Console.WriteLine($"Возраст книги:{bookyear} лет");
        }
        public void Print()
        {
            Console.WriteLine($"Название книги:{Name}, Автор:{FioA}, Год издания:{Year}");
        }
        public void BookDay()
        {
            decimal bookday = (2024 - year) * 365;
            Console.WriteLine($"Количество дней, прошедших после года издания книги:{bookday}");
        }
    }
}
