using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;

        public TipoPersonagemListagemForm()
        {
            InitializeComponent();
            // Instancia o objeto da classe TipoPersonagemServico para permitir
            // - listar todos - editar - apagar

            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEditarFroms = new TipoPersonagemCadastroEdicaoForms();

            tipoPersonagemCadastroEditarFroms.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            //Obter todos os tipos de personagens cadastrado na tela tipos_personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // removido todos os registros do dataGridView1
            dataGridView1.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para 
            // adicionar no DataGridView permitindo o usuário visualiza-los
            for (var i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.Id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado");

        }

        private void Editar()
        {


            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum tipo de personagem");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var tipoPersonagem = tipoPersonagemService.ObterPorId(id);

            // Instanciado Objeto do from para permitir edicao passando o tipo personagem, que permitira preencher os campos com os dados do banco de dados
            var tipoPersonagemForm = new TipoPersonagemCadastroEdicaoForms(tipoPersonagem);

            tipoPersonagemForm.ShowDialog();

            AtualizarRegistrosDataGridView();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}
