using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iR = new int[5];
            int[] iS = new int[10];
            int[] iX = new int[5];
            int iSomatorio = 0;
            int iCont = 0;
            bool iTest = false;

            for (int i = 0; i < iR.Length; i++)
            {
                iSomatorio++;
                Console.Write("Digite o elemento {0} do array R: ", iSomatorio);
                iR[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");
            iSomatorio = 0;

            for (int i = 0; i < iS.Length; i++)
            {
                iSomatorio++;
                Console.Write("Digite o elemento {0} do array S: ", iSomatorio);
                iS[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 0; i < iX.Length; i++)
            {
                iTest = true;
                for (int j = 0; j < 10; j++)
                {
                    if ((iR[i] == iS[j]) && (iTest))
                    {
                        iX[iCont] = iR[i];
                        iTest = false;
                        iCont++;
                    }
                }
            }

            for (int i = 0; i < iCont; i++)
            {
                Console.WriteLine("O array X possui os valores: {0}", iX[i]);
            }
        }
    }
}
