using Entra21.BancoDadoCidades.Ado.Net.DataBase;
using Entra21.BancoDadoCidades.Ado.Net.Models;
using System.Data;

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
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT 
c.id AS 'id',
c.nome AS 'nome',
c.quantidade_habitante AS 'quantidade_habitante',
c.pib AS 'pib',
c.data_hora_fundacao AS 'data_hora_fundacao',
uf.id AS 'unidade_federativa_id',
uf.nome AS 'unidade_federativa_nome',
uf.sigla AS 'unidade_federativa_silga'
FROM cidades AS c 
INNER JOIN unidades_federativas AS uf ON(c.id_unidade_federativa = uf.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var cidades = new List<Cidade>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var cidade = new Cidade();
                cidade.UnidadeFederativa = new UnidadeFederativa();

                cidade.Id = Convert.ToInt32(registro["id"]);
                cidade.Nome = registro["nome"].ToString();
                cidade.QuantidadeHabitante = Convert.ToInt32(registro["quantidade_habitante"]);
                cidade.Pib = Convert.ToDouble(registro["pib"]);
                cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
                cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["unidade_federativa_id"]);
                cidade.UnidadeFederativa.Nome = registro["unidade_federativa_nome"].ToString(); 
                cidade.UnidadeFederativa.Sigla = registro["unidade_federativa_sigla"].ToString();
                
                cidades.Add(cidade);
            }
            comando.Connection.Close();

            return cidades;
        }

        public Cidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, quantidade_habitante, pib, data_hora_fundacao, id_unidade_federativa FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var cidade = new Cidade();
            cidade.Id = Convert.ToInt32(registro["id"]);
            cidade.Nome = registro["nome"].ToString();
            cidade.QuantidadeHabitante = Convert.ToInt32(registro["quantidade_habitante"]);
            cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            comando.Connection.Close();
            return cidade;

        }
    }
}
