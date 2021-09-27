using DALC;
using OperacionesConNumeros.Model;
using System;
using System.Net;
using System.Threading.Tasks;

namespace OperacionesConNumeros
{
    public class BOEncuesta
    {
        private readonly DalcEncuesta DalcEnc;
        public BOEncuesta(EncuestaContext context)
        {
            DalcEnc = new DalcEncuesta(context);
        }

        public ResponseBase<Encuesta> GetEncuestaActiva()
        {
            try
            {
                var encuesa = DalcEnc.GetActiva();

                if (encuesa != null)
                {
                    return new ResponseBase<Encuesta>()
                    {
                        Codigo = (int)HttpStatusCode.OK,
                        Estado = true,
                        Mensaje = string.Empty,
                        Datos = encuesa
                    };
                }
                else
                {
                    return new ResponseBase<Encuesta>()
                    {
                        Codigo = (int)HttpStatusCode.NotFound,
                        Estado = false,
                        Mensaje = "No existe una encuesta activa",
                        Datos = null
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseBase<Encuesta>()
                {
                    Codigo = (int)HttpStatusCode.InternalServerError,
                    Estado = false,
                    Mensaje = $"Error: {ex.Message}",
                    Datos = null
                };
            }
        }


    }
}
