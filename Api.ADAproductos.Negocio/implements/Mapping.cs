using Api.ADAproductos.Dominio;
using Api.ADAproductos.Dto.DtoUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Negocio.implements
{
    public class Mapping
    {

        public Mapping() { }
        public static Usuario GetMapping(UsuarioInsertar valor)
        {
            return new Usuario
            {
                apodo = valor.apodo,
                celular = valor.celular,
                contrasena = valor.contrasena,
                correo_electronico = valor.correo_electronico,
                direccion = valor.direccion,
                estado = valor.estado,
                fecha_activacion = valor.fecha_activacion,
                fecha_inactivacion = valor.fecha_inactivacion,
                fecha_modificacion = valor.fecha_modificacion,
                nombre_completo = valor.nombre_completo,
                telefono = valor.telefono,
                usuario = valor.usuario,
                idrolusuario = valor.idrolusuario
            };
        }
    }
}
