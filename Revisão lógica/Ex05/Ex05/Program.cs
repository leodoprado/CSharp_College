using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int num = 0;
            int menor = 0;

            Console.Write("Digite o número de valores inseridos: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("");
                num = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    menor = num;
                }

                else
                {
                    if(num < menor)
                    {
                        menor = num;
                    }
                }

            }

        Console.WriteLine("Menor número: {0}", menor);

        }
    }
}
