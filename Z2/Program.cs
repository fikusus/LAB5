using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.FindBook("11111111");
            Console.WriteLine("\nЗаполняем библеотеку");
            Book sher = new Book("Артур Конан Дойл", "Шерлок Холмс", "GHHTRFGH", 1887, 458, Genre.Crime);
            Book vlast = new Book("Дж. Р. Р. Толкин", "Властелин колец", "DSFGSDGFH", 1954, 1024, Genre.Fantasy);
            Book strana = new Book("Братья Стругацкие", "Страна багровых туч", "DFG564G", 1959, 324, Genre.Science_fiction);
            Book prizrak = new Book("Ширли Джексон", "Призрак дома на холме", "456DFGH", 1959, 658, Genre.Horror);
            Book r1984 = new Book("Джордж Оруэлл", "1984", "1984SDFG", 1948, 843, Genre.Distopia);
            library.AddBook(sher);
            library.AddBook(vlast);
            library.AddBook(strana);
            library.AddBook(prizrak);
            library.AddBook(r1984);
            Console.WriteLine(library);
            library.FindBook("11111111");
            library.FindBook("456DFGH");
            Library.CompareBooks(sher, r1984, CompareBooks.byDate);
            Library.CompareBooks(vlast, strana, CompareBooks.byCount);
            Console.ReadKey();
        }
    }
}
