using System.Collections;
using System.Collections.Generic;

namespace StoreWebsite.Models
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Video { get; set; }
        public string Image { get; set; }
        public int StockCount { get; set; }

        public int BrandId { get; set; }
        public int ProductCategoryId { get; set; }


        public virtual Brand Brand { get; set; } 
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
    }
}
