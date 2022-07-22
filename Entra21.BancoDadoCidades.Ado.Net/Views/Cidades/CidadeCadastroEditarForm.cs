using Entra21.BancoDadoCidades.Ado.Net.Models;
using Entra21.BancoDadoCidades.Ado.Net.Services;

namespace Entra21.BancoDadoCidades.Ado.Net.Views.Cidades
{
    public partial class CidadeCadastroEditarForm : Form
    {
        private readonly int _idParaEditar;
        private readonly CidadeService _cidadeService;
        private readonly UnidadeFederativaService _unidadeFederativaService;

        public CidadeCadastroEditarForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();
            _unidadeFederativaService = new UnidadeFederativaService();

            PreencherComboBoxUnidadeFederativa();
            
            _idParaEditar = -1;
        }

        public CidadeCadastroEditarForm(Cidade cidade) : this()
        {
            _idParaEditar = cidade.Id;
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

        private void buttonSalvar_Click(object sender, EventArgs e)// TODO: Ajustar hora
        {
            if (Validar() == true)
            {
                var cidade = new Cidade();
                cidade.Nome = textBoxCidade.Text.Trim();
                cidade.QuantidadeHabitante = Convert.ToInt32(numericUpDownQuantidadeHabitante.Value);
                cidade.Pib = Convert.ToDouble(textBoxPib.Text);
                cidade.UnidadeFederativa = comboBoxUnidadeFederativa.SelectedItem as UnidadeFederativa;
                cidade.DataHoraFundacao = dateTimePickerDataFundacao.Value.Date + TimeSpan.Parse(maskedTextBoxHoraFundacao.Text);

                if (_idParaEditar == -1)
                {
                    _cidadeService.Cadastrar(cidade);
                    MessageBox.Show("Salvo com sucesso");
                    Close();
                }
                else
                {
                    cidade.Id = _idParaEditar;
                    _cidadeService.Editar(cidade);
                    MessageBox.Show("Salvo com sucesso");
                    Close();
                }

            }
        }

        private bool Validar()
        {
            if (comboBoxUnidadeFederativa.SelectedIndex == -1)
            {
                MessageBox.Show("Unidade Federativa não foi selecionado");
                return false;
            }
            if (dateTimePickerDataFundacao.Value > DateTime.Today)
            {
                MessageBox.Show("A data não pode ser maio do que a data atual");
                return false;
            }
            if (textBoxCidade.Text.Length < 2)
            {
                MessageBox.Show("O nome da cidade n");
                return false;
            }

            return true;
        }
    }
}
