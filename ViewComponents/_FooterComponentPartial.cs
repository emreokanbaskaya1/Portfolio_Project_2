using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project_2.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
