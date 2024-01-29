using AutoMapper;
using Microsoft.AspNetCore.Components;
using PaymentsRequests.DTO;
using PaymentsRequests.Model;
using PaymentsRequests.Repository;

namespace PaymentsRequests.Controllers;

[Route("api/[controller]")]
public class OrderItemController : BaseController<OrderItem, OrderItemDTO>
{
    public OrderItemController(IUnitOfWork unitOfWork, IRepository<OrderItem> repository, IMapper mapper) : base(
        unitOfWork, repository, mapper)
    {
    }
}