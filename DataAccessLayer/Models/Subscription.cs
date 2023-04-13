using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public string NameSubscription { get; set; }
        public int Cost { get; set; }
        public int ClientId { get; set; }
        
        public Client Client { get; set; }
        
        public Subscription(){}

        public Subscription(int subscriptionId, string nameSubscription, int cost, int clientId)
        {
            SubscriptionId = subscriptionId;
            NameSubscription = nameSubscription;
            Cost = cost;
            ClientId = clientId;
        }
    }
}