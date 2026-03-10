using Microsoft.AspNetCore.Mvc;

namespace EventEase.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
