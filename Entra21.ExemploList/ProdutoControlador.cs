using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploList
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            Cadastrar();
            ApresenterProdutos();
            Cadastrar();
            ApresenterProdutos();
        }
        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();
            var localizacaoProduto = OterLocalizacaoProduto(localizacao);
            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade); 
        }

        private ProdutoLocalizacao OterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }
        private void ApresenterProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("Nome: " + produtoAtual.Nome + "Preço unitario: " + produtoAtual.PrecoUnitario);
            }
        }
    }
}
