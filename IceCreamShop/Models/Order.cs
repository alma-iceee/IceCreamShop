using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IceCreamShop.Models
{
    public class Order : BaseEntity
    {
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("GoodsId")]
        public Goods Goods { get; set; }
        public int GoodsId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
