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

namespace Entra21.BancoDadoCidades.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        private readonly CidadeService _cidadeService;
        public CidadeListagemForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();

            PreencherDaraGredViewCidade();
        }

        private void PreencherDaraGredViewCidade()
        {
            var cidades = _cidadeService.ObterTodos();

            dataGridViewCidades.Rows.Clear();

            for (int i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];

                dataGridViewCidades.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.QuantidadeHabitante,
                    cidade.DataHoraFundacao,
                    cidade.Pib,
                    cidade.UnidadeFederativa.Id,
                    cidade.UnidadeFederativa.Nome,
                    cidade.UnidadeFederativa.Sigla,
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cidadeCadastroEditarForm = new CidadeCadastroEditarForm();
            cidadeCadastroEditarForm.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }


    }
}
