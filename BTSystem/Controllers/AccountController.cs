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

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SignUp(
        //    string FullName,
        //    string Username,
        //    string RegistrationNo,
        //    string Email,
        //    string Phone,
        //    string Address,
        //    string Password,
        //    string ConfirmPassword,
        //    string Role = "student" // default role
        //)
        //{
        //    // 🔹 Dummy implementation: normally you'd save to DB
        //    // Example: TempData or a service call could store user
        //    TempData["SignupSuccess"] = $"User {FullName} ({Role}) registered successfully.";

        //    // Redirect to login page after signup
        //    return RedirectToAction("Login");
        //}

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
