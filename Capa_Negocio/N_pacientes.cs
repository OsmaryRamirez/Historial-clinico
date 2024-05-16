using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class N_pacientes
    {
        public static string Guardar_pac(int opcion, E_pacientes datos)
        {
            D_paciente cliente = new D_paciente();
            return cliente.Guardar_pacientes(opcion, datos);
        }
        public static DataTable Listar_paciente(string valor)
        {
            D_paciente datos = new D_paciente();
            return datos.Listar_paciente(valor);
        }
    }
}
