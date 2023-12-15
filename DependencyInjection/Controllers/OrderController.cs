using DependencyInjection.Models;
using DependencyInjection.Repositories.Interfaces;
using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{

    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IPromoCodeRepository _promoCodeRepository;
        private readonly IDeliveryFeeServices _deliveryFeeService;

        public OrderController(
            ICustomerRepository customerRepository,
            IPromoCodeRepository promoCodeRepository,
            IDeliveryFeeServices deliveryFeeService)
        {
            _customerRepository = customerRepository;
            _promoCodeRepository = promoCodeRepository;
            _deliveryFeeService = deliveryFeeService;
        }

        [Route("v1/orders")]
        [HttpPost]
        public async Task<string> Place(
            int customerId,
            string zipCode,
            string promoCode,
            int[] products)
        {
            var customer = await _customerRepository.GetCustomerAsync(customerId);
            var deliveryFee = await _deliveryFeeService.GetDeliveryFeeAsync(zipCode);
            var cupon = await _promoCodeRepository.GetPromoCodeAsync(promoCode);
            var discount = cupon?.Value ?? 0M;
            var order = new Order(deliveryFee, discount, new List<Product>());
            return $"Pedido {order.Code} gerado com sucesso!";
        }
    }
}