using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webProjeVize.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webProjeVize.Controllers
{
    public class loginController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]

        public IActionResult Index(string username, string password)
        {
            authentication cslAuth = new authentication();

            if(cslAuth.UsernamePasswordController(username, password))
            {

                ViewBag.mesaj = "giriş başarılı";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.mesaj = cslAuth.errosMessage;
            }

            return View();
        }
    }

}

