using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplicationNetCSharp.Controllers
{
    public class TipoNumerosController : ApiController
    {
          private readonly Bo.OperacionesConNumeros _bo = new Bo.OperacionesConNumeros();
   
        // GET api/values/5
       public string Get1(int id)
        {
            var resp =  _bo.EsPar(id).Result;

            return resp.Datos.ToString();
        }

        // GET api/values/5/1
        public string Get(int id, int id1)
        {
            var resp =  _bo.Multiplicar(id, id1).Result;

            return resp.Datos.ToString();
        } 

    }
}
