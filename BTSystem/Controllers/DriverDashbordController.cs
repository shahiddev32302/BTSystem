using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class DriverDashbordController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
