using DependencyInjection.Models;

namespace DependencyInjection.Repositories.Interfaces
{
    public interface IPromoCodeRepository
    {
        Task<PromoCode?> GetPromoCodeAsync(string promoCode);

    }
}
