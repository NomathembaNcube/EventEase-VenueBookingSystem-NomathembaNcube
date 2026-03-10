using Microsoft.AspNetCore.Mvc;

namespace EventEase.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
