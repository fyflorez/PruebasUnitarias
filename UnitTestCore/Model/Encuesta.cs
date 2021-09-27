using System;
using System.Collections.Generic;

namespace OperacionesConNumeros.Model
{
    /// <summary>
    /// Definición de Encuestas
    /// </summary>
    public class Encuesta
    {
        /// <summary>
        /// IdEncuesta, autoincremental
        /// </summary>
        public Int64 IdEncuesta { get; set; }
        /// <summary>
        /// Titulo de la encuesta
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Descripción de la encuesta
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Fecha Inicio de la encuesta
        /// </summary>
        public DateTime FechaInicio { get; set; }
        /// <summary>
        /// Fecha Finalizacion de la encuesta
        /// </summary>
        public DateTime FechaFinalizacion { get; set; }
        /// <summary>
        /// Indica si está activo o no la encuesta
        /// </summary>
        public bool Activo { get; set; }
       
    }
}
