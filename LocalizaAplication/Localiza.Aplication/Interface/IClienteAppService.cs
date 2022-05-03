using Localiza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Aplication.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        Task<Cliente> GetByCPF(string cpf);
    }
}
