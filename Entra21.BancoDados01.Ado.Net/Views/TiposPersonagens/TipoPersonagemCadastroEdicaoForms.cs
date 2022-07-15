using Entra21.BancoDados01.Ado.Net.Models;
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
    public partial class TipoPersonagemCadastroEdicaoForms : Form
    {
        private int idEdicao = -1;

        public TipoPersonagemCadastroEdicaoForms()
        {
            InitializeComponent();
        }

        public TipoPersonagemCadastroEdicaoForms(TipoPersonagem tipoPersonagem) : this()
        {
            //definir o valor do idEditar
            idEdicao = tipoPersonagem.Id;

            //Preenche o campo tipo com o valor no banco de dados
            textBoxTipo.Text = tipoPersonagem.Tipo;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var tipo = textBoxTipo.Text.Trim();

            var tipoPersonagem = new TipoPersonagem();
            tipoPersonagem.Tipo = tipo;

            //Instancia do objeto de TipoPersonagemService que permitira
            //Persistir o registro
            var tipoPersonagemService = new TipoPersonagemService();

            if (idEdicao == -1)
            {
                // Persistir a informacao na tabela de tipos_personagens
                tipoPersonagemService.Cadastrar(tipoPersonagem);

                MessageBox.Show("Salvo");

                Close();

                return;
            }
            tipoPersonagem.Id = idEdicao;

            tipoPersonagemService.Editar(tipoPersonagem);

            MessageBox.Show("Tipo de personagem alterado com sucesso!!");

            Close();

        }
    }
}
