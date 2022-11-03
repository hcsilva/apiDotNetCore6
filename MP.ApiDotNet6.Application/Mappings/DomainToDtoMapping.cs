using AutoMapper;
using MP.apiDotNet6.Domain.Entities;
using MP.ApiDotNet6.Application.Dtos;

namespace MP.ApiDotNet6.Application.Mappings {
    public class DomainToDtoMapping : Profile {
        public DomainToDtoMapping() {
            CreateMap<Person, PersonDTO>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
