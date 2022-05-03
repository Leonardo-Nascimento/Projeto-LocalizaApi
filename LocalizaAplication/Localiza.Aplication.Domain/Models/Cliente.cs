using Localiza.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localiza.Domain.Models
{
    public class Cliente : BaseModel
    {
        public long ClienteId { get; }

        [ForeignKey("EnderecoId")]
        public long EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string NumeroCNH { get; set; }


    }
}
