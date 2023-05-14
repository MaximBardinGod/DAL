using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public class Subscription
{
    [Key]
    public int SubscriptionId { get; set; }
    public int SubscriptionTypeId { get; set; }
    public int ClientId { get; set; }

    public Client? Client { get; set; }
}