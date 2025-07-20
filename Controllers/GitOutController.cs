using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitOutController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
            => Ok(new { name = "Rudi Vogel" });
    }
}
