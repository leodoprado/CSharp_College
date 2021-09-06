using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definição das váriaveis 
            int iA = 0;
            int iB = 0;
            int iC = 0;
            int iMaior = 0;
            int iMenor = 0;
            int iMeio = 0;

            // Entrada dos dados
            Console.Write("A: ");
            iA = Convert.ToInt32(Console.ReadLine());

            Console.Write("B: ");
            iB = Convert.ToInt32(Console.ReadLine());

            Console.Write("C: ");
            iC = Convert.ToInt32(Console.ReadLine());

            //Maior
            if ((iA > iB) && (iA > iC))
            {
                iMaior = iA;
            }

            if ((iB > iA) && (iB > iC))
            {
                iMaior = iB;
            }

            if ((iC > iA) && (iC > iB))
            {
                iMaior = iC;
            }

            // Menor
            if ((iB > iA) && (iC > iA))
            {
                iMenor = iA;
            }

            if ((iA > iB) && (iC > iB))
            {
                iMenor = iB;
            }

            if ((iA > iC) && (iB > iC))
            {
                iMenor = iC;
            }

            // Procura o intermediário
            if((iA > iMenor) && (iA < iMaior))
            {
                iMeio = iA;
            }

            if ((iB > iMenor) && (iB < iMaior))
            {
                iMeio = iB;
            }

            if ((iC > iMenor) && (iC < iMaior))
            {
                iMeio = iC;
            }

            // Exibe os valores na ordem Crescente/Descrescente 
            Console.Write("Ordem Crescente: ");
            Console.WriteLine("{0}\t{1}\t{2}", iMenor, iMeio, iMaior);

            Console.Write("Ordem Decrescente: ");
            Console.WriteLine("{0}\t{1}\t{2}", iMaior, iMeio, iMenor);
        }
    }
}
