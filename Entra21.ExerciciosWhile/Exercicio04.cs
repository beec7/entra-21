using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            /*4. Solicite o peso para o usuário até que o peso seja menor que 0 ou maior que
            300,00. Apresentar ao final a quantidade de pessoas que informaram o peso.
            */
            double peso = 0.0;
            int quantidadePessoasPeso = 0;
            while ((peso > 0.0) && (peso < 300.00))
            {
                Console.Write("Informe o peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                quantidadePessoasPeso = quantidadePessoasPeso + 1;
            }
        }
    }
}
