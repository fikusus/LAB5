using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            Random random = new Random();
            Console.WriteLine("Введи количество фигур для создания");
            int n = 10;
            try
            {
                n = Int32.Parse(Console.ReadLine());
                if(n <= 0)
                {
                    n = 1;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Введено неверное значение. Принято стандартно n = 10");
            }
            for(int i = 0; i < n; i++)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        figures.Add(new Rectangle(random.Next(1, 100), random.Next(1, 100)));
                        break;
                    case 1:
                        figures.Add(new Triangle(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10)));
                        break;
                    case 2:
                        figures.Add(new Circle(random.Next(1, 100)));
                        break;
                }
            }
            foreach (var item in figures)
            {
                Console.WriteLine(item);
            }
                
            Console.ReadKey();
        }
    }
}
