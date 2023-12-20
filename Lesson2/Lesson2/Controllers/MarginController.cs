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
            return "I want to go home!!!";
        }

        [HttpDelete("{id}")]
        public List<string> Delete(string str)
        {
            var s = Strings.lst.FirstOrDefault(x => x.Equals(str));
            if (s != null)
            {
                Strings.lst.Remove(s);
            }
            return Strings.lst;
        }
        [HttpPost]
        public List<string> Post([FromBody] string value)
        {
            Strings.lst.Add(value);
            return Strings.lst;
        }
    }
}
