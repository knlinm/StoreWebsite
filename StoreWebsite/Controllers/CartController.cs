using Microsoft.AspNetCore.Mvc;

namespace StoreWebsite.Controllers
{
    public class CartController : Controller
    {
        /// <summary>
        /// Səbətdə olan cari məhsulların görünməsi üçün view
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
