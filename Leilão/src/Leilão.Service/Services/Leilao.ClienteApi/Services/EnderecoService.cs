using Leilao.ClienteApi.Interfaces;
using Leilao.ClienteBusiness.Models;

namespace Leilao.ClienteApi.Services
{
    public class EnderecoService : IEnderecoService
    {
        IEnderecoService _enderecoService;
        public Task Adicionar(Endereco endereco)
        {
            return _enderecoService.Adicionar(endereco);
        }

        public Task Atualizar(Endereco endereco)
        {
            return _enderecoService.Atualizar(endereco);
        }

        public void Dispose()
        {
            _enderecoService?.Dispose();
        }

        public Task Remover(Guid id)
        {
            return _enderecoService.Remover(id);
        }
    }
}
