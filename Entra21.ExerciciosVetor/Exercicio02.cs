using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            var nomes = new string[3];
            for (var i = 0; i < nomes.Length; i = i + 1)
            {
                var valdiar = false;
                while (valdiar == false)
                {
                    Console.Clear();
                    Console.Write($"Informe p {i + 1}° nome:");
                    nomes[i] = Console.ReadLine();
                    if (nomes[i].Length > 2)
                    {
                        valdiar = true;
                    }
                }
            }

            var todosNomes = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                //if (i == 0)
                //{
                //    todosNomes = nomes[i];
                //}
                //else if (i < nomes.Length - 1)
                //{
                //    todosNomes += ", " + nomes[i]; 
                //}
                //else
                //{
                //    todosNomes += " e " + nomes[i];
                //}

                if (i < nomes.Length - 1)
                {
                    todosNomes += ", ";
                }
                else if (i != 0)
                {
                    todosNomes += " e ";
                }
                todosNomes += nomes[i];
            }
            Console.WriteLine(todosNomes);
            Console.ReadKey();
        }
    }
}
