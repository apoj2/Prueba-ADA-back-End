﻿using Api.ADAproductos.Dominio.Util.implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductos.Dominio
{
    public class Producto : Documento
    {
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
        public string estado { get; set; }
        public string fecha_activacion { get; set; }
        public string fecha_modificacion { get; set; }
        public string fecha_inactivacion { get; set; }
        public string usuario { get; set; }
    }
}
