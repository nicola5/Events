using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User_Modelos
    {
        private Servicios.User_Servicios usr = new Servicios.User_Servicios();
        public string user { get; set; }
        public string pass { get; set; }

        public bool Login()
        {
            return usr.Login(this);
        }

    }
}