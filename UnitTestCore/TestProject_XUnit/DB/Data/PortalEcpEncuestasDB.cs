using DALC;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject_XUnit
{
    /// <summary>
    /// Cargue de datos mock para la BD
    /// </summary>
    public class PortalEcpEncuestasDB
    {
        public EncuestaContext ContextoCargado { get; }

        public PortalEcpEncuestasDB(EncuestaContext dbContexto)
        {
            ContextoCargado = dbContexto;
        }

        /// <summary>
        /// Inicializa la BD in Memory con una encuesta
        /// </summary>
        public void CargaEncuestaActiva()
        {
            DateTime fechaCreacion = DateTime.Now;
            OperacionesConNumeros.Model.Encuesta nuevaEncuesta = new OperacionesConNumeros.Model.Encuesta()
            { 
                Activo  = true,
                Descripcion = "Encuesta test",
                Titulo = "Encuesta activa",
                
                FechaInicio = fechaCreacion.AddDays(-1),
                FechaFinalizacion = DateTime.Now.AddDays(1)
             
            };
            ContextoCargado.Encuesta.Add(nuevaEncuesta);
            ContextoCargado.SaveChanges();

        }

    }
}
