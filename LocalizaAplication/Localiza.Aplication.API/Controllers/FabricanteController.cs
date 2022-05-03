using AutoMapper;
using Localiza.Aplication.Interface;
using Localiza.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricanteController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IFabricanteAppService _fabricanteAppService;

        public FabricanteController(IMapper mapper, IFabricanteAppService fabricanteAppService)
        {
            _mapper = mapper;
            _fabricanteAppService = fabricanteAppService;
        }

        // GET api/values
        [HttpGet("GetAllFabricantes")]
        public async Task<IEnumerable<Fabricante>> GetAllFabricantes()
        {
            try
            {
                return await _fabricanteAppService.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
