using Microsoft.AspNetCore.Mvc;

namespace VRIS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Hello API!");
    }
}
