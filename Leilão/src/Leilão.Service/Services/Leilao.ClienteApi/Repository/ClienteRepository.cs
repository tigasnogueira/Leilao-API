using Leilao.ClienteApi.Context;
using Leilao.ClienteBusiness.Interfaces;
using Leilao.ClienteBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace Leilao.ClienteApi.Repository
{
    public class ClienteRepository : Repository<ClienteModel>, IClienteRepository
    {
        public ClienteRepository(ClienteDbContext context) : base(context)
        {
        }

        public async Task<ClienteModel> ObterClienteContatoEndereco(Guid id)
        {
            return await Db.Clientes.AsNoTracking()
               .Include(c => c.Contato)
               .Include(c => c.Endereco)
               .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ClienteModel> ObterClienteEndereco(Guid id)
        {
            return await Db.Clientes.AsNoTracking()
               .Include(c => c.Endereco)
               .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ClienteModel> ObterContatoEndereco(Guid id)
        {
            return await Db.Clientes.AsNoTracking()
               .Include(c => c.Contato)
               .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
