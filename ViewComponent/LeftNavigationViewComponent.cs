using Microsoft.AspNetCore.Mvc;

namespace Application1.ViewComponents
{
    public class LeftNavigationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var links = new string[] { "Home", "Employees", "Privacy" };
            return View(links);
        }
    }
}