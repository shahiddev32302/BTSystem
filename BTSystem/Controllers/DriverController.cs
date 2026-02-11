using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class DriverController : Controller
    {
        public IActionResult DriverManagement()
        {
            return View();
        }
    }
}
