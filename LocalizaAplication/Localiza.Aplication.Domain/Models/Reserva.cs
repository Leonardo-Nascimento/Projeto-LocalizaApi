using Localiza.Domain.Enuns;
using Localiza.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localiza.Domain.Models
{
    public class Reserva : BaseModel
    {
        public readonly long ReservaId;

        [ForeignKey("ClienteId")]
        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("VeiculoId")]
        public long VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

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

    }
}
