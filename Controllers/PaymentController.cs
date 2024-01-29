using AutoMapper;
using PaymentsRequests.DTO;
using PaymentsRequests.Model;
using PaymentsRequests.Repository;

namespace PaymentsRequests.Controllers;

public class PaymentController : BaseController<Payment, PaymentDTO>
{

    public PaymentController(UnitOfWork unitOfWork, IRepository<Payment> repository, IMapper mapper) : base(unitOfWork,
        repository, mapper)
    {
    }

}