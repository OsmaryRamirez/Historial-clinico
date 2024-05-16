using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;


namespace Capa_Negocio
{
    public class N_usuario
    {
        D_usuario objd = new D_usuario();

        public DataTable N_usuarios(E_usuario obje)
        {
            return objd.D_usuarios(obje);
        }

    }
}
