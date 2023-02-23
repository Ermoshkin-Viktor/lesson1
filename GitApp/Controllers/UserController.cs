using Microsoft.AspNetCore.Mvc;

namespace GitApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
