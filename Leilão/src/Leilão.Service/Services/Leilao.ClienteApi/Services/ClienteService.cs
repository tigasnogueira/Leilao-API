using Leilao.ClienteBusiness.Interfaces;
using Leilao.ClienteBusiness.Models;

namespace Leilao.ClienteApi.Services
{
    public class ClienteService : IClienteService
    {
        public readonly IClienteRepository clienteRepository;
        public Task Adicionar(ClienteModel cliente)
        {
            return clienteRepository.Adicionar(cliente);
        }

        public Task Atualizar(ClienteModel cliente)
        {
            return clienteRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            clienteRepository?.Dispose();
        }

        public Task Remover(Guid id)
        {
            return clienteRepository.Remover(id);
        }
    }
}
