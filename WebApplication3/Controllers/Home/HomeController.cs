using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            Session["Inicio"] = "";
            Session["User"] = "Logout";
            return View();
        }


        [HttpPost]
        public ActionResult Login(Usuario user)
        {
            if (user.login(user))
            {
                Session["Inicio"] = "OK";
                Session["User"]= user.user;
                return RedirectToAction("../Home/Menu");
            }else
            {
                return View();
            }
        }

        public ActionResult Sign_up(Usuario user)
        {

            return View();
        }

        public ActionResult Menu(Usuario user)
        {

            return View();
        }
    }
}