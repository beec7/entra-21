namespace Entra21.ExemploList
{
    internal class ProdutoServico
    {
        // ctrl M O 

        private List<Produto> produtos = new List<Produto>();

        // Armazenar o código do próximo produto
        private int codigoAtual = 1;

        // encapsulamento + tipoRetorno + NomeMetodo(paramentos)
        public void Adicionar(string nome,
            double precoUnitario,
            ProdutoLocalizacao localizacao,
            int quantidade)
        {
            // Atribuir valor para as Propriedades com os dados passados como parametro
            Produto produto = new Produto();
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adiciona 1 no código atual para quando criar um novo produto o produto conter outro codigo.
            codigoAtual = codigoAtual + 1;

            // Adicionar o produto instanciado na lista de produto
            produtos.Add(produto);
        }
        //Assinatura
        //encapsulamento + tipoRetorno + NomeMetodo(Parametros)
        public bool Editar(int codigoParaAlterar,
            string nome,
            double precoUnitario,
            ProdutoLocalizacao localizacao,
            int quantidade)
        {
            //Corpo
            //Obtem o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //Verifica senao foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                return false;
            }

            //Atualiza as propriedade (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            //Retorne verdadeiro pq foi possivel alterar o produto
            return true;

        }
        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipos primitivos
                //int numero = numeros[i];
                // Resgatando de uma lista de objeto
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //posso remover com o indice do objeto desejado
                    //produtos.RemoveAt(i);

                    //posso remover com o objeto desejado
                    produtos.Remove(produto);
                    //Retorna verdadeiro pq o produto com o codigo desejado foi removido da lista
                    return true;
                }
            }
            //Retorna falso pq nao foi encontrado produto com o codigo desejado, ou seja nenhum elemento foi removido.
            return false;
        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            //Percore todo o elemento para encontrar o produto
            //filtrando por Código
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em detirminado indice
                var produtoAtual = produtos[i];

                if (produtoAtual.Codigo == codigo)
                {
                    //Retorna o produto encontrado
                    return produtoAtual;

                }
            }
            //Retorna NULL, caso nao encontre um produto com o código passado como parámetro
            return null;
        }
    }
}
