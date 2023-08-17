using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
