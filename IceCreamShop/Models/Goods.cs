using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IceCreamShop.Models
{
    public class Goods : BaseEntity
    {
        public string Code { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [ForeignKey("GoodsStatusId")]
        public GoodsStatus GoodsStatus { get; set; }
        public int GoodsStatusId { get; set; }
    }
}
