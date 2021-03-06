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
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(LocalizaDbContext context) : base(context)
        {
        }

    }
}
