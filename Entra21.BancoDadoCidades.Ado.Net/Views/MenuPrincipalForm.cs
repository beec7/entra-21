using Entra21.BancoDadoCidades.Ado.Net.Views.UnidadesFederativas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDadoCidades.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUnidadeFederativa_Click(object sender, EventArgs e)
        {
            var unidadeFederativaListagemForm = new UnidadeFederativaListagemForm();
            unidadeFederativaListagemForm.ShowDialog();
        }
    }
}
