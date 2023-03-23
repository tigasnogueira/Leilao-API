using Leilao.ClienteBusiness.Models;

namespace Leilao.ClienteApi.Interfaces
{
    public interface IContatoService : IDisposable
    {
        Task Adicionar(Contato contato);
        Task Atualizar(Contato contato);
        Task Remover(Guid id);
    }
}
