using System.Collections;
using System.Collections.Generic;

namespace StoreWebsite.Models
{
    public class ProductCategory:Entity
    {
        public string Name { get; set; }
        public string BackgroundImage { get; set; }
        public string HoverImage { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
