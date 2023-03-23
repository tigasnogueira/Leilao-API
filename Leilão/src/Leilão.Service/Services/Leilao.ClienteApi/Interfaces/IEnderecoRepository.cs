using Leilao.ClienteBusiness.Models;
using Leilao.Intefaces;

namespace Leilao.ClienteApi.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorCliente(Guid fornecedorId);
    }
}
