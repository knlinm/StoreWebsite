using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.DTOs
{
    public class ProductSizeDto
    {
        public int SizeId { get; set; }
        public int ProductId { get; set; }
        public int ProductSizeId { get; set; }
        public List<ProductColorDto> Colors { get; set; }
    }
}
