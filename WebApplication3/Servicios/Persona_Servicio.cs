using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class Persona_Servicio
    {
        private Conexion co = new Conexion();
        public bool registrarpersona(Persona pe)
        {
            try
            {
                return co.EjecutarOperacion("CALL pr_crearpersona('" + pe.nombre + "','" + pe.apellido+ "','" + pe.user + "'," + pe.pass+ ");");
            }
            catch (Exception)
            {
                return false;
            }
            //asdasd
        }
    }
}