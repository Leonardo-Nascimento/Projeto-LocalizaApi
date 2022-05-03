using Localiza.Domain.Interfaces.InterfaceServices;
using Localiza.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Domain.Services
{
    public class ServiceBase<T> : IDisposable ,IServiceBase<T> where T : class
    {

        private readonly IBaseRepository<T> _repository;

        public  ServiceBase(IBaseRepository<T> baseRepository)
        {
            _repository = baseRepository;
        }

        public async Task<T> Add(T Objeto)
        {
            return await _repository.Add(Objeto);
        }

        public async Task<T> Delete(T Objeto)
        {
            return await _repository.Delete(Objeto);         
        }

        public Task<T> GetById(long Id)
        {
            return _repository.GetById(Id);
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<T> Update(T Objeto)
        {
            return _repository.Update(Objeto);
        }

        public void Dispose()
        {
            //_repository.Dispose();
        }
    }
}
