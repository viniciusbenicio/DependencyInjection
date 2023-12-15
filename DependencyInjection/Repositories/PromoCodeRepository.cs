using DependencyInjection.Models;
using DependencyInjection.Repositories.Interfaces;

namespace DependencyInjection.Repositories
{
    public class PromoCodeRepository : IPromoCodeRepository
    {
        private readonly SqlConnection _connection;

        public PromoCodeRepository(SqlConnection connection)
            => _connection = connection;

        public async Task<PromoCode?> GetPromoCodeAsync(string promoCode)
        {
            var query = $"SELECT * FROM PROMO_CODES WHERE CODE={promoCode}";
            return await _connection.QueryFirstOrDefaultAsync<PromoCode>(query);
        }
    }
}
