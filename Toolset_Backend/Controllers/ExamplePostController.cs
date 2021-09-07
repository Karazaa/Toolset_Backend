using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamplePostController : ControllerBase
    {
        [HttpPost]
        public async Task Post()
        {
            await Request.Body.CopyToAsync(Response.Body);
        }
    }
}
