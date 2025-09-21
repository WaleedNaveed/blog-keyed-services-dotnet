using KeyedServicesDemo.Interfaces;

namespace KeyedServicesDemo.Services
{
    public class PaypalPaymentService : IPaymentService
    {
        public string Provider => "PayPal";

        public string ProcessPayment(decimal amount)
        {
            return $"Processed {amount:C} via PayPal";
        }
    }
}
