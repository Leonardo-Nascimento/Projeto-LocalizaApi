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
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        private readonly LocalizaDbContext _context;
        public VeiculoRepository(LocalizaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Veiculo> GetVeiculoByPlaca(string placa)
        {
            var veiculo =  _context.Veiculo.Where(x => x.Placa.ToUpper() == placa.ToUpper()).FirstOrDefault();
            return veiculo;
        }
    }
}
