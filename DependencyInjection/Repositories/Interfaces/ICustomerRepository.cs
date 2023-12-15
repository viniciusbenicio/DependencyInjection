using DependencyInjection.Models;

namespace DependencyInjection.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerAsync(int id);
    }
}
