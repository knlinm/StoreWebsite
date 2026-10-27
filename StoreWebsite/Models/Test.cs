using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.Models
{
    public class Test:Entity
    {
        public string Name { get; set; }
        public Product Product { get; set; }
    }
}
