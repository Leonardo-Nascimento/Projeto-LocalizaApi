using Localiza.Aplication.Interface;
using Localiza.Domain.Interfaces.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Aplication
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {

        private readonly IServiceBase<T> _appService;

        public AppServiceBase(IServiceBase<T> appServiceBase)
        {
            _appService = appServiceBase;
        }

        public async Task<T> Add(T Objeto)
        {
           return await _appService.Add(Objeto);
        }

        public Task<T> Delete(T Objeto)
        {
            return _appService.Delete(Objeto);
        }


        public Task<IEnumerable<T>> GetAll()
        {
            return _appService.GetAll();
        }

        public Task<T> GetById(long Id)
        {
            return _appService.GetById(Id);
        }

        public async Task<T> Update(T Objeto)
        {
            return await _appService.Update(Objeto);
        }
    }
}
