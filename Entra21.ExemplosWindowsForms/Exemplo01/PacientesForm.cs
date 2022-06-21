using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigoAtual = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
            // cria uma lisya de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            // ler do aquivo json os pacientes cadastrados anteriormente
            LerAquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //obter as informacoes dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            var imc = CalcularImc(peso, altura);

            // verifica se esta em modo de adicao
            if (indiceLinhaSelecionada == -1)
            {
                dataGridView1.Rows.Add(new object[]{
                ++codigoAtual,nome,altura,peso,imc
            });
                AdicionarPacienteSalvandoNoArquivo(codigoAtual, nome, altura, peso);

                return;
            }

            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

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
                var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Cells[1].ColumnIndex;

                // remove a linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);

                //Remove o paciente da lista de pacientes
                pacientes.RemoveAt(indiceLinhaSelecionada);

                // atualiza o aquivo com lista de pacientes sem o paciente removido
                SalvarEmAquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double altura, double peso)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Alutera = altura;
            pacientes[indiceLinhaSelecionada].Peso = peso;

            SalvarEmAquivo();

            LimparCampos();

        }

        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double altura, double peso)
        {
            var paciente = new Paciente()
            {
                Codigo = codigo,
                Nome = nome,
                Alutera = altura,
                Peso = peso
            };
            //var paciente = new Paciente();
            //paciente.Codigo = codigo;
            //paciente = paciente;
            pacientes.Add(paciente);

            SalvarEmAquivo();

            LimparCampos();
        }

        private void LerAquivoApresentandoPacientes()
        {
            //Validar se aquivo não exite, consequentemente não é necessario percorrer uma lista que não existe
            if (File.Exists("pacientes.json") == false)
            {
                return;
            }
            //ler o aquivo json e armazena os pacientes na lista
            var conteudoAquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoAquivo);

            int maiorCodigo = 0;

            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome,
                    paciente.Alutera, paciente.Peso, CalcularImc(paciente.Peso, paciente.Alutera)
                });

                if (paciente.Codigo > maiorCodigo)
                {
                    maiorCodigo = paciente.Codigo;
                }
                //Valida se consegui encontrar algum codigo, caso contrario n deve atualizar o codigo
                if (maiorCodigo != int.MinValue)
                {
                    codigoAtual = maiorCodigo;
                }
            }
        }

        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

        private void SalvarEmAquivo()
        {
            //Convert uma lista de objetos em uma string contendo o json
            var pacientesEmJsom = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            // salva a string contendo o JSON em um aquivo no formato JSON
            File.WriteAllText(caminho, pacientesEmJsom);
        }

        private void LimparCampos()
        {
            textBoxAltura.Text = "";
            textBoxNome.Text = "";
            textBoxPeso.Text = "";

            indiceLinhaSelecionada = -1;
            dataGridView1.ClearSelection();

        }
    }
}
