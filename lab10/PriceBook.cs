using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class PriceBook : Book
    {
        private int price;
        public int Price
        {
            get => price;
            set { if (value > 0) price = value; }
        }
        public PriceBook(string name, string avtor, decimal year,
            int price) : base(name, avtor, year)
        {
            Price = price;
        }
        public void Pricesell()
        {
            if (Year >= 5)
            {
                Price -= (price / 100) * 20;
            }
        }
        public new void Print()
        {
            Console.WriteLine($"Название книги:{Name}, Автор:{FioA}, Год издания:{Year}, Цена: {Price}");
        }
    }
}
