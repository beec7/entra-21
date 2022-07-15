using Entra21.BancoDados01.Ado.Net.BancoDados;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    //Dois pontos seguindo de uma interface, quer dizer que a classe
    //Será obrigada a implementar os metodos(Contratos) estabelecidos 
    //na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            // Conectar com o bd
            var conexao = new Conexao().Conectar();

            // Cria comando para executar o delete
            var comando = conexao.CreateCommand();

            // Definir o comando para apgar o rigistro
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            // Executa o comando para apgar o registro
            comando.ExecuteNonQuery();

            // fecha o bd
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Sera descrito a implamentacao do contrato definido na interface 

            // Criado cinexao com o BancoDeDados e aberta a conexao
            var conexao = new Conexao().Conectar();

             //------------------------------------------------------------------------------------------------------

            //Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            //Esqpecificado o comando que sera ececutado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ('" +
                tipoPersonagem.Tipo + "')";

            //Executado o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();

        }

        public void Editar(TipoPersonagem tipoPersonagem)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE tipos_personagens SET tipo = '" + tipoPersonagem.Tipo + "'" +" WHERE id = " + tipoPersonagem.Id;

            comando.ExecuteNonQuery();

            comando.Connection .Close(); ;
        }

        public TipoPersonagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, tipo FROM tipos_personagens WHERE id = '" + id + "'";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoPersonagem = new TipoPersonagem();

            tipoPersonagem.Id = Convert.ToInt32(primeiroRegistro[0]);

            tipoPersonagem.Tipo = primeiroRegistro[1].ToString();

            comando.Connection.Close();

            return tipoPersonagem;
        }

        public List<TipoPersonagem> ObterTodos()
        {

            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tiposPersonagens = new List<TipoPersonagem>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                
                // instancia objeto da classe tipoPersonagem
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                //Adiciona tipoPersonagem instanciado na lista 
                //de TipoPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }
            // VFechado a conexao com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }
    }
}
