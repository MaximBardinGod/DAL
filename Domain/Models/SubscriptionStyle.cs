using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class SubscriptionStyle
{
    [Key]
    public int SubscriptionStyleId { get; set; }
    public string? NameSubscription { get; set; }
    public string? Description { get; set;}
    public int Cost { get; set; }

}
