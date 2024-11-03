using dress_rent.entities;
using dress_rent.servise;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressController : ControllerBase
    {
       static dress_service dress_service = new dress_service();

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<dress>> Get()
        {
            List<dress> result = dress_service.GetList();
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<dress> Get(int id)
        {
            if (id < 0) return Unauthorized();
            dress result = dress_service.GetById(id);
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] dress d)
        {
            bool success = dress_service.AddDress(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] dress d)
        {
            bool flag = dress_service.Update(id, d);
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool sucess = dress_service.Remove(id); return Ok(sucess);
        }
    }
}
