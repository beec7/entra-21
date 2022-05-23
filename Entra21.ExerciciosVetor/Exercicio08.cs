using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.Clear();
            var numeros = new int[10];
            for (var i = 0; i < numeros.Length; i = i + 1)
            {
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Informe um número PAR: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        if ((numeros[i] % 2) == 0)
                        {
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Valo incoreto");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valo incoreto");
                        Console.ReadKey();
                    }
                }
            }

            Console.Clear();
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"| {numeros[i]} ");
            }
                Console.ReadKey();
        }
    }
}
