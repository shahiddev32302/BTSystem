using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult NotificationManagement()
        {
            return View();
        }
    }
}
