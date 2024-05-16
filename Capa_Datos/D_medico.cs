using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
   public class D_medico
    {

        public DataTable ListarMedicos(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("listar_medicos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public DataTable BuscarMedico(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("buscar_medico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = valor;
                con.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

          
        }
        public string GuardarMedico(int opcion, E_medico datos)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("sp_guardar_cat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cmd.Parameters.Add("Cod_med", SqlDbType.Int).Value = datos.Codigo_med;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = datos.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = datos.Apellido;
                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = datos.Cedula;
                cmd.Parameters.Add("@ESpecialidad", SqlDbType.VarChar).Value = datos.Especialidad;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = datos.correo;
                cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = datos.Estado;


                con.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ejecutó correctamente";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }






        // Aquí puedes agregar el método para eliminar médicos si es necesario.
    }
}
    

