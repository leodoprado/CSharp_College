using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Dados
            float fVelocidadeMaximaVia = 0.0f;
            float fVelocidadeMotorista = 0.0f;
            float fVelocidadeExcedente = 0.0f;

            // Entrada de Dados
            Console.Write("Digite a velocidade máxima da via: ");
            fVelocidadeMaximaVia = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a velocidade do motorista: ");
            fVelocidadeMotorista = Convert.ToSingle(Console.ReadLine());

            // Calcula a velocidade excedente do motorista 
            fVelocidadeExcedente = (fVelocidadeMotorista - fVelocidadeMaximaVia);


            if ((fVelocidadeExcedente >= 1.0f) && (fVelocidadeExcedente <= 10.0f))
            {
                Console.WriteLine("Multa = R$ 50,00");
            }

            if ((fVelocidadeExcedente >= 11.0f) && (fVelocidadeExcedente <= 30.0f))
            {
                Console.WriteLine("Multa = R$ 100,00");
            }

            if (fVelocidadeExcedente >= 31.0f)
            {
                Console.WriteLine("Multa = R$ 200,00");
            }
        }
    }
}
