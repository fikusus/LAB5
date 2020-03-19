using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Circle:Figure
    {
        private double r;

        public Circle(double r)
        {
            if (r > 0)
                this.r = r;
            else
                this.r = 1;
        }

        public override double Perim()
        {
            return 2 * Math.PI * r;
        }

        public override double Plosha()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override string ToString()
        {
            return "Круг с радиусом r = " + r + " периметром: " + Perim() + " площадью: " + Plosha();
        }
    }
}
