using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
