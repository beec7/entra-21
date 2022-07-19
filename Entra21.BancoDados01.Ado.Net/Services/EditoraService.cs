using Entra21.BancoDados01.Ado.Net.BancoDados;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class EditoraService : IEditoraService
    {
        public List<Editora> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, apelido, data_criacao, faturamento FROM editoras";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var editoras = new List<Editora>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var editor =new Editora();
                editor.Id = Convert.ToInt32(linha["id"]);
                editor.Nome = linha["nome"].ToString();
                editor.Apelido = linha["apelido"].ToString();
                editor.DataCriacao = Convert.ToDateTime(linha["data_criacao"]);
                editor.Faturamento = Convert.ToDecimal(linha["faturamento"]);

                editoras.Add(editor);

            }

            // Fecha a conexão
            conexao.Close();

            return editoras;
        }


    }
}
