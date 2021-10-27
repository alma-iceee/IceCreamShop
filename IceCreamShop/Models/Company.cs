using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamShop.Models
{
    public class Company : BaseEntity
    {
        public ICollection<IceScream> IceScreams { get; set; }
    }
}
