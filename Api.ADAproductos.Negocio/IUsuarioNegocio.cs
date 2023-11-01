using Api.ADAproductos.Dto.DtoUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Negocio
{
    public interface IUsuarioNegocio
    {
        Task<string> Insertar(UsuarioInsertar usuario);
    }
}
