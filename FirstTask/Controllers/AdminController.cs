using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
