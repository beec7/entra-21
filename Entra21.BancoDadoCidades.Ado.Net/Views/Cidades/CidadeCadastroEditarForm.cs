using Entra21.BancoDadoCidades.Ado.Net.Models;
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
    public partial class CidadeCadastroEditarForm : Form
    {
        private readonly int _IdParaEditar;
        private readonly CidadeService _cidadeService;
        private readonly UnidadeFederativaService _unidadeFederativaService;

        public CidadeCadastroEditarForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();
            _unidadeFederativaService = new UnidadeFederativaService();

            PreencherComboBoxUnidadeFederativa();
            
            _IdParaEditar = -1;
        }

        public CidadeCadastroEditarForm(Cidade cidade) : this()
        {
            _IdParaEditar = cidade.Id;
            textBoxCidade.Text = cidade.Nome;
            dateTimePickerDataFundacao.Value = cidade.DataHoraFundacao;
            maskedTextBoxHoraFundacao.Text = cidade.DataHoraFundacao.ToString("hh:mm");
            textBoxPib.Text = cidade.Pib.ToString();
            numericUpDownQuantidadeHabitante.Text = cidade.QuantidadeHabitante.ToString();

            for (int i = 0; i < comboBoxUnidadeFederativa.Items.Count; i++)
            {
                var unidadeFederativaPercorrido = comboBoxUnidadeFederativa.Items[i] as UnidadeFederativa;

                if (unidadeFederativaPercorrido.Id == cidade.UnidadeFederativa.Id)
                {
                    comboBoxUnidadeFederativa.SelectedItem = unidadeFederativaPercorrido;
                    break;
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void PreencherComboBoxUnidadeFederativa()
        {
            var unidadesFederativas = _unidadeFederativaService.ObterTodos();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];
                comboBoxUnidadeFederativa.Items.Add(unidadeFederativa);
            }
        }

    }
}
