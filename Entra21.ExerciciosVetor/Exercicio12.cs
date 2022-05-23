using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio12
    {
        public void Executar()
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i += 1)
            {
                var validar = false;

                while (validar == false)
                {
                    try
                    {
                        Console.Write("Informe um numero: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        validar = true;
                        //for (int j = 0; j < numeros.Length; j++)
                        //{
                        //    if (numeros[i] == numeros[j])
                        //    {
                        //        validar = false;
                        //    }
                        //}
                        //if (validar == false)
                        //{
                        //    Console.WriteLine("informe um numero diferente do que ja foi informa");
                        //}
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            var contador = 0;
            var utimoValor = int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                var numeroVerificador = int.MaxValue;
                if (contador == 0)
                {
                    for (var j = 0; j < numeros.Length; j++)
                    {
                        if (numeros[j] < numeroVerificador && numeros[j] > utimoValor)
                        {
                            numeroVerificador = numeros[j];
                            contador = 0;
                        }
                        else if (numeros[j] == numeroVerificador)
                        {
                            contador++;
                        }
                    }
                    utimoValor = numeroVerificador;
                }
                else
                {
                    contador--;
                }
                Console.WriteLine(utimoValor);
            }
            Console.ReadKey();
        }
    }
}
