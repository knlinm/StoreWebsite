using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreWebsite.Data;
using StoreWebsite.DTOs;
using StoreWebsite.Enums;
using StoreWebsite.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebsite.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Məhsulların siyahısı
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> List(int categoryId = (int)ProductCategoryEnum.Men)
        {
            var category = await _context.ProductCategories
                                            .Where(c => c.Id == categoryId)
                                                .Select(c => new ProductCategoryDto
                                                {
                                                    ProductCategoryDtoId = c.Id,
                                                    BackImage = c.BackgroundImage,
                                                    HoverImage = c.HoverImage,
                                                    Name = c.Name
                                                })
                                                .FirstOrDefaultAsync();

            if (category == null)
            {
                return RedirectToAction("NotFound", "Home");
            }

            var sizes = await _context.Sizes.Select(c => new SizeDto
            {
                SizeId = c.Id,
                Name = c.Name
            }).ToListAsync();

            var colors = await _context.Colors.Select(c => new ColorDto
            {
                ColorId = c.Id,
                Name = c.Name
            }).ToListAsync();

            var brands = await _context.Brands.Select(c => new BrandDto
            {
                BrandId = c.Id,
                Image = c.Image,
                Name = c.Name
            }).ToListAsync();


            var products = await _context.Products
                                            .Include(c => c.Brand)
                                            .Include(c => c.ProductCategory)
                                            .Include(c => c.ProductSizes)
                                            .ThenInclude(c => c.ProductColors)
                                            .Where(c => c.ProductCategoryId == category.ProductCategoryDtoId)
                                            .Select(c=> new ProductDto
                                            {
                                                Name = c.Name,
                                                Image = c.Image,
                                                Video = c.Video,
                                                Price = c.Price,
                                                ProductId = c.Id,
                                                Sizes = c.ProductSizes.Select(a=> new ProductSizeDto
                                                {
                                                    SizeId = a.SizeId,
                                                    ProductId = a.ProductId,
                                                    ProductSizeId = a.Id,
                                                    Colors = a.ProductColors.Select(b=> new ProductColorDto
                                                    {
                                                        ColorId = b.ColorId,
                                                        ProductSizeId = b.ProductSizeId,
                                                        ProductColorId = b.Id
                                                    }).ToList()
                                                }).ToList()
                                            })
                                            .OrderByDescending(c=>c.ProductId)
                                            .ToListAsync();


            var vm = new ProductListVm();

            vm.ProductCategory = category;
            vm.Products = products;
            vm.Sizes = sizes;
            vm.Brands = brands;
            vm.Colors = colors;

            return View(vm);
        }

        /// <summary>
        /// Məhsul barədə detallı məlumat
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail()
        {
            return View();
        }
    }
}
