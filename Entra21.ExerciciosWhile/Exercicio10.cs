using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            /*10. Solicite um número e apresente:
              ● Os 50 números antecessores pares;
              ● Os 50 números sucessores ímpares.*/

            Console.Write("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int auxiliar1 = numero - 1;
            int auxiliar2 = numero + 1;
            string decrescente = "", crescente = "";
            int indice = 0;

            while (indice <= 50)
            {
                if ((auxiliar1 % 2) == 0)
                {
                    decrescente = decrescente +  " " + auxiliar1;
                    auxiliar1 = auxiliar1 - 2;
                }
                else
                {
                    auxiliar1 = auxiliar1 - 1;
                }

                if ((auxiliar2 % 2) != 0)
                {
                    crescente = crescente + " " + auxiliar2;
                    auxiliar2 = auxiliar2 + 2;
                }
                else
                {
                    auxiliar2 = auxiliar2 + 1;
                }
                indice = indice + 1;


            }
            Console.WriteLine(crescente + "\n\n" + decrescente);
            Console.ReadKey();
        }
    }
}
