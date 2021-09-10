using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade_motorista;
            int velocidade_maxima = 50;
            double multa = 50;

            Console.WriteLine("Velocidade: ");
            velocidade_motorista = Convert.ToInt32(Console.ReadLine());

            if(velocidade_motorista <= velocidade_maxima)
            {
                Console.WriteLine("Não ultrapassou o limite de velocidade: \nSua velocidade foi de {0}km/h", velocidade_motorista);
            }

            if (velocidade_motorista > velocidade_maxima && velocidade_motorista < 61)
            {
                Console.WriteLine("Ultrapassou o limite de 10km/h acima da velocidade máxima: \nSua velocidade foi de {0}km/h \nMulta de R${1:f2}", velocidade_motorista,multa);
            }

            if (velocidade_motorista > velocidade_maxima && velocidade_motorista >= 61 && velocidade_motorista < 81)
            {
                Console.WriteLine("Ultrapassou o limite de 11 a 30km/h acima da velocidade máxima: \nSua velocidade foi de {0}km/h \nMulta de R${1:f2}", velocidade_motorista, multa*2 + multa);
            }

            if (velocidade_motorista > velocidade_maxima && velocidade_motorista >= 81)
            {
                Console.WriteLine("Ultrapassou o limite de 31km/h acima da velocidade máxima: \nSua velocidade foi de {0}km/h \nMulta de R${1:f2}", velocidade_motorista, multa*4 + multa*3);
            }

        }
    }
}
