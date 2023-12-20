using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarginController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpPost]
        public List<string> Post([FromBody] string value)
        {
            Strings.lst.Add(value);
            return Strings.lst;
        }
    }
}
