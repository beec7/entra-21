using System.Data.SqlClient;

namespace Entra21.BancoDadoCidades.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();
            //var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leonardo\source\repos\leonardopokreweckysalvador\entra-21\sqlEntra21ExemploSQL\Entra21UnidadeFederativaCidade.mdf;Integrated Security=True;Connect Timeout=30";
            //conexao.ConnectionString = connectionString;

            var nomeBanco = "BancoDados";
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\Database\{nomeBanco}.mdf;Integrated Security=True";

            conexao.Open();
            return conexao;
        }
    }
}
