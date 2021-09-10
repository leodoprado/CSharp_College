using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            int iA = 0;
            int iB = 0;
            int iSomatorio = 0;
            int iAux = 0;

            Console.Write("A: ");
            iA = Convert.ToInt32(Console.ReadLine());

            Console.Write("B: ");
            iB = Convert.ToInt32(Console.ReadLine());

            // Certifica que o valor em iA seja menor do que iB, usando variavel auxiliar
            if (iA  > iB)
            {
                iAux = iA;
                iA = iB;
                iB = iAux;
            }

            // Somatório
            for (int i = iA; i <= iB; i++)
            {
                iSomatorio = iSomatorio + i; // iSomatorio += i;
            }

            Console.WriteLine("A soma os valores entre: {0} {1} {2}", iA, iB, iSomatorio);
        }
    }
}
