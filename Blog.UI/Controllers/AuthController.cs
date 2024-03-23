using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult GirisYap()
        {
            return View();      
        }
    }
}
