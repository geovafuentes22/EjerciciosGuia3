using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CALCULANDO ECUACIONES";
            Double x2, x1, y2, y1, proc1, proc2, proc3, proc4, proc5, result;

            Console.Write("\nIngrese el primer valor X2 de la ecuacion: ");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("\nIngrese el segundo valor X1 de la ecuacion: ");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("\nIngrese el tercer valor Y2 de la ecuacion: ");
            y2 = Double.Parse(Console.ReadLine());
            Console.Write("\nIngrese el cuarto valor Y1 de la ecuacion: ");
            y1 = Double.Parse(Console.ReadLine());

            proc1 = x2 - x1;
            proc2 = Math.Pow(proc1, 2);
            proc3 = y2 - y1;
            proc4 = Math.Pow(proc3, 2);
            proc5 = proc2 + proc4;
            result = proc5;

            Console.WriteLine("\n El resultado de la ecuación es : " + result);
            Console.ReadKey();

        }
    }
}
