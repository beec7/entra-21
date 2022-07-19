using Entra21.BancoDadoCidades.Ado.Net.Models;

namespace Entra21.BancoDadoCidades.Ado.Net.Services
{
    internal interface ICidadeService
    {
        void Cadastrar(Cidade cidade);

        void Editar(Cidade cidade);

        void Apagar(int id);

        List<Cidade> ObterTodos();

        Cidade ObterPorId(int id); 
            
    }
}