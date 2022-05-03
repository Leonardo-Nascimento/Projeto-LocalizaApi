using Localiza.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Localiza.Infra.Contexto.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //Configurações de propriedade

            builder.HasKey(c => c.ClienteId);

            builder.Property(c => c.CPF)
                   .HasColumnType("varchar(11)");

        }

    }
}
