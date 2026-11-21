using IT3_Q2_BSIT32E2_LEANO_ANGELICAJOYCE.DTO.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT3_Q2_BSIT32E2_LEANO_ANGELICAJOYCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
           var response = new GetUserResponse
           {
               User =new()
               {
                   new () { Id = 1, Name = "John Doe", Email = "John.doe@example.com" },
                   new () { Id = 2, Name = "Cedrick James", Email = "Cedrick.James@example.com" },
                   new () { Id = 3, Name = "Angelica Joyce", Email = "Angelica.Joyce@example.com" },
                   new () { Id = 4, Name = "Angel Joy", Email = "Angel.Joy@example.com" },
                   new () { Id = 5, Name = "Lord Cedrick", Email = "Lord.Cedrick@example.com" },
                   new () { Id = 6, Name = "Rossini Claire", Email = "Rossini.Claire@example.com" },
                   new () { Id = 7, Name = "Alex Jean", Email = "Alex.Jean@example.com" },
                   new () { Id = 8, Name = "Joyce Angel", Email = "Joyce.Angel@example.com" },
                   new () { Id = 9, Name = "Jen Jen", Email = "Jen.Jen@example.com" },
                   new () { Id = 10, Name = "Pretty Lady", Email = "Pretty.Lady@example.com" }
                   }
               };
               return Ok (response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int Id)
        {
            return Ok(new GetUserByIDResponse
            {
                Name = "John Doe", Email = "John.doe@example.com"

            });        
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(new CreateUserResponse { });
        }

        // PUT api/<UserController>/5
        [HttpPut("{Id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok(new EditUserResponse { });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
