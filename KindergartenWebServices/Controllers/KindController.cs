using KindergartenWebServices.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KindergartenWebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindController : ControllerBase
    {

        static List<Kind> kindList;

        static KindController()
        {
            kindList = new List<Kind>();
        }

        // GET: api/<Kind>
        [HttpGet]
        public List<Kind> Get()
        {
            return kindList;
        }

        // GET api/<Kind>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Kind gefunden = new Kind();
            foreach (Kind k in kindList)
            {
                if (k.KindId == id)
                {
                    gefunden = k;
                }
                    
            }

            if (gefunden.KindId == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(gefunden);
            }
        }

        // POST api/<Kind>
        [HttpPost]
        public IActionResult Post([FromBody] Kind kind)
        {
            if (kind.Betreuungsart.Length != 2 | kind.Betreuungsumfang.Length != 3)
            {
                return BadRequest();
            }

            foreach (Kind k in kindList)
            {
                if (k.SVN == kind.SVN)
                {
                    return BadRequest();
                }
            }

            kind.KindId = kindList.Count +1;
            foreach (Kind k in kindList)
            {
                if (k.KindId == kind.KindId)
                {
                    kind.KindId +=1;
                }
            }
            kindList.Add(kind);

            return CreatedAtAction("Get", new {id = kind.KindId});
        }

        // PUT api/<Kind>/5
        [HttpPut("{id}")]
        public Kind Put(int id, [FromBody] Kind kindVar)
        {
            var kind = kindList.Where(k => k.KindId == id).FirstOrDefault();
            kind.Betreuungsart = kindVar.Betreuungsart;
            kind.Betreuungsumfang = kindVar.Betreuungsumfang;
            return kind;
        }

        // DELETE api/<Kind>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var kind = kindList.Where(k => k.KindId == id).FirstOrDefault();
            kindList.Remove(kind);
        }
    }
}
