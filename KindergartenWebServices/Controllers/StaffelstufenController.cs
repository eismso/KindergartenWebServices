using Microsoft.AspNetCore.Mvc;
using KindergartenWebServices.Models;
using KindergartenWebServices.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KindergartenWebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffelstufenController : ControllerBase
    {
        // GET: api/<StaffelstufenRechnerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StaffelstufenRechnerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StaffelstufenRechnerController>
        [Route("/Staffelstufenberechnung")]
        [HttpPost]
        public IActionResult Post([FromBody] Kind kind)
        {
            StaffelstufenRechnerService _rechner = new StaffelstufenRechnerService();
            
            if (kind.Familieneinkommen < 0 | kind.AnzahlGeschwister <0)
            {
                return BadRequest();
            }

            _rechner.BerechneStaffelstufe(kind);
            int staffelstufe = kind.Staffelstufe;

            return Ok(staffelstufe);
        }

        // PUT api/<StaffelstufenRechnerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StaffelstufenRechnerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
