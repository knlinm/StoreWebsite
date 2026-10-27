using Microsoft.AspNetCore.Mvc;

namespace StoreWebsite.Controllers
{
    public class AboutController : Controller
    {
        /// <summary>
        /// Haqqımızda səhifəsinin index-i
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
