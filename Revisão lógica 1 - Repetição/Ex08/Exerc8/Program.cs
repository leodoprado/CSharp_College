using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN = 0;
            int iResult = 0;

            while ((iN < 1) || (iN > 5))
            {
                Console.Write("Digite um valor entre 1 e 5: ");
                iN = Convert.ToInt32(Console.ReadLine());

                if ((iN < 1) || (iN > 5))
                {
                    Console.WriteLine("Valor inválido! Digite novamente...\n\n");
                }

            }

            for (int i = 0; i <= iN; i++)
            {
                iResult = iResult + ((i + 2) * 2);
            }

            Console.WriteLine("Result: {0}", iResult);
        }
    }
}
