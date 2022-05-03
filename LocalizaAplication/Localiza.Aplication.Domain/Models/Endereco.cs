using Localiza.Domain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Localiza.Domain.Models
{
    public class Endereco : BaseModel
    {
        public long EnderecoId { get; }
        public IEnumerable<Cliente> Cliente { get; set; }

        [Required]
        public string Logradouro { get; set; }
        public string? Complemento { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string CEP { get; set; }

    }
}
