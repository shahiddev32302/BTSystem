using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
