using Localiza.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Localiza.Infra.Contexto.Configuration
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            //Configurações de propriedade

            builder.HasKey(v => v.VeiculoId);

            builder.Property(v => v.Placa)
                   .HasColumnType("varchar(20)");
        }
    }
}
