using Localiza.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Localiza.Infra.Contexto.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Configurações de propriedade

            builder.Property(e => e.EnderecoId)
                   .HasColumnName("EnderecoId");

            builder.HasKey("EnderecoId");

            builder.Property(e => e.Numero)
                   .HasColumnType("varchar(20)");

            builder.Property(e => e.Estado)
                   .HasColumnType("varchar(2)");

            builder.Property(e => e.Cidade)
                   .HasColumnType("varchar(50)");

        }

    }
}
