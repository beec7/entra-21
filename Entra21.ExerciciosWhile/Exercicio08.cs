using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            /*8. Solicite um número e apresentar a tabuada do mesmo até 1000.*/
            Console.Write("Informe o número da tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int quanteidade = 1000, indice = 0;
            while (indice <= quanteidade)
            {
                Console.WriteLine(numero + " x " + indice + " = " + (numero * indice));
                indice = indice + 1;
            }
            Console.ReadKey();
        }
    }
}
