using MP.apiDotNet6.Domain.Entities;

namespace MP.apiDotNet6.Domain.Repositories {
    public interface IProductRepository {
        Task<Product> GetByIdAsync(int id);
        Task<ICollection<Product>> GetAllAsync();
        Task<Product> CreateAync(Product product);
        Task EditAsync(Product product);
        Task DeleteAsync(Product product);

    }
}
