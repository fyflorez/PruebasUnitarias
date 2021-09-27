using System;
using System.Collections.Generic;
using System.Text;
using OperacionesConNumeros.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DALC
{
     public class DalcEncuesta
    {

        private readonly EncuestaContext _context;

        //private readonly DlacTransacciones<Encuesta> _DLACTransaccion;

        public DalcEncuesta(EncuestaContext context)
        {
            _context = context;
            //_DLACTransaccion = new DlacTransacciones<Encuesta>(context);
        }


        public Encuesta Get(long id)
        {
            try
            {
                var encuestaResult = _context.Encuesta
                    .Where(x => x.IdEncuesta == id )
                    .Include(p => p.Activo)
                   // .ThenInclude(Pregunta => Pregunta.)
                .FirstOrDefault();

               /// encuestaResult.Pregunta = encuestaResult.Pregunta.Where(p => !p.Eliminado).ToList();
               /* _ = encuestaResult.Pregunta.All(p =>
                {
                    p.Respuesta = p.Respuesta.Where(r => !r.Eliminado).ToList();
                    return true;
                }
                   );
               */
              
                return encuestaResult;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public Encuesta GetActiva()
        {
            try
            {
                DateTime fechaActiva = DateTime.Now;
                var encuestaActiva = _context.Encuesta
                     .Where(x => x.Activo 
                            && x.FechaInicio <= fechaActiva && x.FechaFinalizacion >= fechaActiva).AsNoTracking()
                    //.Include(p => p.Pregunta)
                    //.ThenInclude(Pregunta => Pregunta.Respuesta)
                .FirstOrDefault();

               /*ncuestaActiva.Pregunta = encuestaActiva.Pregunta.Where(p => !p.Eliminado).ToList();
                _ = encuestaActiva.Pregunta.All(p =>
                {
                    p.Respuesta = p.Respuesta.Where(r => !r.Eliminado).ToList();
                    return true;
                }
                   );*/

                return encuestaActiva;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
