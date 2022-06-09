using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploList
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        // encapsulamento + tipoRetorno + NomeMetodo(paramentos)
        public void Adicionar(string nome, double precoUnitario,
            ProdutoLocalizacao localizacao, int quantidade )
        {
            // Atribuir valor para as Propriedades com os dados passados como parametro
            Produto produto = new Produto();
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Adicionar o produto instanciado na lista de produto
            produtos.Add( produto ); 
        }
        public void Editar()
        {

        }
        public void Apagar()
        {

        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
