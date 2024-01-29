using AutoMapper;
using Microsoft.AspNetCore.Components;
using PaymentsRequests.DTO;
using PaymentsRequests.Model;
using PaymentsRequests.Repository;

namespace PaymentsRequests.Controllers;


[Route("api/[controller]")]
public class ProductController : BaseController<Product, ProductDTO>
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;
    
    public ProductController(IUnitOfWork unitOfWork, IRepository<Product> repository, IMapper mapper) : base(unitOfWork, repository, mapper)
    {

    }
}