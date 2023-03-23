using Leilao.ClienteBusiness.Models;

namespace Leilao.ClienteApi.Interfaces
{
    public interface IEnderecoService : IDisposable
    {
        Task Adicionar(Endereco endereco);
        Task Atualizar(Endereco endereco);
        Task Remover(Guid id);
    }
}
