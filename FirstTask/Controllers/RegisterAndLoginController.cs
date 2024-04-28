using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class RegisterAndLoginController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
