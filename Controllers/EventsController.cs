using Microsoft.AspNetCore.Mvc;

namespace Prog_poe.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
