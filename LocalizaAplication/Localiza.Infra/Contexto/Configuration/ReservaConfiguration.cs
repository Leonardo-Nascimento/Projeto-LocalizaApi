using Localiza.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Localiza.Infra.Contexto.Configuration
{
    public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            //Configurações de propriedade

            builder.HasKey(r => r.ReservaId);

            builder.Property(r => r.StatusReserva)
                   .HasColumnType("tinyint");

        }
    }
}
