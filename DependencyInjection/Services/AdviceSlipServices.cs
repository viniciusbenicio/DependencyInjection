using DependencyInjection.Models;
using DependencyInjection.Services.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace DependencyInjection.Services
{
    public class AdviceSlipServices : IAdviceSlipServices
    {
        public async Task<SlipObject> GetAdviceAsync(int slip_id)
        {
            var client = new RestClient($"https://api.adviceslip.com/advice/{slip_id}");
            var request = new RestRequest();

            var response = await client.GetAsync(request);

            var slip = JsonConvert.DeserializeObject<SlipObject>(response.Content);
         
            return slip;
        }
    }
}
