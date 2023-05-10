using Domain.Models;

namespace DataAccessLayer.Services;

public interface IServicesProduct
{
    public Task<IEnumerable<Product>> GetProduct();
    public Task<Product> GetProductById(int id);
    public Task<Product> GetProductByName(string name);
    public Task<Product> AddProduct(Product product);
    public Task<Product> UpdateProduct(Product product);
    public Task<bool> DeleteProduct(int id);
}
