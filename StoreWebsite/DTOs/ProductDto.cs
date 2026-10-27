using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.DTOs
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public decimal Price { get; set; }
        
        public List<ProductSizeDto> Sizes { get; set; }

    }
}
