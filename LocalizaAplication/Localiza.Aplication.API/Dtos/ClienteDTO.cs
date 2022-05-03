using Localiza.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Localiza.WebAPI.Dtos
{
    public class ClienteDTO
    {       
        public long? ClienteId { get; set; }        

        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string DataNascimento { get; set; }
        [Required]
        public string NumeroCNH { get; set; }
        [Required]
        public EnderecoDTO Endereco { get; set; }
        public DateTime? DataCriacao { get; set; }

    }
}
