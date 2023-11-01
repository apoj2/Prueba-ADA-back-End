using Api.ADAproductos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<string> Insertar(RolUsuario usuario);
    }
}
