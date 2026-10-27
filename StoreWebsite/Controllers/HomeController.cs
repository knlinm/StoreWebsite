using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreWebsite.Data;
using StoreWebsite.DTOs;
using StoreWebsite.Models;
using StoreWebsite.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Ana səhifənin view-su üçün nəzərdə tutulmuş action. Viewmodel məntiqi
        /// ilə səhifədə olan dinamik informasiyalar gələcəkdir.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var productCategories = await _context.ProductCategories.Select(c=> new ProductCategoryDto
            {
                ProductCategoryDtoId = c.Id,
                BackImage = c.BackgroundImage,
                HoverImage = c.HoverImage,
                Name = c.Name
            }).ToListAsync();

            var brands = await _context.Brands.Select(c=> new BrandDto
            {
                BrandId = c.Id,
                Name = c.Name,
                Image = c.Image
            }).Take(4).ToListAsync();

            var vm = new HomeVm();

            vm.Brands = brands;
            vm.ProductCategories = productCategories;


            return View(vm);
        }

        public IActionResult NotFound()
        {
            return View();
        }
    }
}
