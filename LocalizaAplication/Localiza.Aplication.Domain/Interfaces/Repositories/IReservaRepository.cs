using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Domain.Interfaces.Repositories
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        Task<IEnumerable<Reserva>> GetReservasByClienteId(long ClienteId);

        Task<bool> RetirarVeiculo(long ClienteId, string cpf);
    }
}
