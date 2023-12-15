namespace DependencyInjection.Services.Interfaces
{
    public interface IDeliveryFeeServices
    {
        Task<decimal> GetDeliveryFeeAsync(string zipCode);

    }
}
