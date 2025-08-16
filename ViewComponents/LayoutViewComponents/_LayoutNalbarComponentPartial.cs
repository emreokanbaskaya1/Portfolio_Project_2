using Microsoft.AspNetCore.Mvc;
using Portfolio_Project_2.DAL.Context;

namespace Portfolio_Project_2.ViewComponents.LayoutViewComponents
{
    public class _LayoutNalbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
