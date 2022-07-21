using Entra21.BancoDadoCidades.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDadoCidades.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaListagemForm : Form
    {
        private readonly UnidadeFederativaService _unidadeFederativaService;
        public UnidadeFederativaListagemForm()
        {
            InitializeComponent();

            _unidadeFederativaService = new UnidadeFederativaService();

            PreencherDataGridViewUnidadeFederativa();
        }

        private void PreencherDataGridViewUnidadeFederativa()
        {
            var unidadesFederativas = _unidadeFederativaService.ObterTodos();

            dataGridViewUnidadeFederativa.Rows.Clear();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridViewUnidadeFederativa.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadeFederativaCadastroEditarForm = new UnidadeFederativaCadastroEditarForm();
            unidadeFederativaCadastroEditarForm.ShowDialog();

            PreencherDataGridViewUnidadeFederativa();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnidadeFederativa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma unidade Federativa");
                return;
            }

            var linhaSelecionada = dataGridViewUnidadeFederativa.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells["ColumnId"].Value);
            var resposta = MessageBox.Show("Deseja realmente apagar esta unidade federativa", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Unidade Federativa não foi APAGADA");
                PreencherDataGridViewUnidadeFederativa();

                return;
            }

            _unidadeFederativaService.Apagar(id);
            MessageBox.Show("Registro removido");

            PreencherDataGridViewUnidadeFederativa();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnidadeFederativa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma unidade Federativa");
                return;
            }

            var linhaSelecionada = dataGridViewUnidadeFederativa.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells["ColumnId"].Value);

            var unidadeFederativa = _unidadeFederativaService.ObterPorId(id);

            var unidadeFederativaCadastroEditarForm = new UnidadeFederativaCadastroEditarForm(unidadeFederativa);
            unidadeFederativaCadastroEditarForm.ShowDialog();

            PreencherDataGridViewUnidadeFederativa();
        }
    }
}
