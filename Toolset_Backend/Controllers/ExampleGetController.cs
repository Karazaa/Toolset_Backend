using Microsoft.AspNetCore.Mvc;

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
