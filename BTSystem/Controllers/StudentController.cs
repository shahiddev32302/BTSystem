using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}