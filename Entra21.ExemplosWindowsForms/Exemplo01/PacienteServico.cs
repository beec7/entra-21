using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class PacienteServico
    {
        private List<Paciente> pacientes;

        public PacienteServico()
        {
            pacientes = new List<Paciente>();

            LerArquivos();
        }

        // Metodo que expoe a lista de pacientes que tem o encapsulamento privado
        public List<Paciente> ObterTodos()
        {
            return pacientes;
        }

        public Paciente ObterPorNomePaciente(string nomePaciente)
        {
            // Percorrer a lista de pacientes para encontrar o pacente por nome
            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obter o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //verificar se o paciente atual contem o nome do paciente escolhido
                if (paciente.Nome == nomePaciente)
                    return paciente;

            }

            // Retorna null quanto não encontrar nenhum paciente com o nome do paciente encolhido
            return null;
        }

        private void LerArquivos()
        {
            //Verificar so o nao aquivo existe
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler aqeuivo JSON com a lista de pacientes
            var pacientesJson = File.ReadAllText("pacientes.json");

            //Converte JSON para lista de objetos de pacientes
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(pacientesJson);

        }
    }
}
