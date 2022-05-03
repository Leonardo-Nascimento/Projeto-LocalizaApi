using Localiza.Domain.Enuns;
using Localiza.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localiza.Domain.Models
{
    public class Veiculo : BaseModel
    {
        public long VeiculoId { get; }

        [ForeignKey("FabricanteId")]
        public long FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }

        [ForeignKey("ModeloId")]
        public long ModeloId { get; set; }
        public Modelo Modelo { get; set; }

        [Required]
        public string Placa { get; set; }
        [Required]
        public StatusVeiculo Status { get; set; }
        public IEnumerable<Reserva> Reserva { get; set; }

    }
}
