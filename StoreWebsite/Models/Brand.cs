using System.Collections;
using System.Collections.Generic;

namespace StoreWebsite.Models
{
    public class Brand:Entity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
