using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion cn = null;
       public Conexion()
        {
            this.Base = "Historial_clinico";
            this.Servidor = "OsmaryRamirez";
            this.Usuario = "sa";
            this.Clave = "12345";

        }

        public SqlConnection CreaConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base +
                    ";User Id=" + this.Usuario + ";Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion GetInstancia()
        {
            if (cn == null)
            {
                cn = new Conexion();
            }
            return cn;
        }
    }
}

