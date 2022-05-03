namespace Localiza.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T Objeto);
        Task<T> Update(T Objeto);
        Task<T> Delete(T Objeto);
        Task<T> GetById(long Id);
        Task<IEnumerable<T>> GetAll();
    }
}
