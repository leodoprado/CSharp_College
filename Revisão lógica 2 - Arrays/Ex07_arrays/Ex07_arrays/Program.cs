using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iA= new int[10];
            int iSomatorio = 0;

            for (int i = 0; i < iA.Length; i++)
            {
                iSomatorio++;
                Console.Write("Digite o elemento {0} do array A = ", iSomatorio);
                iA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 1; i < iA.Length; i++)
            {

                Console.WriteLine("Array: {0}", iA[i]);
            }
            Console.WriteLine("");
        }
    }
}
