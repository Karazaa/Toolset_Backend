using Microsoft.AspNetCore.Mvc;

namespace Toolset_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleDeleteController : ControllerBase
    {
        [HttpDelete]
        public void Delete()
        {
        }
    }
}
