using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarginController : ControllerBase
    {
        // GET: api/<MarginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MarginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MarginController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MarginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MarginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
