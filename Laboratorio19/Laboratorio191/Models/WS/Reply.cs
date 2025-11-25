using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio191.Models.WS
{
    public class Reply
    {
        public int result { get; set; }     // Código de respuesta
        public string message { get; set; } // Mensaje informativo
        public object data { get; set; }    // Datos (puede ser cualquier tipo)

    }
}