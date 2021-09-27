using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesConNumeros.Model
{
    /// <summary>
    /// Clase Base para generar Response
    /// </summary>
    public class ResponseBase<T>
    {
        /// <summary>
        /// Código
        /// </summary>
        public int Codigo { get; set; } = 200;
        /// <summary>
        /// Mensaje
        /// </summary>
        public string Mensaje { get; set; } = string.Empty;
        /// <summary>
        /// Estado
        /// </summary>
        public bool Estado { get; set; } = true;
        /// <summary>
        /// Datos
        /// </summary>
        public T Datos { get; set; }
    }
}
