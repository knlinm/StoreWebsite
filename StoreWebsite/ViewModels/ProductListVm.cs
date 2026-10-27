using StoreWebsite.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.ViewModels
{
    public class ProductListVm
    {
        public List<SizeDto> Sizes { get; set; }
        public List<ColorDto> Colors { get; set; }
        public List<BrandDto> Brands { get; set; }
        public ProductCategoryDto ProductCategory { get; set; }
        public List<ProductDto> Products { get; set; }


    }
}
