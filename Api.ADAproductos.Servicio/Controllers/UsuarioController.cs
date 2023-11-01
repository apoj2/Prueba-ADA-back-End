using Api.ADAproductos.Dto.DtoUsuario;
using Api.ADAproductos.Negocio;
using Api.ADAproductos.Negocio.implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.ADAproductos.Servicio.Controllers
{
   
    public class UsuarioController : ApiController
    {
        
        private readonly IUsuarioNegocio _negocio;

        [HttpPost]
        public async Task<string> Insertar([FromBody] UsuarioInsertar usuario)
        {

            return await _negocio.Insertar(usuario);
        }
    }
}
