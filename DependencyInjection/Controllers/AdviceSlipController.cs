using DependencyInjection.Models;
using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    public class AdviceSlipController : ControllerBase
    {
        private readonly IAdviceSlipServices _adviceSlipServices;
        public AdviceSlipController(IAdviceSlipServices adviceSlipServices)
        {
            _adviceSlipServices = adviceSlipServices;
        }

        [Route("v1/Advice")]
        [HttpPost]
        public async Task<SlipObject> GetById(int slip_id)
        {
            var retorno = await _adviceSlipServices.GetAdviceAsync(slip_id);

            return retorno;
        }
    }
}
