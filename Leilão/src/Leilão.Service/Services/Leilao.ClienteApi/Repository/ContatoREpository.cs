using Leilao.ClienteApi.Context;
using Leilao.ClienteApi.Interfaces;
using Leilao.ClienteBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace Leilao.ClienteApi.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public ContatoRepository(ClienteDbContext context) : base(context) { }
        public async Task<Contato> ObterContatoPorCliente(Guid clienteId)
        {
            return await Db.Contatos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.ClienteId == clienteId);
        }
    }
}
