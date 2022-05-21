using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio09
    {
        public void Executar()
        {
            var quantidade = 5;
            var nomes1 = new string[quantidade];
            var nomes2 = new string[quantidade];

            for (int i = 0; i < nomes1.Length; i++)
            {
                Console.Write("Nome: ");
                nomes1[i] = Console.ReadLine().Trim().ToUpper();
                while (nomes1[i].Length < 2)
                {
                    Console.Write("Erro nome invaldo.\nNome: ");
                    nomes1[i] = Console.ReadLine().Trim().ToUpper();
                }
            }
            Console.Clear();
            for (int i = 0; i < nomes1.Length; i++)
            {
                nomes2[i] = nomes1[(nomes2.Length - 1 - i)];
                Console.Write($"nome1: {nomes1[i]}  nome2: {nomes2[i]}  |");
            }
            Console.ReadKey();
        }
    }
}
