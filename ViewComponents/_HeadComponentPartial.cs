using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project_2.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
