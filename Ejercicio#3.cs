using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Resolviendo ecuaciones";
            Double r, proc, total;
            Console.Write("\n Ingrese el valor del radio para resolver la ecuación: ");
            r = Double.Parse(Console.ReadLine());
            proc = System.Math.PI * Math.Pow(r, 3);
            total = proc * 3 / 4;
            Console.WriteLine("El resultado de la ecuación es: " + total);
            Console.ReadKey();
        }
    }
}
