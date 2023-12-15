using DependencyInjection.Models;

namespace DependencyInjection.Services.Interfaces
{
    public interface IAdviceSlipServices
    {
        Task<SlipObject> GetAdviceAsync(int slip_id);
    }
}
