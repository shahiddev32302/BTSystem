using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class SuperAdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
