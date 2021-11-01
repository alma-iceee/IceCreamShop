using System.ComponentModel.DataAnnotations.Schema;

namespace IceCreamShop.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public double Price { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
