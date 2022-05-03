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
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository):base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<Cliente> GetByCPF(string cpf)
        {
            return _clienteRepository.GetByCPF(cpf);
        }


    }
}
