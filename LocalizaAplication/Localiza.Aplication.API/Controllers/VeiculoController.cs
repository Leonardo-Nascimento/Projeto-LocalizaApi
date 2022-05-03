using AutoMapper;
using Localiza.Aplication.Interface;
using Localiza.Domain.Models;
using Localiza.WebAPI.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : Controller
    {
        private readonly IVeiculoAppService _veiculoAppService;
        public readonly IMapper _mapper;


        public VeiculoController(IVeiculoAppService veiculoAppService, IMapper mapper)
        {
            _veiculoAppService = veiculoAppService;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet("GetAllVeiculos")]
        public async Task<IEnumerable<Veiculo>> GetAllVeiculos()
        {
            try
            {
                return await _veiculoAppService.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetVeiculoByPlaca")]
        public async Task<IActionResult> GetVeiculoByPlaca(string placa )
        {
            try
            {
                var veiculo =  await _veiculoAppService.GetByPlaca(placa);
                var veiculoDTO = _mapper.Map<VeiculoDTO>(veiculo);
                
                if(veiculoDTO != null)
                    return Ok(veiculoDTO);

                return Ok(new {message = "placa não encontrada", placa = placa });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("InsereVeiculo")]
        public async Task<IActionResult> InsereVeiculo(VeiculoDTO veiculoDTO)
        {

            try
            {
                var veiculo = _mapper.Map<Veiculo>(veiculoDTO);
                veiculo.Placa =  veiculo.Placa.ToUpper();

                var novoVeiculo = await _veiculoAppService.Add(veiculo);

                if (novoVeiculo != null)
                    return Ok(new { message = "Veiculo adicionado com sucesso!", veiculo = novoVeiculo });

                return Ok(new { message = "Erro ao tentar adicionar veiculo", veiculo = veiculoDTO });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
