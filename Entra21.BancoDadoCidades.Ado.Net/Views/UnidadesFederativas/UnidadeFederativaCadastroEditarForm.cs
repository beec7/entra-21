using Entra21.BancoDadoCidades.Ado.Net.Models;
using Entra21.BancoDadoCidades.Ado.Net.Services;

namespace Entra21.BancoDadoCidades.Ado.Net.Views.UnidadesFederativas
{
    public partial class UnidadeFederativaCadastroEditarForm : Form
    {
        private readonly int _idParaEditar;
        public UnidadeFederativaCadastroEditarForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }
        public UnidadeFederativaCadastroEditarForm(UnidadeFederativa unidadeFederativa) : this()
        {
            _idParaEditar = unidadeFederativa.Id;
            textBoxNomeEstado.Text = unidadeFederativa.Nome;
            maskedTextBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void maskedTextBoxSigla_Leave(object sender, EventArgs e)
        {
            maskedTextBoxSigla.Text = maskedTextBoxSigla.Text.ToUpper();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                var nome = textBoxNomeEstado.Text.Trim();
                var sigla = maskedTextBoxSigla.Text;

                var unidadeFederativa = new UnidadeFederativa();
                unidadeFederativa.Nome = nome;
                unidadeFederativa.Sigla = sigla;

                var unidadeFederativaService = new UnidadeFederativaService();

                if (_idParaEditar == -1)
                {
                    unidadeFederativaService.Cadastrar(unidadeFederativa);
                    MessageBox.Show("Salvo com sucesso");
                    Close();

                }
                else
                {
                    unidadeFederativa.Id = _idParaEditar;
                    unidadeFederativaService.Editar(unidadeFederativa);
                    MessageBox.Show("Editado com sucesso");
                    Close();

                }

            }
        }

        private bool Validar()
        {
            try
            {
                if (textBoxNomeEstado.TextLength <= 2  )
                {
                    MessageBox.Show("Preencha o nome do estado");
                    return false;
                }
                else if (textBoxNomeEstado.TextLength > 50)
                {
                    MessageBox.Show("Preencha o nome do estado \nNão pode conter mais do que 50 carácter");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erron\n " + ex);
                return false;
            }

            try
            {
                if (maskedTextBoxSigla.Text.Length != 2)
                {
                    MessageBox.Show("Preencha a sigla");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erron\n " + ex);
                return false;
            }

            return true;
        }
    }
}
