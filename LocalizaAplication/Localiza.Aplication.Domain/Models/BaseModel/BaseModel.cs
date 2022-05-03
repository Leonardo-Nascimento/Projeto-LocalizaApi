
using System.ComponentModel.DataAnnotations;

namespace Localiza.Domain.Models.Base
{
    public abstract class BaseModel
    {
        [Required]
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataExclusao { get; set; }

    }
}
