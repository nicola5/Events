using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class User
    {
        //private Conexion conn = new Conexion();

        //public bool Register(User_Modelos usr, int fk)
        //{
        //    try
        //    {
        //        System.Data.DataRow c = conn.EjecutarConsulta("select id_Persona as t from Persona where Identificacion=" + fk).Rows[0];
        //        conn.EjecutarOperacion("call insert_Usuario('" + usr.Email + "','" + usr.Password + "'," + int.Parse(c["t"].ToString()) + ")");
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}
    }
}