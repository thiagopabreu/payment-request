namespace PaymentsRequests.Repository;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    IOrderItemRepository OrderItemRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IOrderRepository OrderRepository { get; }


    Task Commit();
    Task Dispose();
}