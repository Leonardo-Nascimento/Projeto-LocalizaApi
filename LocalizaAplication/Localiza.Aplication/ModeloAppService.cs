

using Localiza.Aplication.Interface;
using Localiza.Domain.Interfaces.InterfaceServices;
using Localiza.Domain.Models;

namespace Localiza.Aplication
{
    public class ModeloAppService : AppServiceBase<Modelo>, IModeloAppService
    {
        private readonly IModeloService _modeloService;
        public ModeloAppService(IModeloService modeloService) : base(modeloService)
        {
            _modeloService = modeloService;
        }
    }
}
