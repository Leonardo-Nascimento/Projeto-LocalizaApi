using Localiza.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Localiza.Domain.Models
{
    public class Fabricante : BaseModel
    {
        public long FabricanteId { get; }

        [Required]
        public string Nome { get; set; }

        public IEnumerable<Modelo> Modelo { get; set; }
    }
}
