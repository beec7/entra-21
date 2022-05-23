using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio11
    {
        public void Executar()
        {
            //4 - Crie um vetor e solicite os números. Crie outros dois vetores, um deles irá armazenar
            //somente os números pares do vetor 1, o outro irá armazenar somente os números ímpares
            //do vetor 1.
            //Obrigatório utilização de for para preencher o vetor 2 e 3

            var quantidade = 10;
            var numeros = new int[quantidade];
            var contadorPar = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write($"Informe o {i + 1} de {numeros.Length}: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        validar = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro");
                    }
                }
                if ((numeros[i] % 2) == 0)
                {
                    contadorPar++;
                }
            }

            var numerosPares = new int[contadorPar];
            var numerosImpares = new int[numeros.Length - contadorPar];
            contadorPar = 0;
            var contadorImpar = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if ((numeros[i] % 2) == 0)
                {
                    numerosPares[contadorPar] = numeros[i];
                    contadorPar++;
                }
                else
                {
                    numerosImpares[contadorImpar] = numeros[i];
                    contadorImpar++;
                }
            }

            for (int i = 0; i < numerosPares.Length; i++)
            {
                Console.Write(" " + numerosPares[i] + " |");
            }
            
            Console.WriteLine("\n");

            for (int i = 0; i < numerosImpares.Length; i++)
            {
                Console.Write(" " + numerosImpares[i] + " |");
            }
            Console.ReadKey();
        }
    }
}