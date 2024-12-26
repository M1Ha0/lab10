using lab10;

Console.Write("Введите название книги:");
string name = Console.ReadLine();
Console.Write("Введите автора:");
string avtor = Console.ReadLine();
Console.Write("Введите год издания:");
decimal year = decimal.Parse(Console.ReadLine());
Book emp = new Book(name, avtor, year);
emp.Print();
emp.Bookyear();
emp.BookDay();
Console.Write("Введите цену:");
int price = int.Parse(Console.ReadLine());
PriceBook priceBook = new PriceBook(name, avtor, year, price);
priceBook.Pricesell();
priceBook.Print();