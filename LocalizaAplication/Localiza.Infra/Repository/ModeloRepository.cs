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
    public class ModeloRepository : BaseRepository<Modelo>, IModeloRepository
    {
        public ModeloRepository(LocalizaDbContext context) : base(context)
        {
        }
    }
}
