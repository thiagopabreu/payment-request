using AutoMapper;
using PaymentsRequests.Model;

namespace PaymentsRequests.DTO.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}