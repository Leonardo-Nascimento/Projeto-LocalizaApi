using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Aplication.Interface
{
    public interface IReservaAppService : IAppServiceBase<Reserva>
    {
        Task<IEnumerable<Reserva>> GetReservasByClienteId(long ClienteId);
        Task<bool> RetirarVeiculo(long ClienteId, string cpf);
        
    }
}
