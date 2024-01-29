using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PaymentsRequests.Repository;

namespace PaymentsRequests.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController<T,TU> : ControllerBase where T : class
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<T> _repository;
    private readonly IMapper _mapper;

    public BaseController(IUnitOfWork unitOfWork, IRepository<T> repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper;
    }

    [HttpGet("all")]
    public IEnumerable<T> GetAll()
    {
        var items = _repository.Get();

        return items;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var item = await _repository.GetById(id);

        return Ok(item);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] TU itemDTO)
    {
        try
        {
            if (itemDTO == null)
            {
                return BadRequest("Item cannot be null");
            }

            var item = _mapper.Map<T>(itemDTO);

            _repository.Add(item);
            await _unitOfWork.Commit();
            
            return CreatedAtAction("GetAll", new { }, item);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(500, "Internal Server Error");
        }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, T item)
    {
        
        if (item == null) return BadRequest("Item cannot be null");
        
        _repository.Update(item);
        await _unitOfWork.Commit();

        return Ok(item);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id, T item)
    {
        if (item == null) return BadRequest("Item cannot be null");
        
        _repository.Delete(item);
        await _unitOfWork.Commit();

        return Ok(item);
    }
    
}