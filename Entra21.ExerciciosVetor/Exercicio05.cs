using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];

            for (var i = 0; i < pesos.Length; i++)
            {
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write($"Informe o {i + 1}° peso de {pesos.Length}: ");
                        pesos[i] = Convert.ToDouble(Console.ReadLine());
                        validar = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro. esse caracter não representa um peso");
                    }

                }
            }
            var soma = 0.0;
            for (var i = 0; i < pesos.Length; i = i+1)
            {
                soma += pesos[i];
            }
            Console.Write("Soma: " + soma + "\nMédia: " + (soma/pesos.Length));
            Console.ReadKey();
        }
    }
}
