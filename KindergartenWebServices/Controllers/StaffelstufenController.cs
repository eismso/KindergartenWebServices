using Microsoft.AspNetCore.Mvc;
using KindergartenWebServices.Models;
using KindergartenWebServices.Services;
using SecuringWebApiUsingApiKey.Attributes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KindergartenWebServices.Controllers
{
    [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class StaffelstufenController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StaffelstufenController(IConfiguration configuration)
        {
            _configuration = configuration;
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

            string reduktionswertAusconfig = _configuration["Reduktionswert"];
            int reduktionswert = int.Parse(reduktionswertAusconfig);

            if (kind.AnzahlGeschwister > 0)
            {
                for (int i = 1; i < kind.AnzahlGeschwister + 1; i++)
                {
                    kind.Staffelstufe -= reduktionswert;
                }
            }
            int staffelstufe = kind.Staffelstufe;

            return Ok(staffelstufe);
        }
    }
}
