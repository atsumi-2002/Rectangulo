using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    class Rectangulo
    {
        public Punto p1 { get; set; }
        public Punto p2 { get; set; }
        public Punto p3 { get; set; }
        public Punto p4 { get; set; }
        public double perimetro { get; set; }
        public double area { get; set; }

        public void CalcularPerimetro(double l1,double l2)
        {
            perimetro = (l1 + l2) * 2;
            
        }
        public void CalcularArea(double l1, double l2)
        {
            area = l1 * l2;
        }
    }
}
