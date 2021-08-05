using Microsoft.AspNetCore.Mvc;

namespace VetClinicTestTask.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
