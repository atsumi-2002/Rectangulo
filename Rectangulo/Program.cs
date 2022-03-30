using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al caculador de rectangulo");

            Rectangulo r = new Rectangulo();

            Console.WriteLine("Valores del punto a");
            agregarValor(r.p1);
            Console.WriteLine("Valores del punto b");
            agregarValor(r.p2);
            Console.WriteLine("Valores del punto c");
            agregarValor(r.p3);
            Console.WriteLine("Valores del punto d");
            agregarValor(r.p4);

            double L1 = distancia(r.p1,r.p2);
            double L2 = distancia(r.p2,r.p3);

            r.CalcularPerimetro(L1,L2);
            r.CalcularArea(L1, L2);

            Console.WriteLine("Perimetro: " + r.perimetro);
            Console.WriteLine("Area: " + r.area);

            Console.Read();
        }
        public static double distancia(Punto a, Punto b)
        {
            double d = Math.Pow(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2), 0.5);
            return d;
        }
        public static void agregarValor(Punto p)
        {
            Console.WriteLine("Ingrese el valor de x:");
            p.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y:");
            p.y = Convert.ToDouble(Console.ReadLine());
        }
    }
}
