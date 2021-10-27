using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamShop.Models
{
    public class IceScream : BaseEntity
    {
        public int Price { get; set; }
        public Company Company { get; set; }
    }
}
