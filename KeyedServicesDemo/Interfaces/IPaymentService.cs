namespace KeyedServicesDemo.Interfaces
{
    public interface IPaymentService
    {
        string Provider { get; }
        string ProcessPayment(decimal amount);
    }
}
