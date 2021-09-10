using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iX = new int[10];
            int P = 0;
            int iSomatorio = -1;

            for (int i = 0; i < iX.Length; i++)
            {
                iSomatorio++;
                Console.Write("Digite o elemento da posição {0} do array X = ", iSomatorio);
                iX[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nDigite o valor de P entre 0 e 9: ");
            P = Convert.ToInt32(Console.ReadLine());

            while ((P < 0) || (P > 9))
            {
                    Console.Write("\nValor inválido... \nDigite um valor válido (0-9): ");
                    P = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nO elemento na posição {0} é: {1}\n", P, iX[P]);

            for (int i = P; i < 9; i++)
            {
                iX[i] = iX[i + 1];
            }

            iX[9] = 0;

            for (int i = 0; i < iX.Length; i++)
            {
                Console.WriteLine("O array X sem o valor de P: {0}", iX[i]);
            }
        }
    }
}
