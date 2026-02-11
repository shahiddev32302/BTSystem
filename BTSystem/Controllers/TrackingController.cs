using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class TrackingController : Controller
    {
        public IActionResult LiveTracking()
        {
            return View();
        }
    }
}
