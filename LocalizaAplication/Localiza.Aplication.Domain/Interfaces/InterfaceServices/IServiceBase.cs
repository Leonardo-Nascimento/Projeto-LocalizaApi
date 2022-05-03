using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Domain.Interfaces.InterfaceServices
{
    public interface IServiceBase<T> where T : class
    {
        Task<T> Add(T Objeto);
        Task<T> Update(T Objeto);
        Task<T> Delete(T Objeto);
        Task<T> GetById(long Id);
        Task<IEnumerable<T>> GetAll();
    }
}
