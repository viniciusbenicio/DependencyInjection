using DependencyInjection.Services.Interfaces;
using RestSharp;

namespace DependencyInjection.Services
{
    public class DeliveryFeeService : IDeliveryFeeServices
    {
        public async Task<decimal> GetDeliveryFeeAsync(string zipCode)
        {
            var client = new RestClient("https://api.myorg.com");
            var request = new RestRequest()
                .AddJsonBody(new
                {
                    ZipCode = zipCode
                });
            var response = await client.PostAsync<decimal>(request, new CancellationToken());

            // Caso não consiga obter a taxa de entrega o valor padrão é 5
            return response == 0 ? 5 : response;
        }
    }
}
