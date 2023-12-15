using DependencyInjection.Repositories.Interfaces;
using DependencyInjection.Repositories;
using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using DependencyInjection.Services.Interfaces;
using Microsoft.Data.SqlClient;

namespace DependencyInjection.Extensions
{
    public static class DependenciesExtension
    {
        public static void AddSqlConnection(
            this IServiceCollection services,
            string connectionString)
        {
            services.AddScoped<SqlConnection>(x
                => new SqlConnection(connectionString));
        }
        public static void AddRepositories(this IServiceCollection services)
        {
            services.TryAddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IPromoCodeRepository, PromoCodeRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDeliveryFeeServices, DeliveryFeeService>();
        }
    }
}
