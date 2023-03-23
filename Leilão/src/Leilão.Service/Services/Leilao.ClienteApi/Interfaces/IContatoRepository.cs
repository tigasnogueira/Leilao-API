using Leilao.ClienteBusiness.Models;
using Leilao.Intefaces;

namespace Leilao.ClienteApi.Interfaces
{
    public interface IContatoRepository : IRepository<Contato>
    {
        Task<Contato> ObterContatoPorCliente(Guid clienteId);
    }
}
