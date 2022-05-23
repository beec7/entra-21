using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio13
    {
        public void Executar()
        {
            var quantidade = 5;
            var numeros = new int[quantidade];
            for (int i = 0; i < numeros.Length; i++)
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
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                    }
                }
            }

            var ultimoNumero = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
            var verificador = 100;

            }


        }
    }
}
