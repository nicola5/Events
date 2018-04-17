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
        public ActionResult Login(User_Modelos user)
        {
            if (user.Login())
            {
                Session["Inicio"] = "OK";
                Session["User"]= user.user;
                return RedirectToAction("../Menu/Menu");
            }else
            {
                return View();
            }
        }

        public ActionResult Sign_up(User_Modelos user)
        {

            return View();
        }
    }
}