using MP.apiDotNet6.Domain.Entities;

namespace MP.apiDotNet6.Domain.Repositories {
    public interface IPersonRepository {

        Task<Person> GetByIdAsync(int id);
        Task<ICollection<Person>> GetPeopleAllAsync();
        Task<Person> CreateAsync(Person person);
        Task EditAsync(Person person);
        Task DeleteAsync(Person person);

    }
}
