using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CEATSVgrupo5
{
    class Clase_BaseDatos
    {
        private string cadenaConexion = "Data Source=TAREASESCOLARES; Initial Catalog=SQLCEATSV; integrated Security=true;";

        public static string NomUsuario = "";
        public static string ConUsuario = "";

        public Boolean InicarSesión(string nomUs, string conUs)
        {
            NomUsuario = "";
            ConUsuario = "";

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            SqlParameter parnomUs = new SqlParameter(@nomUs, nomUs);
            SqlParameter parcon = new SqlParameter(@conUs, conUs);

            SqlCommand comando = new SqlCommand("SELECT tipoUsuario, ContraseñaUsuario, NombreUsaurio FROM usuarios = @nomUs AND contraseña COLLATE Latin_General_CS_AS = @conUs", conexion);
            comando.Parameters.Add(parnomUs);
            comando.Parameters.Add(parcon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                NomUsuario = lector.GetString(0) + " " + lector.GetString(1) + " ";
                ConUsuario = lector.GetString(2);
                          
            }
            lector.Close();
            conexion.Close();

            if (string.IsNullOrEmpty(ConUsuario))
            {
                return false;
            }
            else
            {
                return true;
            }

         
        }

            
          
    }
}
