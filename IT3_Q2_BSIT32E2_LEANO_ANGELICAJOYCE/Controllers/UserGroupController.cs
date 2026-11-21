using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT3_Q2_BSIT32E2_LEANO_ANGELICAJOYCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        // GET: api/<UserGroupController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET api/<UserGroupController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/<UserGroupController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT api/<UserGroupController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE api/<UserGroupController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
