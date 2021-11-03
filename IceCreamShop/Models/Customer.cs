using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IceCreamShop.Models
{
    public class Customer : BaseEntity
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
