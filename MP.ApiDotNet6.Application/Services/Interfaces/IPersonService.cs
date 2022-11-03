using MP.ApiDotNet6.Application.Dtos;

namespace MP.ApiDotNet6.Application.Services.Interfaces {
    public interface IPersonService {
        Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO);
        Task<ResultService<ICollection<PersonDTO>>> GetAllAsync();
        Task<ResultService<PersonDTO>> GetByIdAsync(int id);
        Task<ResultService> UpdateAsync(PersonDTO personDTO);
        Task<ResultService> DeleteAsync(int id);
    }
}
