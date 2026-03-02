using Microsoft.AspNetCore.Mvc;

namespace BTSystem.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult CompanyManagement()
        {
            return View();
        } 
        public IActionResult Details()
        {
            return View();
        }
    }
}
