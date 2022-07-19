using Entra21.BancoDadoCidades.Ado.Net.Models;

namespace Entra21.BancoDadoCidades.Ado.Net.Services
{
    internal interface IUnidadeFederativaService
    {
        void Cadastrar(UnidadeFederativa unidadeFederativa);

        void Apagar(int id);
        
        void Editar(UnidadeFederativa unidadeFederativa);

        List<UnidadeFederativa> ObterTodos();

        UnidadeFederativa ObterPorId(int id);


    }
}