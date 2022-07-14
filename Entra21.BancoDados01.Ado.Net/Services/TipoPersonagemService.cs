using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    //Dois pontos seguindo de uma interface, quer dizer que a classe
    //Será obrigada a implementar os metodos(Contratos) estabelecidos 
    //na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Sera descrito a implamentacao do contrato definido na interface 

            //Instrnciado um objeto da classe SqlConnection, que permitera fazer selects, inserts, updates, deletes, etc.

            SqlConnection conexao = new SqlConnection();

            //String que contem o caminho para o banco de dados, o que permitira conectar ao banco de dados
            var connectionString = @""; 

            //Definir o caminho da conexao para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexao com o banco de dados
            conexao.Open();

        }
    }
}
