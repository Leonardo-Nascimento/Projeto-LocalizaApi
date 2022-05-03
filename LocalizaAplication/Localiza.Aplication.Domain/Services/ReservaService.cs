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
    public class ReservaService : ServiceBase<Reserva>, IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository) : base(reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<IEnumerable<Reserva>> GetReservasByClienteId(long ClienteId)
        {
            return await _reservaRepository.GetReservasByClienteId(ClienteId);
        }

        public async Task<bool> RetirarVeiculo(long ClienteId, string cpf)
        {
            return await _reservaRepository.RetirarVeiculo(ClienteId, cpf);
        }
    }
}
