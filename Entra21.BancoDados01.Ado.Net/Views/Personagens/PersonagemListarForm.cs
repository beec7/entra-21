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

    public partial class PersonagemListarForm : Form
    {
        //Definindo como readonly será permitido a criação da instancia somente no construtor
        private readonly PersonagemService _personagemService;// READONLY sempre vai _
        
        // Aqui fica o construtor; tem como objetivo construir o objeto como propriedades necessarias e execução do métodos obreigatorios,
        // ou seja, neste cenário desenhar a tale e instanciar o objeto do serviço que permitira gerenciar os dados referente ao personagem

        public PersonagemListarForm()
        {
            InitializeComponent();

            _personagemService = new PersonagemService();

            PreencherDataGridViewComPersonagens();
        }

        private void PreencherDataGridViewComPersonagens()
        {
            var personagens = _personagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < personagens.Count; i++)
            {
                var personagem = personagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    personagem.Id,
                    personagem.Nome,
                    personagem.TipoPersonagem.Tipo,
                    personagem.Editora.Nome
                });


            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var personagensForm = new PersonagemCadastroEditarForm();
            personagensForm.ShowDialog();

            PreencherDataGridViewComPersonagens();
        }
    }
}
