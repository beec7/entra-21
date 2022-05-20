using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            var quantidadeProdutos = 2;
            var nomesProdutos = new string[quantidadeProdutos];
            var valoresProdutos = new double[quantidadeProdutos];

            for (var i = 0; nomesProdutos.Length > i; i = i + 1)
            {
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write($"Infome o nome do {i + 1 }° produto; ");
                        nomesProdutos[i] = Console.ReadLine();
                        validar = true;
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Nome Invalido");
                    }

                }
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write($"Infome o valor do {i + 1 }° produto; ");
                        valoresProdutos[i] = Convert.ToDouble(Console.ReadLine());
                        if (valoresProdutos[i] > 0.0)
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("ERRO. caracter não coresponte a um número;");
                        Console.ReadKey();
                    }
                }

            }
            for (int i = 0; i < valoresProdutos.Length; i++)
            {
                Console.WriteLine($"{i+1} Nome: {nomesProdutos[i]}  valor: R$ {valoresProdutos[i]}");
            }
            Console.ReadKey();
        }
    }
}
