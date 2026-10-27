using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.DTOs
{
    public class ProductCategoryDto
    {
        public int ProductCategoryDtoId { get; set; }
        public string Name { get; set; }
        public string BackImage { get; set; }
        public string HoverImage { get; set; }
    }
}
