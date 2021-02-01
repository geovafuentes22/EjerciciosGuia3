using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "\nCalculemos los Kilometros en 'Metros' , 'Yardas'  y 'Varas'";
            Double k, m, y, v;
            Console.Write("\nIngresa la cantidad de Kilometros que quieras convertir: ");
            k = Double.Parse(Console.ReadLine());
            m = k * 1000;
            y = m * 1.09361;
            v = m * 1.1963 ;
            Console.WriteLine("Los resultados son: ");
            Console.WriteLine("En metros tenemos : " +m +" M");
            Console.WriteLine("En yardas tenemos : " +y +" Y");
            Console.WriteLine("En varas tenemos : " +v +" V");
            Console.ReadKey();

        }
    }
}
