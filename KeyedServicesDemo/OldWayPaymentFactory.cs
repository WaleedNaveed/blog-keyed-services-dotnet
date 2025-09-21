using KeyedServicesDemo.Interfaces;

namespace KeyedServicesDemo
{
    public class OldWayPaymentFactory
    {
        private readonly IEnumerable<IPaymentService> _paymentServices;

        public OldWayPaymentFactory(IEnumerable<IPaymentService> paymentServices)
        {
            _paymentServices = paymentServices;
        }

        public IPaymentService GetService(string provider)
        {
            return _paymentServices.FirstOrDefault(s =>
                s.Provider.Equals(provider, StringComparison.OrdinalIgnoreCase))
                ?? throw new Exception("No service found for provider " + provider);
        }
    }
}
