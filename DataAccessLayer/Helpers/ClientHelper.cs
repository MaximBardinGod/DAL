using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Helpers;

public static class ClientHelper
{
    public static async Task<Client> WithSubscriptions(this Client client, ApplicationContext db)
    {
        client.Subscriptions = await db.Subscription.Where(c => c.ClientId == client.ClientId).ToListAsync();
        return client;
    }
}
