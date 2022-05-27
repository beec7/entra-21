using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista05
{
    public class Livro
    {
        //1. Crie uma classe chamada Livro para armazenar as seguintes informações
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
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePagina;
        public int QuantidadePaginaLidas;
        public int QuantidadeReleitura;

        //Crie os seguintes métodos:
        //● ApresentarTituloAutor
        //● ApresentarQuantidadePaginasParaLer
        //● ApresentarQuantidadePaginasLidasNoTotal
        //Criar testes unitários validando os métodos criados acima
        public string ApresentarTituloAutor()
        {
            return ("Titulo " + Titulo + " - Autor: " + Autor);
        }
        public int 
    }
}
