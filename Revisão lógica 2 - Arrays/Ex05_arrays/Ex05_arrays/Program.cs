using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iA = new int[10];
            int iX = 0;
            int iSomatorio = 0;
            bool iTeste = false;

            for (int i = 0; i < iA.Length; i++)
            {
                iSomatorio++;
                Console.Write("Digite o elemento {0} do array A = ", iSomatorio);
                iA[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (; ; )
            {
                Console.Write("\nDigite o valor de X: ");
                iX = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < iA.Length; i++)
                {
                    if (iX == iA[i])
                    {
                        iTeste = true;
                    }
                }

                if (iTeste)
                {
                    Console.WriteLine("\nACHEI");
                    break;
                }
                else
                {
                    Console.WriteLine("\nNÃO ACHEI");
                    break;
                }
            }
        }
    }
}
