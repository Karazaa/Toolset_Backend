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
        public async Task<byte[]> Post()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                await Request.Body.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
