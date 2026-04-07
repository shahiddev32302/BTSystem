using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Management()
        {
            return View();
        }
    }
}
