using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração do array
            int[] A = new int[5];

            int i = 0;

            while (i < A.Length)
            {
                int iVal = 0;
                bool teste1 = false;  // Checagem de valores dentro do intervalo [10-50]
                bool teste2 = false;  // Checagem de valores repetidos

                // Teste 1
                while (teste1 == false)
                {
                    Console.Write("Digite um valor entre 10-50: ");
                    iVal = Convert.ToInt32(Console.ReadLine());

                    if ((iVal >= 10) && (iVal <= 50))
                    {
                        teste1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor fora do intervalo [10-50]. Digite novamente...");
                        teste1 = false;
                    }
                }

                // Teste 2
                while (teste2 == false)
                {
                    for (int j = 0; j < A.Length; j++)
                    {

                        if (A[j] == iVal)
                        {
                            A[j] = A[j] - iVal;
                            Console.WriteLine("Valor repetido. Digite novamente...");
                            teste2 = false;
                            break;
                        }
                        else
                        {
                            teste2 = true;
                        }
                    }
                }

                // Se passou nos dois testes
                if ((teste1 == true) && (teste2 == true))
                {
                    A[i] = iVal;
                    i++;
                }

            }

            Console.WriteLine("\n\n"); // linhas em branco
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0} - ", A[j]);
            }

        }
    }
}
