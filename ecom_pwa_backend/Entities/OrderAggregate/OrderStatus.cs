namespace ecom_pwa_backend.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        Pending,

        PaymentRecieved,

        PaymentFailed,

        PaymentMismatch
    }
}