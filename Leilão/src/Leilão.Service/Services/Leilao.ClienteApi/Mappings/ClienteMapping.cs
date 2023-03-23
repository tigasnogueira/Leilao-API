using Leilao.ClienteBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leilao.ClienteApi.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(p => p.Id);

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Cliente);

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Contato)
                .WithOne(e => e.Cliente);

            builder.ToTable("Clientes");
        }
    }
}
