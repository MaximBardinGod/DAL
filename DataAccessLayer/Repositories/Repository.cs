using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class Repository : IRepository
{
    public readonly ApplicationContext _db;

    public Repository(ApplicationContext db)
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
        /*
        IQueryable<Product> query = _db.Product;
        if (!string.IsNullOrWhiteSpace(name))
            query = query.Where(p => p.Name != null && p.Name.Contains(name));
        return await query.ToListAsync();*/
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

    public async Task<SubscriptionStyle> AddSubscriptionStyle(SubscriptionStyle subscriptionStyle)
    {
        var result = await _db.SubscriptionStyle.AddAsync(subscriptionStyle);
        await _db.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<bool> DeleteSubscriptionStyle(int id)
    {
        var subscriptionStyle = await GetSubscriptionStyleById(id);
        _db.Remove(subscriptionStyle);
        await _db.SaveChangesAsync();
        return subscriptionStyle != null ? true : false;
    }

    public async Task<IEnumerable<SubscriptionStyle>> GetSubscriptionsStyle()
    {
        return await _db.SubscriptionStyle.ToListAsync();
        /*
        IQueryable<Product> query = _db.Product;
        if (!string.IsNullOrWhiteSpace(name))
            query = query.Where(p => p.Name != null && p.Name.Contains(name));
        return await query.ToListAsync();*/
    }

    public async Task<SubscriptionStyle> GetSubscriptionStyleById(int id)
    {
        return await _db.SubscriptionStyle.FirstOrDefaultAsync(p => p.SubscriptionStyleId == id);
    }

    public async Task<SubscriptionStyle> GetSubscriptionStyleByName(string name)
    {
        return await _db.SubscriptionStyle.FirstOrDefaultAsync(p => p.NameSubscription == name);
    }

    public async Task<SubscriptionStyle> UpdateSubscriptionStyle(SubscriptionStyle subscriptionStyle)
    {
        var result = _db.SubscriptionStyle.Update(subscriptionStyle);
        await _db.SaveChangesAsync();
        return result.Entity;
    }
}
