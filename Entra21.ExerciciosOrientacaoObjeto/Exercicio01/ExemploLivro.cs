namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();
            livro.Titulo = "A Arte da guera";
            livro.Autor = "desconhecido";
            livro.DataLancamento = new DateTime(1700, 01, 01);
            livro.QuantidadePaginas = 250;
            livro.QuantidadePaginasLidas = 100;
            livro.QuantidadeReleituras = 3;


            Console.WriteLine(
                livro.ApresentarTituloAutor()
                 + "\nQuantidade de paginas lidas: " + livro.ApresentarQuantidadePaginasLidasNoTotal() +
                 "\nQuantidade de paginas para ler : " + livro.ApresentarQuantidadePaginasParaLer());
        }

    }
}
