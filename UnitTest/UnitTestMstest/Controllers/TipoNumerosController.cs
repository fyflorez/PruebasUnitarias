using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesConNumeros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoNumerosController : ControllerBase
    {

        private readonly Bo _bo = new Bo();
       
        /// <summary>
        /// Valida si el numero es primo 
        /// </summary>
        /// <param name="candidate">Numero a validar</param>
        /// <returns></returns>
        [HttpGet]
        [Route("EsPar/{Numero}")]
        public async Task<IActionResult> EsPar(int Numero)
        {
            var resp = await _bo.EsPar(Numero);

            return StatusCode(resp.Codigo, resp);
        }

        /// <summary>
        /// Valida si el numero es primo 
        /// </summary>
        /// <param name="candidate">Numero a validar</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Multiplicar/{Numero1}/{Numero2}")]
        public async Task<IActionResult> Multiplicar(int Numero1, int Numero2)
        {
            var resp = await _bo.Multiplicar(Numero1, Numero2);

            return StatusCode(resp.Codigo, resp);
        }
    }
}
