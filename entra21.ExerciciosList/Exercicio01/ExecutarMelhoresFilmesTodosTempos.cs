using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ExerciciosList.Exercicio01
{
    internal class ExecutarMelhoresFilmesTodosTempos
    {
        public void Executar()
        {
            MelhoresFilmesTodosTempos melhoresFilmes = new MelhoresFilmesTodosTempos();
            melhoresFilmes.AdicionarFilmes();
            melhoresFilmes.ListarFilmes();
            melhoresFilmes.AdicionarNovoFilme();
            melhoresFilmes.RemoverFilme();
            melhoresFilmes.VeridicarFilme();
            melhoresFilmes.AdicionarOutroFilme();
            melhoresFilmes.ListarNovameteFilme();
            melhoresFilmes.AlterarFilme();
            melhoresFilmes.ListarNovameteFilme();
            melhoresFilmes.VeridicarFilme2();
        }

    }
}
