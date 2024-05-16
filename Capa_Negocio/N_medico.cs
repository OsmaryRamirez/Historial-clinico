using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{

    public class N_medico
    {

        public static DataTable ListarMedicos(string valor)
        {
          D_medico datos = new D_medico();
            return datos.ListarMedicos(valor);
        }
        public static DataTable BuscarMedicos(string valor)
        {
            D_medico datos = new D_medico();
            return datos.BuscarMedico(valor);
        }
        public static string GuardarMedico(int opcion, E_medico datos)
        {
            D_medico dat  = new D_medico();
            return dat.GuardarMedico(opcion, datos);
        }






    }


}



