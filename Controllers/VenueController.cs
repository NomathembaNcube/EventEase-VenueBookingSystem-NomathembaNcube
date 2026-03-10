using Microsoft.AspNetCore.Mvc;

namespace EventEase.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
