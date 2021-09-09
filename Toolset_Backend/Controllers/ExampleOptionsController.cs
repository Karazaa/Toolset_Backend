using Microsoft.AspNetCore.Mvc;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleOptionsController : ControllerBase
    {
        [HttpOptions]
        public string Options()
        {
            return "Some options.";
        }
    }
}
