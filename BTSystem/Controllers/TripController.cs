using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class TripController : Controller
    {
        public IActionResult TripScheduling()
        {
            return View();
        }
    }
}
