using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamplePatchController : ControllerBase
    {
        [HttpPatch]
        public async Task Patch()
        {
            await Request.Body.CopyToAsync(Response.Body);
        }
    }
}
