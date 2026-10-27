using StoreWebsite.DTOs;
using StoreWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.ViewModels
{
    public class HomeVm
    {
        public List<BrandDto> Brands { get; set; }
        public List<ProductCategoryDto> ProductCategories { get; set; }
    }
}
