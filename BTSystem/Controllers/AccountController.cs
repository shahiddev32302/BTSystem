using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password, string Role)
        {
            // 🔴 Dummy login (for now)

            if (Role == "admin")
                return RedirectToAction("Dashboard", "Admin");

            if (Role == "student" || Role == "parent")
                return RedirectToAction("Dashboard", "Student");

            if (Role == "driver")
                return RedirectToAction("Dashboard", "DriverDashbord");

            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
