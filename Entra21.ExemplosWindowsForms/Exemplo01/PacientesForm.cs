using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private PacienteServico pacienteServico;


        public PacientesForm()
        {
            InitializeComponent();

            //Instanciar um Objeto do PacienteServico, que é reponsavel por gerenciar os dados dos pacientes
            pacienteServico = new PacienteServico();

            // ler do aquivo json os pacientes cadastrados anteriormente
            ListarPacientes();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //obter as informacoes dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            // verifica se esta em modo de adicao
            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarPaciente(nome, altura, peso);

                return;
            }

            EditarDados(nome, altura, peso);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Obter a quantidade de linhas que o usuario selecionou no DataGridView
            var quanteidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quanteidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja Realmente apagar ?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuario escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {

                //Obtem o codigo do paciente escolhido para apagar o registro
                var linhaSelecionado = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionado.Cells[0].Value);

                // Apaga o paciente da lista de paciente e atualiza a lista pacientes.JSON
                pacienteServico.Apagar(codigoSelecionado);

                LimparCampos();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double altura, double peso)
        {
            //Instanciar o paciente com os dados preenchidos na tela, para alterar o existente
            var paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Peso = peso;
            paciente.Alutera = altura;

            //Obter o código do registro escolhido para alterar
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            paciente.Codigo = codigo;

            // Alteraro o paciente na lista de pacientes e atualizando o aquivo JSON
            pacienteServico.Editar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void AdicionarPaciente(string nome, double altura, double peso)
        {
            var paciente = new Paciente()
            {
                Codigo = pacienteServico.ObterUltrimoCodigo() + 1,
                Nome = nome,
                Alutera = altura,
                Peso = peso
            };

            // Adicionar na lista e atualizar o arquivo JSON

            pacienteServico.Cadastrar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void ListarPacientes()
        {

            //Obter a lista dos pacientes para listar para o usuario
            var pacientes = pacienteServico.ObterTodos();

            //Remover todos os itens da tabela do DataGridView, pois sera adicionado novamente
            dataGridView1.Rows.Clear();


            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo,
                    paciente.Nome,
                    paciente.Alutera,
                    paciente.Peso,
                    paciente.ObterImc()
                });
            }

            dataGridView1.ClearSelection();
        }

        private void LimparCampos()
        {
            textBoxAltura.Clear();
            textBoxNome.Text.Clone();
            textBoxPeso.Text.Clone();
            dataGridView1.ClearSelection();

        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            ListarPacientes();
        }
    }
}
