using Leilao.ClienteBusiness.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Leilao.ClienteApi.Mappings
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Contatos");
        }
    }
    
    
}

