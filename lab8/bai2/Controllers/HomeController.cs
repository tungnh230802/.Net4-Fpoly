using bai2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserContext _context;

        public HomeController(UserContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //var EmailSession = HttpContext.Session.GetString("email");
            //if (String.IsNullOrEmpty(EmailSession))
            //{
            return View();
            //}
            //else
            //{
            //    ViewData["emailSession"] = EmailSession;

            //    return RedirectToAction(nameof(LoginSucess));
            //}

        }
        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            if (ModelState.IsValid)
            {
                var userLogin = await _context.Users.FirstOrDefaultAsync
                    (u => u.Email == user.Email && u.Passwork == user.Passwork);

                if (userLogin != null)
                {
                    HttpContext.Session.SetString("email", user.Email);

                    return RedirectToAction(nameof(LoginSucess));
                }
            }
            return View();
        }
        public IActionResult Regist()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Regist(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }
        public IActionResult LoginSucess()
        {

            ViewBag.Email = HttpContext.Session.GetString("email");

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
