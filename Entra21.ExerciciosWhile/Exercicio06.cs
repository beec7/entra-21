using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            /*6. Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de
sair, ao final deve-se aplicar ao valor total da compra um desconto de 5%.
*/
            string nomeProduto = "";
            double total = 0.0;
            while (nomeProduto.ToLower().Trim() != "sair")
            {
                Console.Write("Nome do Produto: ");
                nomeProduto = Console.ReadLine();
                if (nomeProduto.ToLower().Trim() != "sair")
                {
                    Console.Write("Valor do Produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Quantidade do Produto: ");
                    int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                    total = total + (valorProduto * quantidadeProduto);
                }

            }
            Console.Write("Total com 5% de desconto: " + (total - (total * 0.05)));
            Console.ReadKey();

        }
    }
}
