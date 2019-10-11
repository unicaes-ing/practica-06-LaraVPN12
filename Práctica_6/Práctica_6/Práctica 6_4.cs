using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Práctica_6_4
    {
        static void Main(string[] args)
        {
            int numero=0,Base=2,residuo=0;
            string digito, conversion="";
            Console.WriteLine("Ingrese el número:");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                residuo = numero % Base;
                numero = numero / Base;
                digito = "" + residuo;
                conversion = digito + conversion;

            }
            Console.WriteLine();
            Console.WriteLine("La respuesta es: {0}",conversion);
            Console.ReadKey();
        }
    }
}
