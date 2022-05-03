using Localiza.Domain.Enuns;
using Localiza.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localiza.Domain.Models
{
    public class Modelo : BaseModel
    {
        public long ModeloId { get; }

        [ForeignKey("FabricanteId")]
        public long FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
        [Required]
        public string Nome { get; set; }
        public TipoVeiculo Tipo { get; set; }
    }
}
