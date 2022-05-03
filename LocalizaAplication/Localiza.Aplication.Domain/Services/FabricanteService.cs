using Localiza.Domain.Interfaces.InterfaceServices;
using Localiza.Domain.Interfaces.Repositories;
using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Domain.Services
{
    public class FabricanteService : ServiceBase<Fabricante>, IFabricanteService
    {
        private readonly IFabricanteRepository _fabricanteRepository;

        public FabricanteService(IFabricanteRepository fabricanteRepository) : base(fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository;
        }
    }
}
