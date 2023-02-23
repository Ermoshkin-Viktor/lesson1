using GitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace GitApp.Controllers
{
    public class UserController : Controller
    {
        ApplicationContext db;

        public UserController(ApplicationContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
