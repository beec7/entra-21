using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[3];

            for (var i = 0; i < numeros.Length; i++)
            {
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write($"Informe o {i + 1}° número de {numeros.Length}: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        validar = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erro. esse caracter não representa um inteiro");
                    }

                }
            }
            var soma = 0;
            for (var i = 0; i < numeros.Length; i = i+1)
            {
                soma += numeros[i];
            }
            Console.Write("A soma de todos os número: " + soma);
            Console.ReadKey();
        }
    }
}
