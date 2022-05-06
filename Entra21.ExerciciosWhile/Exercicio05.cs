using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            /*5. Faça um programa que solicite a quantidade de carros que o usuário deseja
cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
atinja a quantidade de carros para cadastro.
Apresente ao final:
● Média do ano dos carros;
● Média do valor dos carros;
● Quantidade de carros que começam com a letra G;
● Quantidade de carros que começam com a letra A.
*/
            Console.Write("Informe a quantidade de carros para cadastrar: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            int somaAnoCarro = 0;
            double somaValorCarro = 0.0;
            int quantidadeCarrosComecaG = 0;
            int quantidadeCarrosComecaA = 0;
            while (indice < quantidadeCarros)
            {
                Console.Write("Informe modelo do carro: ");
                string modeloCarro = Console.ReadLine();

                Console.Write("Informe valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                indice = indice + 1;

                somaAnoCarro = somaAnoCarro + anoCarro;
                somaValorCarro = somaValorCarro + valorCarro;

                if (modeloCarro.ToLower().Trim().StartsWith("g"))
                {
                    quantidadeCarrosComecaG = quantidadeCarrosComecaG + 1;
                }
                else if (modeloCarro.ToLower().Trim().StartsWith("a"))

                    quantidadeCarrosComecaA = quantidadeCarrosComecaA + 1;
            }
            Console.WriteLine(
    "\n● Média do ano dos carros: " + (somaAnoCarro / quantidadeCarros) +
    "\n● Média do valor dos carros: " + (somaValorCarro / quantidadeCarros) +
    "\n● Quantidade de carros que começam com a letra G:" + quantidadeCarrosComecaG +
    "\n● Quantidade de carros que começam com a letra A:" + quantidadeCarrosComecaA);

        }
    }
}
