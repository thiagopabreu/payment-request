using PaymentsRequests.Context;

namespace PaymentsRequests.Repository;

public class UnitOfWork : IUnitOfWork
{

    public AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        
    }
    
    private IProductRepository _ProductRepository;
    private IOrderItemRepository _OrderItemRepository;
    private IPaymentRepository _PaymentRepository;
    private IOrderRepository _OrderRepository;

    public IProductRepository ProductRepository => _ProductRepository ??= new ProductRepository(_context);
    public IOrderRepository OrderRepository => _OrderRepository ??= new OrderRepository(_context);
    public IOrderItemRepository OrderItemRepository => _OrderItemRepository ??= new OrderItemRepository(_context);
    public IPaymentRepository PaymentRepository => _PaymentRepository ??= new PaymentRepository(_context);
    
    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }

    public async Task Dispose()
    {
        await _context.DisposeAsync();
    }
}