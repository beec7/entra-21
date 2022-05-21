using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            var quantidade = 4;
            var numerosVetor1 = new int[quantidade];
            var numerosVetor2 = new int[quantidade];

            for (int i = 0; i < numerosVetor1.Length; i++)
            {
                Console.Write($"Informe o { i + 1} número: ");
                numerosVetor1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numerosVetor2.Length; i++)
            {
                if (i != 0)
                {
                    numerosVetor2[i] = (numerosVetor1[i - 1] + numerosVetor1[i]);
                }
                else
                {
                    numerosVetor2[i] = (numerosVetor1[numerosVetor1.Length - 1] + numerosVetor1[i]);
                }
                Console.WriteLine( "  " + numerosVetor1[i] + "       " + numerosVetor2[i]);
            }
            Console.ReadKey();
        }
    }
}
