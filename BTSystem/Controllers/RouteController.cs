using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class RouteController : Controller
    {
        public IActionResult RouteManagement()
        {
            return View();
        }
    }
}
