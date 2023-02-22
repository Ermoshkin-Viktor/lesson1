using GitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GitApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            //получаем объекты из бд создаем из них список и передаем в представление
            return View(await db.Users.ToListAsync());
        }

        //выводим форму с данными об объекте
        public async Task<IActionResult> Edit(int? id)
        {
            //если id не равен null
            if (id != null)
            {
                //находим юзера по id
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                //если юзер не равен null
                if (user != null)
                    //выводим юзера в представление
                    return View(user);
            }
            return NotFound();
        }
        //получаем отредактированные данные объекта
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            //если модель валидна и не равна null
            if (ModelState.IsValid && user != null)
            {
                //редактируем данные
                db.Users.Update(user);
                //выполняем обновление в бд
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return Content("Не корректные данные");
        }
    }
}
