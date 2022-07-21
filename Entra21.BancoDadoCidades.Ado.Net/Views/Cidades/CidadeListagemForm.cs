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
        public CidadeListagemForm()
        {
            InitializeComponent();

            PreencherDaraGredViewCidade();
        }

        private void PreencherDaraGredViewCidade()
        {
            // ----- var 
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
