using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminSayfasi()
        {
            return View();  
        }
    }
}
