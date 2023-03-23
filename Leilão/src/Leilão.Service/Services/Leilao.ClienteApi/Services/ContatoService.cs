using Leilao.ClienteApi.Interfaces;
using Leilao.ClienteBusiness.Models;

namespace Leilao.ClienteApi.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoService _contatoService;
        public Task Adicionar(Contato contato)
        {
           return _contatoService.Adicionar(contato);
        }

        public Task Atualizar(Contato contato)
        {
            return _contatoService.Atualizar(contato);
        }

        public void Dispose()
        {
            _contatoService?.Dispose();
        }

        public Task Remover(Guid id)
        {
            return _contatoService.Remover(id);
        }
    }
}
