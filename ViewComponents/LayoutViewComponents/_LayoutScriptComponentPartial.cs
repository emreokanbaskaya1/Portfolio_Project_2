﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project_2.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
