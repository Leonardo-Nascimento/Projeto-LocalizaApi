using System.ComponentModel.DataAnnotations;

namespace Localiza.WebAPI.Dtos
{
    public class EnderecoDTO
    {
        public long? EnderecoId { get; set; }

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
        public DateTime? DataCriacao { get; set; }

    }
}
