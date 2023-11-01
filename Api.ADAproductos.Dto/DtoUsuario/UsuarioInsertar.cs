using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Dto.DtoUsuario
{
    public class UsuarioInsertar
    {
        public string apodo { get; set; }
        public string nombre_completo { get; set; }
        public string correo_electronico { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string contrasena { get; set; }
        public string estado { get; set; }
        public string fecha_activacion { get; set; }
        public string fecha_modificacion { get; set; }
        public string fecha_inactivacion { get; set; }
        public string usuario { get; set; }
        public int idrolusuario { get; set; }
    }
}
