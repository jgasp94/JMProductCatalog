using AutoMapper;
using JMProductCatalog.App.DTOs;
using JMProductCatalog.Domain.Entities;

namespace JMProductCatalog.App.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
