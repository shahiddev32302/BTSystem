using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult ReportsManagement()
        {
            return View();
        }
    }
}
