using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            var quantidadeAlunos = 1;
            var boletins = new string[quantidadeAlunos];
            var notas = new double[4];

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                var validar = false;
                Console.Clear();
                var nome = "";
                while (validar == false)
                {
                    try
                    {
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        validar = true;
                    }
                    catch
                    {
                        Console.Write("Erro");
                    }
                }

                var boletim = nome + ": ";
                var soma = 0.0;
                for (var j = 0; j < notas.Length; j++)
                {
                    validar = false;
                    while (validar == false)
                    {
                        try
                        {
                            Console.Write($"Informe a {j+1}° Nota:");
                            notas[j] = Convert.ToDouble(Console.ReadLine());
                            if (notas[i] > 0)
                            {
                                validar = true;
                                boletim += notas[j] + " | ";
                                soma += notas[j];
                            }
                            else
                            {
                                Console.Write("Nota invallida");
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.Write("Nota invallida");
                        }
                    }

                }
                boletins[i] = boletim + "Média: " + (soma / notas.Length);
            }

            Console.Clear();
            for (int i = 0; i < boletins.Length; i++)
            {
                Console.WriteLine(boletins[i] + " \n");
            }
            Console.ReadKey();
        }
    }
}
