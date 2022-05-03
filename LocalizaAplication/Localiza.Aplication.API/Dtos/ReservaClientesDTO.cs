namespace Localiza.WebAPI.Dtos
{
    public class ReservaClientesDTO
    {
        public ClienteDTO Cliente { get; set; }

        public IEnumerable<ReservaDTO> Reservas { get; set; }
    }
}
