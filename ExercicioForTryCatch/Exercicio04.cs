using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForTryCatch
{
    internal class Exercicio04
    {
        public void Executar()
        {
            var validar = false;
            var imprimirCrecente = "";
            var imprimirDecrecente = "";
            while (validar == false)
            {
                try
                {
                    Console.Write("Informe um número:");
                    var numero = Convert.ToInt32(Console.ReadLine());
                    var numeroCrecente = numero +1;
                    var numeroDecrecente = numero -1;
                    for (int i = 0; i <= 50; i++)
                    {
                        if ((numeroCrecente%2)!=0)
                        {
                            imprimirCrecente += (" [ " + numeroCrecente + " ] ");
                            numeroCrecente += 2;
                        }
                        else
                        {
                            numeroCrecente++;
                        }
                        if ((numeroDecrecente%2) == 0)
                        {
                            imprimirDecrecente += (" [ " + numeroDecrecente + " ] ");
                            numeroDecrecente -= 2;
                        }
                        else
                        {
                            numeroDecrecente--;
                        }
                    }
                    validar = true;
                }
                catch
                {
                    Console.Write("Não é um numero Valido");
                }
            }
            Console.Write(imprimirCrecente + "\n\n\n"+ imprimirDecrecente);
            Console.ReadKey();
        }
    }
}
