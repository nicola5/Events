using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class User_Servicios
    {
        Conexion con = new Conexion();
        public bool Login(User_Modelos user)
        {
            string sql = "SELECT * FROM datos WHERE login = '" + user.user + "' AND password = '" + user.pass + "';";
            return false;
        }
        //public bool registrar(User_Modelos user)
        //{
        //    try
        //    {

        //    }catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}