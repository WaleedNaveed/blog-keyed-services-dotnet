using KeyedServicesDemo.Interfaces;
using KeyedServicesDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServicesDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly OldWayPaymentFactory _oldFactory;

        public PaymentController(OldWayPaymentFactory oldFactory)
        {
            _oldFactory = oldFactory;
        }

        // -------------------- OLD WAY ----------------------
        [HttpPost("oldway")]
        public IActionResult PayOldWay(PaymentRequest request)
        {
            var service = _oldFactory.GetService(request.Provider);
            var result = service.ProcessPayment(request.Amount);
            return Ok(result);
        }

        // -------------------- NEW WAY (KEYED SERVICES) ----------------------
        [HttpPost("keyed")]
        public IActionResult PayKeyed(PaymentRequest request, [FromServices] IServiceProvider provider)
        {
            var keyedService = provider.GetRequiredKeyedService<IPaymentService>(request.Provider);
            var result = keyedService.ProcessPayment(request.Amount);
            return Ok(result);
        }
    }
}
