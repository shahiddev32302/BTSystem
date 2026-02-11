using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult SettingManagement()
        {
            return View();
        }
    }
}
