using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Triangle:Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a > 0)
                this.a = a;
            else
                this.a = 1;

            if (b > 0)
                this.b = b;
            else
                this.b = 1;

            if (c > 0)
                this.c = c;
            else
                this.c = 1;

            if(a + b <= c || a + c <= b || b + c <= a)
            {
                this.a = this.b = this.c = 1;
            }
        }

        public override double Perim()
        {
            return a + b + c;
        }

        public override double Plosha()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override string ToString()
        {
            return "Треугольник со сторонами а = " + a + " b = " + b + " с = " + c + " периметром: " + Perim() + " площадью: " + Plosha();
        }
    }
}
