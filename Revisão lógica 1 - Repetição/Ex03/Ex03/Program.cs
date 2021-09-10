using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int somapositivos = 0;
            int somanegativos = 0;

            Console.Write("");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("");
            c = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("");
            d = Convert.ToInt32(Console.ReadLine());

            Console.Write("");
            e = Convert.ToInt32(Console.ReadLine());

            //// Soma dos positivos

                if (a > 0)
                    somapositivos = a;
                if (b > 0)
                    somapositivos = somapositivos + b;
                if (c > 0)
                    somapositivos = somapositivos + c;
                if (d > 0)
                    somapositivos = somapositivos + d;
                if (e > 0)
                    somapositivos = somapositivos + e;

            Console.WriteLine("Positivos: {0}", somapositivos);

            //// Soma dos negativos

                if (a < 0)
                    somanegativos = a;
                if (b < 0)
                    somanegativos = somanegativos + b;
                if (c < 0)
                    somanegativos = somanegativos + c;
                if (d < 0)
                    somanegativos = somanegativos + d;
                if (e < 0)
                    somanegativos = somanegativos + e;

                Console.WriteLine("Negativos: {0}", somanegativos);

        }
    }
}
