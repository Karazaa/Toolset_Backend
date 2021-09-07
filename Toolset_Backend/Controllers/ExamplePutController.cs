
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamplePutController : ControllerBase
    {
        [HttpPut]
        public async Task Put()
        {
            await Request.Body.CopyToAsync(Response.Body);
        }
    }
}
