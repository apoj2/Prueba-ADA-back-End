using Api.ADAproductos.Dominio;
using Api.ADAproductos.Dto.DtoUsuario;
using Api.ADAproductos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Negocio.implements
{
    public class UsuarioNegocio : IUsuarioNegocio
    {
        private readonly IUsuarioRepositorio _repositorio;
        public UsuarioNegocio(IUsuarioRepositorio repositorio) 
        {
            _repositorio = repositorio;
        }
        //falta retorno
        public async Task<string> Insertar(UsuarioInsertar usuario)
        {
            Usuario m_usuario = Mapping.GetMapping(usuario);
            return await _repositorio.Insertar(m_usuario);
        }
    }
}
