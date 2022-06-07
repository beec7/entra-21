using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ExerciciosList.Exercicio01
{
    internal class MelhoresFilmesTodosTempos
    {
        public List<String> MelhoresFilmes = new List<string>();

        //d. Listar os filmes armazenados na lista;
        //e. Adicionar o filme "";
        //f. Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
        //g. Remover filme "Lanterna verde";
        //h. Verificar se a lista contém o filme "Lanterna verde" apresentando para o
        //usuário se está ou não cadastrado;
        //i. Adicionar o filme "Quarteto fantástico";
        //j. Listar os filmes armazenados na lista;
        public void AdicionarFilmes()
        {
            //a.Adicionar o filme "Dragon Ball Evollution";
            //b.Adicionar o filme "Titanic";
            //c.Adicionar o filme "Lanterna verde";
            MelhoresFilmes.Add("Dragon Ball Evollution");
            MelhoresFilmes.Add("Titanic");
            MelhoresFilmes.Add("Lanterna verde");
        }
        public void ListarFilmes()
        {
            Console.WriteLine("[0] : " + MelhoresFilmes[0] +
                "\n[1]: " + MelhoresFilmes[1] +
                "\n[2]: " + MelhoresFilmes[2]);
        }

        public void AdicionarNovoFilme()
        {
            MelhoresFilmes.Add("");
        }
        public void RemoverFilme()
        {
            MelhoresFilmes.Remove("Lanterna verde");
        }
        public void VeridicarFilme()
        {
            var varificarFilme = MelhoresFilmes.Contains("Lanterna verde");
            Console.WriteLine("O filme Lanterna verde existe na lista " + varificarFilme);
        }

        public void AdicionarOutroFilme()
        {
            MelhoresFilmes.Add("Quarteto fantástico");
        }
        public void ListarNovameteFilme()
        {
            Console.WriteLine("[0] : " + MelhoresFilmes[0] +
    "\n[1]: " + MelhoresFilmes[1] +
    "\n[2]: " + MelhoresFilmes[2] +
    "\n[3]: " + MelhoresFilmes[3]);
        }
        public void AlterarFilme()
        {
            var indiceFilme = MelhoresFilmes.IndexOf("Titanic");
            MelhoresFilmes[indiceFilme] = "Titanic 2";
        }

        public void VeridicarFilme2()
        {
            var varificarFilme = MelhoresFilmes.Contains("A Lagoa Azul");
            Console.WriteLine("O filme Lanterna verde existe na lista " + varificarFilme);
        }
        //k. Alterar o filme "Titanic" para “Titanic 2”;
        //l. Listar os filmes armazenados na lista;
        //m. Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário

    }
}
