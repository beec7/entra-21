using Entra21.BancoDadoCidades.Ado.Net.DataBase;
using Entra21.BancoDadoCidades.Ado.Net.Models;

namespace Entra21.BancoDadoCidades.Ado.Net.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO cidades(nome, quantidade_habitante, pib, data_hora_fundacao, id_unidade_federativa) VALUES (@NOME, @QUANTIDADE_HABITANTE, @PIB, @DATA_HORA_FUNDACAO, @ID_UNIDADE_FERERATIVA)";
            comando.Parameters.AddWithValue("@nome", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTE", cidade.QuantidadeHabitante);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@ID_UNIDADE_FERERATIVA", cidade.UnidadeFederativa.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        
        }

        public void Editar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE cidades SET nome = @NOME, quantidade_habitante = @QUANTIDADE_HABITANTE, pib = @PIB, data_hora_fundacao = @DATA_HORA_FUNDACAO, id_unidade_federativa = @ID_UNIDADE_FERERATIVA WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", cidade.Id);
            comando.Parameters.AddWithValue("@nome", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTE", cidade.QuantidadeHabitante);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@ID_UNIDADE_FERERATIVA", cidade.UnidadeFederativa.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"DELETE FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();

        }

        public List<Cidade> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Cidade ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

    }
}
