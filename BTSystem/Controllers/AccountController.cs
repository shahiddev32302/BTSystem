using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _config;

        public AccountController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password, string Role)
        {
            // 🔴 Dummy login (for now)
            if (Role == "admin")
                return RedirectToAction("Dashboard", "SuperAdmin");

            if (Role == "student" || Role == "parent")
                return RedirectToAction("Dashboard", "Student");

            if (Role == "driver")
                return RedirectToAction("Dashboard", "DriverDashbord");

            return View();
        }

        public IActionResult SignUp()
        {
            ViewBag.ApiBaseUrl = _config["ApiSettings:BaseUrl"];
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult VarifyPinCode()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
