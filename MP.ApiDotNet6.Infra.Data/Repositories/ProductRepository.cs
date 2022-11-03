using Microsoft.EntityFrameworkCore;
using MP.apiDotNet6.Domain.Entities;
using MP.apiDotNet6.Domain.Repositories;
using MP.ApiDotNet6.Infra.Data.Context;

namespace MP.ApiDotNet6.Infra.Data.Repositories {
    internal class ProductRepository : IProductRepository {

        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext) {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Product> CreateAync(Product product) {
            _applicationDbContext.Add(product);
            await _applicationDbContext.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsync(Product product) {
            _applicationDbContext.Remove(product);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Product product) {
            _applicationDbContext.Update(product);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<ICollection<Product>> GetAllAsync() {
            return await _applicationDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id) {
           return await _applicationDbContext.Products.FirstAsync(p => p.Id == id);

        }
    }
}
