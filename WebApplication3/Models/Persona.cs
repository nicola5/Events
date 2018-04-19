using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Persona
    {
        Servicios.Persona_Servicio pe = new Servicios.Persona_Servicio();
        public String user { get; set; }
        public String pass { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }

        public bool crearpersona()
        {
            return pe.registrarpersona(this);
        }
        //sdfsdf
    }
}