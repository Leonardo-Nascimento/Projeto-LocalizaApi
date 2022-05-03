

using Localiza.Domain.Models;

namespace Localiza.Domain.Interfaces.InterfaceServices
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        Task<Cliente> GetByCPF(string cpf);

    }
}
