using AutoMapper;
using Localiza.Aplication.Interface;
using Localiza.Domain.Models;
using Localiza.WebAPI.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IReservaAppService _reservaAppService;

        public ReservaController(IMapper mapper, IReservaAppService reservaAppService)
        {
            _mapper = mapper;
            _reservaAppService = reservaAppService;
        }


        [HttpGet("GetAllReservas")]
        public async Task<IEnumerable<Reserva>> GetAllReservas()
        {
            try
            {
                var reservas = await _reservaAppService.GetAll();

                return reservas;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet("GetReservasByCliente")]
        public async Task<IActionResult> GetReservasByCliente(long ClienteId)
        {
            try
            {
                var result = await _reservaAppService.GetReservasByClienteId(ClienteId);

                return Ok(result);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("FazerReserva")]
        public async Task<IActionResult> FazerReserva([FromBody] ReservaDTO reservaDTO)
        {
            try
            {
                var reserva = _mapper.Map<Reserva>(reservaDTO);

                //cliente.Endereco = await _enderecoAppService.Add(endereco);

                reserva.DataCriacao = DateTime.Now;
                var result = await _reservaAppService.Add(reserva);

                if (result != null)
                {
                    reservaDTO.ClienteId = result.ClienteId;
                    reservaDTO.VeiculoId = result.VeiculoId;
                    return Json(new { message = "Sua reserva foi feita com sucesso!", reserva = reservaDTO });
                }

                return Json(new { message = "Erro ao tentar fazer sua reserva", reserva = reservaDTO });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("RetirarVeiculoReservado")]
        public async Task<IActionResult> RetirarVeiculoReservado(long ClienteId, string cpf)
        {
            try
            {
                var reserva = await _reservaAppService.RetirarVeiculo(ClienteId, cpf);

                if (reserva)
                    return Ok(new { message = "Veiculo Liberado!" });

                return Ok(new { message = $"Nenhum veiculo reservado foi encontrato para liberação referente ao cliente id: {ClienteId} e cpf: {cpf}" });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //[HttpGet("GetAllReservas")]
        //public async Task<IEnumerable<ReservaClientesDTO>> VeiculosRetiradosPorPeriodo()
        //{
        //    try
        //    {
        //        var reservas = await _reservaAppService.GetAll();

        //        return reservas;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}
