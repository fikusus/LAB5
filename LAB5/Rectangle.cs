using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Rectangle : Figure
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            if (a > 0)
                this.a = a;
            else
                this.a = 1;

            if (b > 0)
                this.b = b;
            else
                this.b = 1;
        }

        public override double Perim()
        {
            return 2 * (a + b);
        }

        public override double Plosha()
        {
            return a * b;
        }

        public override string ToString()
        {
            return "Прямоугольник со сторонами а = " + a + " b = " + b + " периметром: " + Perim() + " площадью: " + Plosha();
        }
    }
}
