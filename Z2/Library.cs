using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{

    enum CompareBooks {
        byDate,
        byCount
    }

    class Library
    {
        private List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book FindBook(string key)
        {
            Console.WriteLine("\nИщем книгу по коду:" + key);
            if(books.Count == 0)
            {
                Console.WriteLine("В библеотеке нет книг");
                return null;
            }

            foreach (var item in books)
            {
                if(item.Key == key)
                {
                    Console.WriteLine("Найдена книга:" + item);
                    return item;
                }
            }
            Console.WriteLine("Книга по данному коду не найдена");
            return null;
        }

        public static void CompareBooks(Book b1, Book b2, CompareBooks cb)
        {
            Console.WriteLine();
            switch (cb)
            {
                case Z2.CompareBooks.byCount:
                    Console.WriteLine("Сравниваем книги " + b1.name + " " + b1.count + " страниц и " + b2.name + " " + b2.count + " страниц");
                    if(b1.count == b2.count)
                    {
                        Console.WriteLine("Количество страниц равна");
                    }else if (b1.count > b2.count)
                    {
                        Console.WriteLine("В первой книге больше страниц");
                    }
                    else
                    {
                        Console.WriteLine("Во второй книге больше страниц");
                    }
                    break;
                case Z2.CompareBooks.byDate:
                    Console.WriteLine("Сравниваем книги " + b1.name + " " + b1.year + " года и " + b2.name + " " + b2.year + " года");
                    if (b1.year == b2.year)
                    {
                        Console.WriteLine("Книги написанные в один год");
                    }
                    else if (b1.year > b2.year)
                    {
                        Console.WriteLine("Вторая книга написанная раньше");
                    }
                    else
                    {
                        Console.WriteLine("Первая книга написанная раньше");
                    }
                    break;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("\nБиблеотека:");
            foreach (var item in books)
            {
                str.Append("\n");
                str.Append(item);

            }
            return str.ToString();
        }
    }
}
