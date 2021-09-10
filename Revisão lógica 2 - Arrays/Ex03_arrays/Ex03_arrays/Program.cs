using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iX = new int[10];
            int[] iY = new int[10];
            int iSomatorio = 0;

            for (int i = 0; i < iX.Length; i++)
            {
                iSomatorio++;
                Console.Write("Digite o elemento {0} do array X: ", iSomatorio);
                iX[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" ");
            iSomatorio = 0;

            for (int i = 0; i < iX.Length; i++)
            {
                iSomatorio++;
                iY[i] = iX[9 - i];
                Console.WriteLine("Elemento {0} do array Y: {1}", iSomatorio, iY[i]);
            }
        }
    }
}
