using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Domain.Interfaces.InterfaceServices
{
    public interface IVeiculoService : IServiceBase<Veiculo>
    {
        Task<Veiculo> GetVeiculoByPlaca(string placa);
    }
}
