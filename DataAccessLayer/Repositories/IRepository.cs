using Domain.Models;

namespace DataAccessLayer.Repositories;

public interface IRepository
{
    public Task<IEnumerable<Product>> GetProduct();
    public Task<Product> GetProductById(int id);
    public Task<Product> GetProductByName(string name);
    public Task<Product> AddProduct(Product product);
    public Task<Product> UpdateProduct(Product product);
    public Task<bool> DeleteProduct(int id);

    public Task<IEnumerable<SubscriptionStyle>> GetSubscriptionsStyle();
    public Task<SubscriptionStyle> GetSubscriptionStyleById(int id);
    public Task<SubscriptionStyle> GetSubscriptionStyleByName(string name);
    public Task<SubscriptionStyle> AddSubscriptionStyle(SubscriptionStyle subscriptionStyle);
    public Task<SubscriptionStyle> UpdateSubscriptionStyle(SubscriptionStyle subscriptionStyle);
    public Task<bool> DeleteSubscriptionStyle(int id);
}
