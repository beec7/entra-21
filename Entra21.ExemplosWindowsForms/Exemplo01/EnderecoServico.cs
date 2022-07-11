using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;
     
        //Construtor: mais para frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();

            LerArquivo();
        }

        // Metodo adicionar recebe como parametro o objeto de endereco completo do Form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarAquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            //percorre a lista de enderecos afim de encotrar o endereco que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // obtem o endereco da lista de endereco
                var endereco = enderecos[i];

                //Verifica se eh o codigo do endereco para alterar
                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    //Atualiza campos de endereco encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarAquivo();

                    return;
                }

            }

        }

        // metodos para remover um endereco
        public void Apagar(Endereco enderecoParaApagar)
        {
            for (int i = 0; i < enderecos.Count; i++)
            {

                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoParaApagar.Codigo)
                {
                    enderecos.Remove(endereco);

                    SalvarAquivo();

                    return;
                }
            }
        }

        public void SalvarAquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json",enderecosEmJson);
        }

        public void LerArquivo()
        {
            // www.invertexto.com/fsens
            // verifica se o endereco nao exite
            if (File.Exists("enderecos.json") == false)
                return;

            // ler o aquivo json e converte para uma lista de objetos de enderecos
            var enderecosEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);
        }
        
        // metodos que permite listar todos os enderecos
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                // Verifica se o endereco contem o codigo desejado
                if (endereco.Codigo == codigo)
                    return endereco;
                
            }

            // Retorna null pois nao encontrou o endereco com o codigo desejado
            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                ultimoCodigo = endereco.Codigo;
            }

            return ultimoCodigo;
        }


    }
}
