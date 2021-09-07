using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamplePutController : ControllerBase
    {
        [HttpPut]
        public string Put()
        {
            return "Example Put Response";
        }
    }
}
