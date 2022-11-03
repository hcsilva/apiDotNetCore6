using AutoMapper;
using MP.apiDotNet6.Domain.Entities;
using MP.ApiDotNet6.Application.Dtos;

namespace MP.ApiDotNet6.Application.Mappings {
    public class DtoToDomainMap : Profile {
        public DtoToDomainMap() {
            CreateMap<PersonDTO, Person>();
            CreateMap<ProductDTO, Product>();   
        }
    }
}
