using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CountProtein { get; set; }
        public int CountFat { get; set; }
        public int CountUgl { get; set; }
        
        public Product(){}

        public Product(int productId, string name, int countProtein, int countFat, int countUgl)
        {
            ProductId = productId;
            Name = name;
            CountProtein = countProtein;
            CountFat = countFat;
            CountUgl = countUgl;
        }
    }
}