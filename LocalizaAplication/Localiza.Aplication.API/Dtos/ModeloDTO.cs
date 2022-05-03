using Localiza.Domain.Enuns;

namespace Localiza.WebAPI.Dtos
{
    public class ModeloDTO
    {
        public long ModeloId { get; }

        public long? FabricanteId { get; set; }
        public string Nome { get; set; }
        public TipoVeiculo? Tipo { get; set; }
        public DateTime? DataCriacao { get; set; }

    }
}
