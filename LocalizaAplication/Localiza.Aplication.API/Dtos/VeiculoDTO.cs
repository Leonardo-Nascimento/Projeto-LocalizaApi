using Localiza.Domain.Enuns;
using System.ComponentModel.DataAnnotations;

namespace Localiza.WebAPI.Dtos
{
    public class VeiculoDTO
    {
        public long? VeiculoId { get; }
        public long? FabricanteId { get; set; }
        public long? ModeloId { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Status { get; set; }
        public DateTime? DataCriacao { get; set; }

    }
}
