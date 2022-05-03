using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Aplication.Interface
{
    public interface IVeiculoAppService : IAppServiceBase<Veiculo>
    {
        Task<Veiculo> GetByPlaca(string placa);

    }
}
