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

        internal bool Login(Usuario usr)
        {
            string sql = "SELECT * FROM cuenta WHERE Usuario = '" + usr.user + "' AND Contra = '" + usr.pass + "';";
            Console.WriteLine(usr.user + "  ksjahfskjdfbsd ");
            return (con.EjecutarConsulta(sql).Rows.Count > 0) ? true : false;
        }
    }
}