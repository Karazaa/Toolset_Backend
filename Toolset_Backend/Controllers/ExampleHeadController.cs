using Microsoft.AspNetCore.Mvc;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleHeadController : ControllerBase
    {
        [HttpHead]
        public void Head()
        {
            Response.ContentLength = 2048;
        }
    }
}
