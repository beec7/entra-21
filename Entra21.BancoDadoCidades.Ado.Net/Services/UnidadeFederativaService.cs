using Entra21.BancoDadoCidades.Ado.Net.DataBase;
using Entra21.BancoDadoCidades.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDadoCidades.Ado.Net.Services
{
    internal class UnidadeFederativaService : IUnidadeFederativaService
    {
        public void Cadastrar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO unidades_federativas(nome, sigla) VALUES (@NOME, @SIGLA);";

            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE unidades_federativas SET nome = @NOME , sigla = @SIGLA WHERE id = @ID;";

            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);
            comando.Parameters.AddWithValue("@ID", unidadeFederativa.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();

        }

        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"DELETE FROM unidades_federativas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);
        }

        public List<UnidadeFederativa> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, nome, sigla FROM unidades_federativas";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var unidadesFederativas = new List<UnidadeFederativa>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var unidadeFederativa = new UnidadeFederativa();
                unidadeFederativa.Id = Convert.ToInt32(registro["id"]);
                unidadeFederativa.Nome = registro["nome"].ToString();
                unidadeFederativa.Sigla = registro["sigla"].ToString();

                unidadesFederativas.Add(unidadeFederativa);
            }

            comando.Connection.Close();

            return unidadesFederativas;
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var unidadeFederativa =new UnidadeFederativa();

            unidadeFederativa.Id = Convert.ToInt32(registro["id"]);
            unidadeFederativa.Nome = registro["nome"].ToString();
            unidadeFederativa.Sigla = registro["sigla"].ToString();

            comando.Connection.Close();

            return unidadeFederativa;
        }

    }
}
