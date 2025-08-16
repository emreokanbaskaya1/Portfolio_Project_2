using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project_2.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
