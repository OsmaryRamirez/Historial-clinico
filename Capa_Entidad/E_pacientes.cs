using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public  class E_pacientes
    {
        public int Codigo_pac { get; set; }
        public int ID_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Edad { get; set;}
        public string Sexo { get; set; }

    }
}
