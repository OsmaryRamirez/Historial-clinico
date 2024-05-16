using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;
using System.Configuration;

namespace Capa_Datos
{
    public  class D_usuario
    {
      
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_usuarios(E_usuario obje)
        {
            SqlCommand cmd = new SqlCommand("SP_listar_Usuario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@Contraseña", obje.contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
    }
}