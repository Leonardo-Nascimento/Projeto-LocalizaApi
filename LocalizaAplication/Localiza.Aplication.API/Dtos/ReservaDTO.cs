using Localiza.Domain.Enuns;
using System.ComponentModel.DataAnnotations;

namespace Localiza.WebAPI.Dtos
{
    public class ReservaDTO
    {
        public long? ClienteId { get; set; }

        public long? VeiculoId { get; set; }

        [Required]
        public StatusReserva StatusReserva { get; set; }
        [Required]
        public DateTime DataRetirada { get; set; }
        [Required]
        public string HoraRetirada { get; set; }
        [Required]
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataDevolução { get; set; }
        public string? HoraDevolução { get; set; }
        public DateTime? DataCriacao { get; set; }

    }
}
