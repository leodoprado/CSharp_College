using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int iValor = 0;
            int[] iArray = new int [10];
            int iMedia = 0;
            int iSomatorio = 0;

            for (int i = 0; i < 10; i++)
            {
                iSomatorio++;
                Console.Write("Digite o valor {0}: ", iSomatorio);
                iValor = Convert.ToInt32(Console.ReadLine());

                if (iValor <= 0)
                {
                    Console.WriteLine("Insira um valor válido: ");

                    i--;
                    iSomatorio--;
                    continue;
                }

                iArray[i] = iValor;
                iMedia += iArray[i];

                }

            iMedia = iMedia / 10;
            Console.WriteLine("A media dos valores do array é {0}", iMedia);
            }
        }
    }

