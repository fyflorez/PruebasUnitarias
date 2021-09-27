using OperacionesConNumeros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bo
{
    public class OperacionesConNumeros
    {
        /// <summary>
        /// Valida si el numero es par
        /// </summary>
        /// <param name="Numero">numero a validar</param>
        /// <returns></returns>
        public async Task<ResponseBase<bool>> EsPar(int Numero)
        {
            var RespuestaRespuesta = new ResponseBase<bool>();
            try
            {
                var resultado = Numero % 2;

                if (resultado == 0)
                {
                    RespuestaRespuesta.Datos = true;
                    RespuestaRespuesta.Codigo = (int)HttpStatusCode.OK;
                    RespuestaRespuesta.Estado = true;
                    RespuestaRespuesta.Mensaje = "El número es Par";

                }
                else
                {
                    RespuestaRespuesta.Datos = false;
                    RespuestaRespuesta.Codigo = (int)HttpStatusCode.NotFound;
                    RespuestaRespuesta.Estado = true;
                    RespuestaRespuesta.Mensaje = "El número no es Par";

                }
            }
            catch (Exception err)
            {
                RespuestaRespuesta.Datos = false;
                RespuestaRespuesta.Codigo = (int)HttpStatusCode.InternalServerError;
                RespuestaRespuesta.Estado = true;
                RespuestaRespuesta.Mensaje = $"Error al intentar realizar Operación {err.Message}";

            }

            return RespuestaRespuesta;


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Numero1"></param>
        /// <param name="Numero2"></param>
        /// <returns></returns>
        public async Task<ResponseBase<bool>> Multiplicar(int Numero1, int Numero2)
        {
            var RespuestaRespuesta = new ResponseBase<bool>();
            checked
            {
                try
                {
                    var resultado = (Numero1 * Numero2);

                    if (resultado > 0)
                    {
                        RespuestaRespuesta.Datos = true;
                        RespuestaRespuesta.Codigo = (int)HttpStatusCode.OK;
                        RespuestaRespuesta.Estado = true;
                        RespuestaRespuesta.Mensaje = "Al multiplicar el número es mayor que 0";

                    }
                    else
                    {
                        RespuestaRespuesta.Datos = false;
                        RespuestaRespuesta.Codigo = (int)HttpStatusCode.NotFound;
                        RespuestaRespuesta.Estado = true;
                        RespuestaRespuesta.Mensaje = "Al Multiplicar el número es menor que 0";

                    }
                }
                catch (Exception err)
                {
                    RespuestaRespuesta.Datos = false;
                    RespuestaRespuesta.Codigo = (int)HttpStatusCode.InternalServerError;
                    RespuestaRespuesta.Estado = true;
                    RespuestaRespuesta.Mensaje = $"Error al intentar realizar Operación, {err.Message}";

                }
            }

            return RespuestaRespuesta;


        }
    }
}
