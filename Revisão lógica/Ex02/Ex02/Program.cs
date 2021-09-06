using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            //// Entrada: -3 10 -1

            Console.Write("");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("");
            c = Convert.ToInt32(Console.ReadLine());

            //// Crescente

            if (c < a && b > c)
                if (a > b)
                    Console.WriteLine("Ordem crescente: {0}{1}{2}", c, b, a);
                else 
                    Console.WriteLine("Ordem crescente: {0}{1}{2}", c, a, b);

            if (b < a && c > b)
                if (a > c)
                    Console.WriteLine("Ordem crescente: {0}{1}{2}", b, c, a);
                else
                    Console.WriteLine("Ordem crescente: {0}{1}{2}", b, a, c);
            
            if (a < b && a < c)
                if (b < c)
                    Console.WriteLine("Ordem crescente: {0}{1}{2}", a, b, c);
                else 
                    Console.WriteLine("Ordem crescente: {0}{1}{2}", a, c, b);

            //// Decrescente

            if (c < a && b > c)
                if (a > b)
                    Console.WriteLine("Ordem descrescente: {0}{1}{2}", a, b, c);
                else 
                    Console.WriteLine("Ordem descrescente: {0}{1}{2}", b, a, c);

            if (b < a && c > b)
                if (a > c)
                    Console.WriteLine("Ordem descrescente: {0}{1}{2}", a, c, b);
                else
                    Console.WriteLine("Ordem descrescente: {0}{1}{2}", c, a, b);

            if (a < b && a < c)
                if (b < c)
                    Console.WriteLine("Ordem decrescente: {0}{1}{2}", c, b, a);
                else 
                    Console.WriteLine("Ordem decrescente: {0}{1}{2}", b, c, a);

        }
    }
}
