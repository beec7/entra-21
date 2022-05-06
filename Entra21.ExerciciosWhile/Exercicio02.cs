using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //2. Solicite nomes ao usuário até que o mesmo digite fim para o nome.

            string nome = "";
            while (nome.ToLower().Trim() != "fim")
            {
                Console.Write("Informe nome: ");
                nome = Console.ReadLine();
            }

        }
    }
}
