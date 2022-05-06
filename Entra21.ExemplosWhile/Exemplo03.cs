using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo03
    {
        public void Executar()
        {
            string nome = "";
            int quantidade = 0;

            while (nome != "fim")
            {
                Console.WriteLine("Informe nome: ");
                nome = Console.ReadLine();
                quantidade = quantidade + 1;

            }
            Console.Clear();
            Console.Write("Quantidade de nome informado: "+ quantidade);
        }
    }
}
