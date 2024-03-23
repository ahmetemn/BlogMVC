using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.ViewComponents.Banner
{
    public class Banner:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
