using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebService.Controllers
{
    [RoutePrefix("api/echo")]
    public class EchoController : ApiController
    {
        [AcceptVerbs("POST")]
        [Route("EchoPost")]
        public string EchoPost([FromBody] dynamic data)
        {
            return "Echo-"+ data.nome+" "+data.sobrenome;
        }
        
        [AcceptVerbs("GET")]
        [Route("EchoGet/{value}")]
        public string EchoGet(string value)
        {
            return "Echo-" + value;
        }
    }
}
