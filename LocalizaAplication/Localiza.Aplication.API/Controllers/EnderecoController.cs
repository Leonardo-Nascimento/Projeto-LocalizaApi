using Localiza.Aplication.Interface;
using Localiza.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.WebAPI.Controllers
{
    [Route("Api/Controller")]
    [ApiController]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoAppService _enderecoAppService;


        public EnderecoController(IEnderecoAppService enderecoAppService)
        {
            _enderecoAppService = enderecoAppService;
        }

        // GET api/values
        [HttpPost("InsereEndereco")]
        public async Task<Endereco> InsereEndereco(Endereco endereco)
        {
            try
            {
                return await _enderecoAppService.Add(endereco);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
