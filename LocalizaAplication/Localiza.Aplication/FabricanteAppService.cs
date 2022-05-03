using Localiza.Aplication.Interface;
using Localiza.Domain.Interfaces.InterfaceServices;
using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Aplication
{
    public class FabricanteAppService : AppServiceBase<Fabricante>, IFabricanteAppService
    {
        private readonly IFabricanteService _fabricanteService;
        public FabricanteAppService(IFabricanteService fabricanteService) : base(fabricanteService)
        {
            _fabricanteService = fabricanteService;
        }
    }
}
