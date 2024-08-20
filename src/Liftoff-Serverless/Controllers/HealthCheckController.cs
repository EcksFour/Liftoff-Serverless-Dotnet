using Microsoft.AspNetCore.Mvc;

namespace Liftoff_Serverless.Controllers
{
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "test1", "test2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "id";
        }
    }
}