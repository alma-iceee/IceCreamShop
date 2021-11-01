using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IceCreamShop.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
