using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class SuperAdminNotificationController : Controller
    {
        public IActionResult NotificationManagement()
        {
            return View();
        }
    }
}
