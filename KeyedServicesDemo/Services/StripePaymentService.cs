using KeyedServicesDemo.Interfaces;

namespace KeyedServicesDemo.Services
{
    public class StripePaymentService : IPaymentService
    {
        public string Provider => "Stripe";

        public string ProcessPayment(decimal amount)
        {
            return $"Processed {amount:C} via Stripe";
        }
    }
}
