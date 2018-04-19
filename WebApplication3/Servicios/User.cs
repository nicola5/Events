using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class User
    {
        private Conexion conn = new Conexion();

        public bool Register(Persona usr)
        {
            try
            {
                conn.EjecutarOperacion("call insert_Usuario('" + usr.user + "','" + usr.pass + "'," + usr. + ")");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}