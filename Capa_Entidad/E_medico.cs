using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{

    public class E_medico
    {
        public string Nombre_cat { get; set; }

     public int Codigo_med {get; set;}
     public int ID_usuario{ get; set; }
     public string Nombre{ get; set; }
     public string Apellido{ get; set; }
     public string Cedula { get; set; }
     public string Especialidad { get; set; }

    public string  Telefono{ get; set; }

     public string correo { get; set; }

        public string Estado { get; set; }

    }
}