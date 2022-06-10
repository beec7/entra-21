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
            int codigo = 0;
            while (codigo != 6)
            {
                Console.Clear();
                //Aoresenta o menu e solicita o codigo
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    // Menu escolhido para listar produtos
                    ApresenterProdutos();
                }
                else if (codigo == 2)
                {
                    // Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    // Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarProduto();
                }
                Console.Write("Precione qualquer tecla para continuar");
                Console.ReadKey();
                //Thread.Sleep(1000); tempo de um segundo
            }
        }

        private void ApresentarProduto()
        {
            ApresenterProdutos();
            Console.WriteLine("Digite o codigo do produto a ser detalhado:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            if (produto == null)
            {
                Console.WriteLine("Produto nao encontrado");
                return;
            }

            Console.Clear();
            Console.WriteLine($@"Codigo : {produto.Codigo} 
nome: {produto.Nome}
preço unitario: { produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: {produto.CalcularPrecoTotal()}");

        }
        private void Apagar()
        {
            ApresenterProdutos();

            Console.Write("Digite o codigo do produto para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagar = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagar == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com o codigo informado");
        }
        private void Editar()
        {
            ApresenterProdutos();

            Console.Write("Código produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizacao despovinveis: 
Armazem
Area Venda
Loja\n");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = OterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == true)
            {
                Console.WriteLine("Alterado com sucesso");
            }
            else
            {
                Console.WriteLine("nao encontrado");
            }

        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu:
1 - Listar Todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - sair");
            int codigo = SolicitarCodigo();
            return codigo;

        }
        private int SolicitarCodigo()
        {
            int codigo = 0;
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localização disponiveis:
- Armazem
- Area venda
- Loja");
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
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado :( ");
                // para a axecução deste método
                return;
            }

            Console.WriteLine("Lista de produtos");

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("\nCódigo: " + produtoAtual.Codigo + "\nNome: " + produtoAtual.Nome + "\n");
            }
        }
    }
}
