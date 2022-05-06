using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            /*7. Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que
5. Ao final deve-se aplicar um desconto de R$ 150,00.
*/

            double totalPedido = 0.0;
            int quantidade = 0;

            while (quantidade < 5)
            {
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de produto: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                if (quantidade < 5)
                {
                    totalPedido = totalPedido + (valor * quantidade);
                }
            }
            Console.Write("Total com desconto de R$150: " + (totalPedido - 150));

        }
    }
}
