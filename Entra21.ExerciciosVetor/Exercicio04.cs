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
            var quantidadeAlunos = 3;
            var boletins = new string[quantidadeAlunos];
            var notas = new double[4];

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.Clear();
                Console.Write("Nome: ");
                var nome = Console.ReadLine();
                var boletim = nome + ": ";
                var soma = 0.0;
                for (var j = 0; j < notas.Length; j++)
                {
                    Console.Write($"Informe a {j+1}° Nota:");
                    notas[j] = Convert.ToDouble(Console.ReadLine());

                    boletim += notas[j] + " | ";
                    soma += notas[j];
                }
                boletins[i] = boletim + "Média: " + (soma / notas.Length) ;
            }
            for (int i = 0; i < boletins.Length; i++)
            {
                Console.WriteLine(boletins[i] + " \n");
            }
            Console.ReadKey();
        }
    }
}
