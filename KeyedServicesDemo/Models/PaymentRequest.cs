namespace KeyedServicesDemo.Models
{
    public class PaymentRequest
    {
        public string Provider { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
