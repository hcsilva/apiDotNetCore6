using Microsoft.EntityFrameworkCore;
using MP.apiDotNet6.Domain.Entities;
using MP.apiDotNet6.Domain.Repositories;
using MP.ApiDotNet6.Infra.Data.Context;

namespace MP.ApiDotNet6.Infra.Data.Repositories {
    public class PersonRepository : IPersonRepository {

        private readonly ApplicationDbContext _applicationDbContext;

        public PersonRepository(ApplicationDbContext applicationDbContext) {
            _applicationDbContext = applicationDbContext;
        }

       public async Task<Person> CreateAsync(Person person) {
            _applicationDbContext.Add(person);
            await _applicationDbContext.SaveChangesAsync();
            return person;

        }

        public async Task DeleteAsync(Person person) {
            _applicationDbContext.Remove(person);
            _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Person person) {
            _applicationDbContext.Update(person);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<Person> GetByIdAsync(int id) {
          return await _applicationDbContext.People.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<ICollection<Person>> GetPeopleAllAsync() {
            return await _applicationDbContext.People.ToListAsync();
        }
    }
}
