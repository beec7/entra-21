using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {

        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        //Construtor: construir o objeto que esta sendo istanciado com as devidas informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            // Instanciado o objeto de pacienteServico o permitirá lista os
            // pacientes no ComboBox e decorrente disso será pessível o usúario selecionar o mesmo
            pacienteServico = new PacienteServico();


            //Dave apresentar os dados quando a tela dor carregada
            PreencherDataGridViewComEnderecos();

            // irá preencher o ComboBox(campo de Seleção) com os pacientes
            PreencherComboBoxComOsNomesDosPacientes();

            ObterDadosCep();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            //Obter lista dos pacientes, que foram cadastrados, ou seja, Armazenado no JSON
            var pacientes = pacienteServico.ObterTodos();

            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informacoes preenchido pelo usuario armazendando em variaveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciete = Convert.ToString(comboBoxPaciente.SelectedItem);

            //Costruir o objeto de endereco com as variaves
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciete);

            //Salvar este endereco na lista de enderecos
            enderecoServico.Adicionar(endereco);

            //Apresentar o registro novo na DataGridView
            PreencherDataGridViewComEnderecos();

        }
        private void PreencherDataGridViewComEnderecos()
        {
            //Obter todos os enderecos da lista de enderecos
            var enderecos = enderecoServico.ObterTodos();

            //Remover todas os enderecos da lista de enderecos
            dataGridViewEnderecos.Rows.Clear();

            //Retira a selecao das celulas;
            dataGridViewEnderecos.ClearSelection();
            //Percorrer cada um dos enderecos adicionado uma nova linha na tebela

            for (int i = 0; i < enderecos.Count; i++)
            {

                var endereco = enderecos[i];

                dataGridViewEnderecos.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-","");

            // HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisicao para o site Viacep para obter os dados do endereco do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws{cep}/json").Result;

            // Verifica se a requisicao deu certo

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // obter a resposta da requisicao
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadoEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadoEndereco.Uf} - {dadoEndereco.Localidade} - {dadoEndereco.Bairro} - { dadoEndereco.Logradouro}";
            }

        }

    }
}
