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
    public class ExamplePostController : ControllerBase
    {
        [HttpPost]
        public string Post()
        {
            return "Example Post Response";
        }
    }
}
