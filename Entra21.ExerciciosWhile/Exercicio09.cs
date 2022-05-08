using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            /*9. Solicite um número e faça o fatorial deste número, utilizando while.*/
            Console.Write("Informe um número para fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string resposta = numero + "! = ";
            int indice = numero;
            int total = 1;
            while (indice > 0)
            {
                resposta = resposta + indice + " * ";
                total = total * indice;


                indice = indice - 1;
            }
            Console.Write(@"" + resposta + 
            total);
            Console.ReadKey();
        }
    }
}
