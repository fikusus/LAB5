using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Genre {
    Crime,
    Science_fiction,
    Distopia,
    Fantasy,
    Horror
}


namespace Z2
{
    class Book
    {
        public string author{ private set; get; }
        public string name { private set; get; }
        private string key;
        public string Key {
            set
            {
                if(value.Count(char.IsPunctuation) > 0)
                {
                    Console.WriteLine("Новый код не верный");
                    key = String.Empty;
                }
                else
                {
                    key = value;
                }
            }
            get
            {
                return key;
            }
        }
        public uint year { private set; get; }
        public uint count { private set; get; }
        public Genre genre { private set; get; }

        public Book(string author, string name, string key, uint year, uint count, Genre genre)
        {
            this.author = author ?? throw new ArgumentNullException(nameof(author));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.key = key ?? throw new ArgumentNullException(nameof(key));
            this.year = year;

            this.count = count;
            this.genre = genre;
        }

        public override string ToString()
        {
            return author + " '" + name + "' " + year + " года " + count + " страниц жанр " + genre;  
        }
    }


}
