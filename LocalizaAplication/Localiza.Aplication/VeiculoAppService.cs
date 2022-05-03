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
    public class VeiculoAppService : AppServiceBase<Veiculo>, IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoAppService(IVeiculoService veiculoService) : base(veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public Task<Veiculo> GetByPlaca(string placa)
        {
            return _veiculoService.GetVeiculoByPlaca(placa);
        }
    }
}
