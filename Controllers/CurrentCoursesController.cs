using Microsoft.AspNetCore.Mvc;

namespace Grade.Controllers
{
    public class CurrentCoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
