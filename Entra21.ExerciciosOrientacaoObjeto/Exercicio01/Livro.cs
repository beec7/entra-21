using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class Livro
    {
        //        1. Crie uma classe chamada Livro para armazenar as seguintes informações
        //● Título
        //● Autor
        //● Código ISBN
        //● Idioma original
        //● Data de lançamento
        //● Quantidade de páginas
        //● Quantidade de páginas lidas
        //● Quantidade de releituras

        public string Titulo;
        public string Autor;
        public int CodigoIsbn;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        //Crie os seguintes métodos:
        //● ApresentarTituloAutor
        //● ApresentarQuantidadePaginasParaLer
        //● ApresentarQuantidadePaginasLidasNoTotal
        //Criar testes unitários validando os métodos criados acima

        public string ApresentarTituloAutor()
        {
            return ("Tirulo: " + Titulo + " - Autor: " + Autor);
        }
        public int ApresentarQuantidadePaginasParaLer()
        {
            return QuantidadePaginas + QuantidadePaginasLidas;
        }
        public int ApresentarQuantidadePaginasLidasNoTotal()
        {
            return (QuantidadePaginas * QuantidadeReleituras) + QuantidadePaginasLidas;
        }

    }
}
