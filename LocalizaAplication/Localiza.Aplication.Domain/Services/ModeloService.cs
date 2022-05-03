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
    public class ModeloService : ServiceBase<Modelo>, IModeloService
    {
        private readonly IModeloRepository _modeloRepository;

        public ModeloService(IModeloRepository modeloRepository) : base(modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }
    }
}
