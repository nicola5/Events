using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication3.Servicios
{
    public class Conexion
    {
        private MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["Event_Connection"].ConnectionString);
        private MySqlConnection ConexionMySql()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("No se puedo realizar la conexion con la Bases de Datos : " + e.Message);
            }
            return conexion;
        }

        private void desconectar()
        {
            conexion.Close();
        }
        public bool EjecutarOperacion(string sentencia)
        {
            try
            {
                MySqlCommand my = new MySqlCommand();
                my.CommandText = sentencia;
                my.Connection = ConexionMySql();
                if (my.ExecuteNonQuery() > 0)
                {
                    desconectar();
                    return true;
                }
                desconectar();
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("No se realizó ninguna operación de Registro en la Base de Datos." + e.ToString());
            }
        }
        public DataTable EjecutarConsulta(string Select)
        {
            DataTable dt = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = Select;
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(Select, ConexionMySql());
                da.Fill(dt);
                desconectar();
                return dt;
            }
            catch
            {
                desconectar();
                throw new Exception("Sentencia SQL de consulta invalida.");
            }
        }
    }
}