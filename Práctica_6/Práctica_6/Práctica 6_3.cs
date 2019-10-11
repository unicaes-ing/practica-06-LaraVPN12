using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{

    class Práctica_6_3
    {
        static double Exponencial(int Numero, int Exponente)
        {
            if (Exponente == 0)
            {
                return 1;
            }
            else if (Exponente < 0)
            {
                return Exponencial(Numero,Exponente+1) / Numero;
            }
            else
            {
                return Numero * Exponencial(Numero, Exponente-1);
            }
        }
        static void Main(string[] args)
        {
            int numero,exponente;
            Console.WriteLine("Ingrese la base");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente");
            exponente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} elevado a la {1} es: {2}", numero,exponente,Exponencial(numero,exponente));
            Console.ReadKey();


        }
    }
}
