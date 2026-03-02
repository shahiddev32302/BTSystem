using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class AdminManagementController : Controller
    {
        public IActionResult Management()
        {
            return View();
        }
    }
}
