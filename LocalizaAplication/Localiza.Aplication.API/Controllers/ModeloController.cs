using AutoMapper;
using Localiza.Aplication.Interface;
using Localiza.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : Controller
    {
        private readonly IModeloAppService _modeloAppService;
        public readonly IMapper _mapper;


        public ModeloController(IModeloAppService modeloAppService, IMapper mapper)
        {
            _modeloAppService = modeloAppService;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet("GetAllModelos")]
        public async Task<IEnumerable<Modelo>> GetAllModelos()
        {
            try
            {
                return await _modeloAppService.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
