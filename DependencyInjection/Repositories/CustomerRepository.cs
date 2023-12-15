using Dapper;
using DependencyInjection.Models;
using DependencyInjection.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace DependencyInjection.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SqlConnection _connection;

        public CustomerRepository(SqlConnection connection)
            => _connection = connection;

        public async Task<Customer?> GetCustomerAsync(int id)
        {
            var query = $"SELECT * FROM CUSTOMER WHERE ID={id}";
            return await _connection
                .QueryFirstAsync<Customer>(query);
        }
    }
}
