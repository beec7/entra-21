using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            Console.Clear();
            int maiorIdade = int.MinValue;
            int[] idades = new int[9];
            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write($"Informe o {i + 1}° peso: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

                while (idades[i] < 0)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Idade invalida");
                        idades[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Write("");
                        Console.ReadKey();
                    }
                }
            }
            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                }
            }
            Console.Write("A maior idade é: " + maiorIdade);
            Console.ReadKey();
        }
    }
}
