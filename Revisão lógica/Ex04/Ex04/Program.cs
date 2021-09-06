using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int t1 = 0;
            int t2 = 0;
            int t3 = 0;
            int bas;
            int altura;

            Console.Write("Digite quantos lados tem o polígono: ");
            x = Convert.ToInt32(Console.ReadLine());

            //// TRIÂNGULO

            if (x == 3)
            {
                Console.WriteLine("\nTRIÂNGULO");

                Console.WriteLine("Digite a medida do lado 1: ");
                t1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a medida do lado 2: ");
                t2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a medida do lado 3: ");
                t3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSeu perímetro é de: {0}", t1 + t2 + t3);
            }
            //// QUADRADO

            if (x == 4)
            {
                Console.WriteLine("\nQUADRADO");

                Console.WriteLine("Digite a base: ");
                bas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a altura: ");
                altura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSua área é de: {0}", bas * altura);
            
            }

            //// PENTÁGONO

            if (x == 5)
            {
                Console.WriteLine("\nPENTÁGONO");

            }

            //// Outra situação

            else
            {
                Console.WriteLine("\nPolígono não identificado");
            }
        }
    }
}
