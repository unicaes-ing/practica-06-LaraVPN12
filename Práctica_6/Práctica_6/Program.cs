using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Program
    {
        static void Tabla(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                int total = 0;
                total = numero * i;
                Console.WriteLine("{0} x {1} = {2}",numero,i,total);
            }
        }
        static void Tabla(int numero, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Tabla(numero);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese el número para tabla de multiplicar");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Solo números mayor que 0");
                
            }
            else
            {
                Tabla(n);
                Console.WriteLine("**********************");
                Tabla(n, ConsoleColor.Blue);
            }
            Console.ReadKey();
        }
    }
}
