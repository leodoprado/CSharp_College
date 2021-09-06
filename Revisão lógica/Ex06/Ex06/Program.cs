using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int voltas;
            float tempo = 0;
            float melhortempo = 1;
            float voltamelhortempo = 0;

            Console.Write("Digite o número de voltas: ");
            voltas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < voltas; i++)
            {
                Console.Write("Digite o tempo de cada volta: ");
                tempo = Convert.ToSingle(Console.ReadLine());

                if (i == 1)
                {
                    melhortempo = tempo;
                }

                else
                {
                    if (tempo < melhortempo)
                    {
                        melhortempo = tempo;
                        voltamelhortempo = i;
                    }
                }
            }
            Console.WriteLine("O melhor tempo foi: {0}", melhortempo);
            Console.WriteLine("Ocorreu na volta: {0}", voltamelhortempo);
        }
    }
}
