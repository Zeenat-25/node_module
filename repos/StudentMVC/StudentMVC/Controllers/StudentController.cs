using Microsoft.AspNetCore.Mvc;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Zeenat";
            ViewBag.Course = "BCA";
            ViewBag.College = "Mulund College of Commerce";

            return View();
        }
    }
}