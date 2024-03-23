using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.ViewComponents.Header
{
    public class Header:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
