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
    public class ReservaAppService : AppServiceBase<Reserva>, IReservaAppService
    {
        private readonly IReservaService _reservaService;
        public ReservaAppService(IReservaService reservaService) : base(reservaService)
        {
            _reservaService = reservaService;
        }

        public async Task<IEnumerable<Reserva>> GetReservasByClienteId(long ClienteId)
        {
            var result =  await _reservaService.GetReservasByClienteId(ClienteId);
            return result;
        }

        public async Task<bool> RetirarVeiculo(long ClienteId, string cpf)
        {
            return await _reservaService.RetirarVeiculo(ClienteId,cpf);
        }
    }
}
