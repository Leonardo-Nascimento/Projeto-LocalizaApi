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
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public Task<Cliente> GetByCPF(string cpf)
        {
            return _clienteService.GetByCPF(cpf);
        }

        public Task<Reserva> GetReservasByClienteId(long ClienteId)
        {
            throw new NotImplementedException();
        }
    }
}
