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
    public class D_paciente
    {

        public DataTable Listar_paciente(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("listar_paciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                con.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                con = null;
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        public string Guardar_pacientes(int opcion,E_pacientes datos)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.GetInstancia().CreaConexion();
                SqlCommand cmd = new SqlCommand("SP_insertar_Pacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cmd.Parameters.Add("@Codigo_pac", SqlDbType.Int).Value = datos.Codigo_pac;
                cmd.Parameters.Add("@ID_usuario", SqlDbType.Int).Value = datos.ID_usuario;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = datos.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = datos.Apellido;
                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = datos.Cedula;
                cmd.Parameters.Add("@Fecha_nacimiento", SqlDbType.VarChar).Value = datos.Fecha_nacimiento;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = datos.Telefono;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = datos.Correo;
                cmd.Parameters.Add("@Edad", SqlDbType.VarChar).Value = datos.Edad;
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = datos.Sexo;
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

    }
}
