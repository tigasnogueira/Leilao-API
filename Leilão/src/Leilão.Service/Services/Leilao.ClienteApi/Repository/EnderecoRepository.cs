using Leilao.ClienteApi.Context;
using Leilao.ClienteApi.Interfaces;
using Leilao.ClienteBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace Leilao.ClienteApi.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ClienteDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorCliente(Guid clienteId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.ClienteId == clienteId);
        }
    }
}
