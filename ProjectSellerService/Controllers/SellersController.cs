using Microsoft.AspNetCore.Mvc;

namespace ProjectSellerService.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
