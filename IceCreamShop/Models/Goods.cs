using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IceCreamShop.Models
{
    public class Goods : BaseEntity
    {
        public string Code { get; set; } = "GENERATE";

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now.AddDays(3);

        [ForeignKey("GoodsStatusId")]
        public GoodsStatus Status { get; set; }
        public int GoodsStatusId { get; set; }
    }
}
