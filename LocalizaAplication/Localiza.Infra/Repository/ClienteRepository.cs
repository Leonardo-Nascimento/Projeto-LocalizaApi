using Localiza.Domain.Interfaces.Repositories;
using Localiza.Domain.Models;
using Localiza.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Infra.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly LocalizaDbContext _context;
        public ClienteRepository(LocalizaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Cliente> GetByCPF(string cpf)
        {
            return  _context.Cliente.Where(x => x.CPF == cpf).FirstOrDefault();
        }


    }
}
