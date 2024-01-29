using AutoMapper;
using PaymentsRequests.DTO;
using PaymentsRequests.Model;
using PaymentsRequests.Repository;

namespace PaymentsRequests.Controllers;

public class OrderController : BaseController<Order, OrderDTO>
{

    public OrderController(IUnitOfWork unitOfWork, IRepository<Order> repository, IMapper mapper) : base(unitOfWork,
        repository, mapper)
    {
    }

}