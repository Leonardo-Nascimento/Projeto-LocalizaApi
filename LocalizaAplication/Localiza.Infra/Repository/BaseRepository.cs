using Localiza.Domain.Interfaces.Repositories;
using Localiza.Infra.Contexto;

namespace Localiza.Infra.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly LocalizaDbContext _context;

        public BaseRepository(LocalizaDbContext context )
        {
            _context = context;
        }

        public async Task<T> Add(T Objeto)
        {
            try
            {
                _context.Add(Objeto);
                _context.SaveChanges();
                return Objeto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> Delete(T Objeto)
        {
            try
            {
                _context.Update(Objeto);
                _context.SaveChanges();
                return Objeto;
            }
            catch (Exception ex)
            {

                throw ex;
            }    
        }



        public async Task<T> GetById(long Id)
        {
            return  _context.Find<T>(Id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> Update(T Objeto)
        {
            _context.Update(Objeto);
            _context.SaveChanges();
            return Objeto;
        }
    }
}
