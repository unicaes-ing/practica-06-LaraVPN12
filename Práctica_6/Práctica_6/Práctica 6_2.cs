using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Práctica_6_2
    {
        static void Figura(int Alto, int Ancho)
        {
            for (int i = 1; i <=Alto; i++)
            {
                for (int j = 1; j <= Ancho; j++)
                {

                    if (i == 1 || i == Alto || j == 1 || j == Ancho)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
        static void Figura(int Alto, int Ancho, char caracter)
        {
            for (int i = 1; i <= Alto; i++)
            {
                for (int j = 1; j <= Ancho; j++)
                {

                    if (i == 1 || i == Alto || j == 1 || j == Ancho)
                    {
                        Console.Write(caracter);
                    }
                    else Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
        static void Figura(int Alto, int Ancho, char caracter, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 1; i <= Alto; i++)
            {
                for (int j = 1; j <= Ancho; j++)
                {

                    if (i == 1 || i == Alto || j == 1 || j == Ancho)
                    {
                        
                        Console.Write(caracter);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int figura;
            int ancho = 0, alto = 0;
            Console.WriteLine("Ingrese el número para la figura:\n1. Cuadrado  2. Rectángulo");
            figura = Convert.ToInt32(Console.ReadLine());
            if (figura == 1)
            {
                do{
                    Console.WriteLine("Ingrese el ancho: ");
                    ancho = Convert.ToInt32(Console.ReadLine());
                }while(ancho<=1);
                do
                {
                    Console.WriteLine("Ingrese el alto:");
                    alto = Convert.ToInt32(Console.ReadLine());
                    
                } while (alto <= 1 && alto<ancho);
                Console.WriteLine();

                Figura(alto, ancho);
                Console.WriteLine();
                Figura(alto, ancho, '.');
                Console.WriteLine();
                Figura(alto, ancho, '#', 10, 30);
                

                Console.ReadKey();
            }
            if (figura == 2)
            {
                do
                {
                    Console.WriteLine("Ingrese el ancho: ");
                    ancho = Convert.ToInt32(Console.ReadLine());
                } while (ancho <=1);
                do
                {
                    Console.WriteLine("Ingrese el alto:");
                    alto = Convert.ToInt32(Console.ReadLine());

                } while (alto == ancho);
                Console.WriteLine();

                Figura(alto, ancho);
                Console.WriteLine();
                Figura(alto, ancho, '.');
                Console.WriteLine();
                Figura(alto, ancho, '#', 5, 5);
                

                Console.ReadKey();
            }
        }
    }
}
