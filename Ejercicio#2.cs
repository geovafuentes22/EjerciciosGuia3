using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculando el area de un Triangulo";
            Double b, h, proc, total;
            Console.Write ("Ingrese la base del triangulo por favor: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triangulo por favor: ");
            h = Double.Parse(Console.ReadLine());
            proc = b * h;
            total = proc / 2;
            Console.WriteLine("El área del triangulo dado es : "+total +" m²");
            Console.ReadKey();
        }
    }
}
