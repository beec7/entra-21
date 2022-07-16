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

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemCadastroEditarForm : Form
    {
        public PersonagemCadastroEditarForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoPersonagem();
            //PreencherComboBoxEditora();

        }

        private void PersonagemCadastroEditarForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma editora");
                return;
            }
            
            if (comboBoxTipoPersonagem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de personagem");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var tipoPersonagem = comboBoxTipoPersonagem.SelectedItem as TipoPersonagem;
            var editora = comboBoxEditora.SelectedItem as Editora;

            var personagem = new Personagem();
            personagem.Nome = nome;
            personagem.TipoPersonagem = tipoPersonagem;
            personagem.Editora = editora;

            var personagemService = new PersonagemService();
            personagemService.Cadastrar(personagem);

            MessageBox.Show("Salva com sucesso");
            
            Close();

        }

        private void PreencherComboBoxTipoPersonagem()
        {
            var tipoPersonagemService = new TipoPersonagemService();
            var tipoPersonagens = tipoPersonagemService.ObterTodos();

            for (int i = 0; i < tipoPersonagens.Count; i++)
            {
                var tipoPersonagem = tipoPersonagens[i];
                comboBoxTipoPersonagem.Items.Add(tipoPersonagem);
            }
        }

        private void PreencherComboBoxEditora()
        {
            var editoraService = new EditoraService();
            var editoras = editoraService.ObterTodos();

            for (int i = 0; i < editoras.Count; i++)
            {
                var editora = editoras[i];
                comboBoxEditora.Items.Add(editora);
            }
        }
    }
}
