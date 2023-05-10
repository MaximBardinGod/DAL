using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services;

public class ProductServices : IServicesProduct
{
    public readonly ApplicationContext _db;

    public ProductServices(ApplicationContext db)
    {
        _db = db;
    }

    public async Task<Product> AddProduct(Product product)
    {
        var result = await _db.Product.AddAsync(product);
        await _db.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteProduct(int id)
    {
        var product = await GetProductById(id);
        _db.Remove(product);
        await _db.SaveChangesAsync();
        return product != null ? true : false;
    }

    public async Task<IEnumerable<Product>> GetProduct()
    {
        return await _db.Product.ToListAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
        return await _db.Product.FirstOrDefaultAsync(p => p.ProductId == id);
    }

    public async Task<Product> GetProductByName(string name)
    {
        return await _db.Product.FirstOrDefaultAsync(p => p.Name == name);
    }

    public async Task<Product> UpdateProduct(Product product)
    {
        var result = _db.Product.Update(product);
        await _db.SaveChangesAsync();
        return result.Entity;
    }
}
