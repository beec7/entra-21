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
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
            dataGridViewEnderecos.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informacoes preenchido pelo usuario armazendando em variaveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciete = Convert.ToString(comboBoxPaciente.SelectedItem);

            //Executa o método ValidarDados que retornará um bool
            //Sendo true quando os dados forem válidos
            //false quando os dados forem invalidos
            var dadosValidos = ValidarDados(cep, enderecoCompleto, nomePaciete);

            // Verifica se os dados são invalidos para n dar continuidade no cadastro do endereço
            if (dadosValidos == false)
            {
                return;
            }

            // Verificar senao esta em de edicao, ou modo de cadastro
            if (dataGridViewEnderecos.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, nomePaciete);
            else
                EditarEndereco(cep, enderecoCompleto, nomePaciete);
            

            //Apresentar o registro novo na DataGridView
            PreencherDataGridViewComEnderecos();

            LimparCampos();

        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciete)
        {
            //Obter a linha selecionada 
            var linhaSelecionada = dataGridViewEnderecos.SelectedRows[0];
            //Obter o codigo que esta na coluna oculta do DataGridView
            var codigoSelecionada = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionada;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciete);

            // Atualizar o dado na lista de enderecos e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string? nomePaciete)
        {
            //Costruir o objeto de endereco com as variaves
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciete);

            //Salvar este endereco na lista de enderecos
            enderecoServico.Adicionar(endereco);
        }

        private void PreencherDataGridViewComEnderecos()
        {
            //Obter todos os enderecos da lista de enderecos
            var enderecos = enderecoServico.ObterTodos();

            //Remover todas os enderecos da lista de enderecos
            dataGridViewEnderecos.Rows.Clear();

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
            //Retira a selecao das celulas;
            dataGridViewEnderecos.ClearSelection();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            //valida cep
            if (cep.Length != 8)
                return;

            // HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisicao para o site Viacep para obter os dados do endereco do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json").Result;

            // Verifica se a requisicao deu certo

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // obter a resposta da requisicao
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadoEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadoEndereco.Uf} - {dadoEndereco.Localidade} - {dadoEndereco.Bairro} - { dadoEndereco.Logradouro}";
            }

        }

        // Se executado este metodo quando o usuario sair do campo do cep 
        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido");
                
                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }
            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um  paciente");

                comboBoxPaciente.DroppedDown = true; 

                return false;
            }
            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

            //Verificar se algum item do DataGridView esta selecionado
            if (dataGridViewEnderecos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            //Questionar se o usuario realmente desaja apagar
            var resposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso",
                MessageBoxButtons.YesNo);
            
            //Valida que o usuario nao escolheu sim
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa teu registro ta ali salvo");

                return;
            }

            //Qual item sera apagado
            var linhaSelecionada = dataGridViewEnderecos.SelectedRows[0];

            //Obtem o indice que o usuario selecionou para apagar
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //X Apagar o item da lista de itens no serviço
            //X Atualizar o arquivo Json
            //busca o endereco da lista de enderecos filtrado por codigo
            var endereco = enderecoServico.ObterPorCodigo(codigo);
            //Apagar o endereco encontrado de enderecos filtrando por codigo e atualiza o arquivo JSON
            enderecoServico.Apagar(endereco);

            //Atualizar o DataGridView
            PreencherDataGridViewComEnderecos();

            //Remover a seleção do DataGridView
            dataGridViewEnderecos.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridViewEnderecos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }

            //Obter a linha que o usuari selecionou
            var linhaSelecionada = dataGridViewEnderecos.SelectedRows[0];
            //Obter o codigo do endereco que o usuario selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            // Obtem o endereco escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            //Apresentar os dados do endereco na tela para editar
            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPaciente.SelectedItem = endereco.Paciente.Nome;
        }

        //Quando o dformulario é carregado apresenta os dados no DataGridView
        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void dataGridViewEnderecos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
    }
}
