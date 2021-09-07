using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleGetController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Example Get Response";
        }
    }
}
